using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        private ToDoAppDbEntities toDoAppDbEntities = new ToDoAppDbEntities();
        public Form1()
        {
            InitializeComponent();

            LoadAllData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Get data from UI controls
            string title = TitleBox.Text.Trim();
            string description = DescriptionBox.Text.Trim();
            DateTime dateCreated = CreatedDate.Value;
            DateTime dueDate = DueDate.Value;

            // Check if Title or Description is empty
            if (string.IsNullOrWhiteSpace(title) && string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Title and Description cannot be empty.");
                return; // Exit the method without adding the item
            }


            // Check if Title is empty
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Title cannot be empty.");
                return; // Exit the method without adding the item
            }

            // Check if Description is empty
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description cannot be empty.");
                return; // Exit the method without adding the item
            }

            try
            {
                MyList newList = new MyList
                {
                    Title = title,
                    Description = description,
                    DateCreated = dateCreated,
                    DueDate = dueDate,
                    IsCompleted = false,
                    IsDeleted = false,
                };

                toDoAppDbEntities.MyList.Add(newList);

                toDoAppDbEntities.SaveChanges();

                // Refresh the DataGridView
                RefreshDataGridView();

                // Clear the selectedList and form controls
                selectedList = null;
                TitleBox.Clear();
                DescriptionBox.Clear();
                CreatedDate.Value = DateTime.Now;
                DueDate.Value = DateTime.Now;

                MessageBox.Show("Operation successful.");
            }
            catch (Exception ex)
            {
                // Handle other exceptions if needed
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }





        private void RefreshDataGridView()
        {
            // Get the data from the database
            var data = toDoAppDbEntities.MyList.ToList(); // Fetch all records, you can apply filtering as needed

            // Bind the DataGridView to the updated data source
            dataGridView.DataSource = null; // Clear the current data source
            dataGridView.DataSource = data; // Set the data source to the updated data
        }

        private MyList selectedList; // Declare a class-level variable to store the selected list item
        private void EditButton_Click(object sender, EventArgs e)
        {
            PopulateFormDataFromSelectedRow();
        }

        private void PopulateFormDataFromSelectedRow()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Make sure you use the correct column indices here
                string title = selectedRow.Cells["Title"].Value.ToString(); // Replace 0 with the actual column index
                string description = selectedRow.Cells["Description"].Value.ToString(); // Replace 1 with the actual column index
                DateTime dateCreated = Convert.ToDateTime(selectedRow.Cells["DateCreated"].Value); // Replace 2 with the actual column index
                DateTime dueDate = Convert.ToDateTime(selectedRow.Cells["DueDate"].Value); // Replace 3 with the actual column index

                // Capture the data from the selected row
                selectedList = new MyList
                {
                    Title = title,
                    Description = description,
                    DateCreated = dateCreated,
                    DueDate = dueDate
                };

                // Populate the form's controls with the captured data
                TitleBox.Text = selectedList.Title;
                DescriptionBox.Text = selectedList.Description;
                CreatedDate.Value = Convert.ToDateTime(selectedList.DateCreated);
                DueDate.Value = Convert.ToDateTime(selectedList.DueDate);
            }
            else
            {
                MessageBox.Show("Please select a row from the DataGridView.");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (selectedList != null)
            {
                // Get the updated data from the form controls
                string updatedTitle = TitleBox.Text;
                string updatedDescription = DescriptionBox.Text;
                DateTime updatedDateCreated = CreatedDate.Value;
                DateTime updatedDueDate = DueDate.Value;

                
                    // Update the selected list item with the edited values
                    selectedList.Title = updatedTitle;
                    selectedList.Description = updatedDescription;
                    selectedList.DateCreated = updatedDateCreated;
                    selectedList.DueDate = updatedDueDate;

                    // Set the state of the selected item to Modified
                    toDoAppDbEntities.Entry(selectedList).State = EntityState.Modified;

                    // Save changes to the database
                    toDoAppDbEntities.SaveChanges();

                    // Refresh the DataGridView
                    RefreshDataGridView();

                    // Clear the selectedList and form controls
                    selectedList = null;
                    TitleBox.Clear();
                    DescriptionBox.Clear();
                    CreatedDate.Value = DateTime.Now;
                    DueDate.Value = DateTime.Now;

                    MessageBox.Show("Update successful.");
                
            }
            else
            {
                MessageBox.Show("No item is selected for update. Please select a row from the DataGridView.");
            }
        }

        private void LoadAllData()
        {
            try
            {
                // Get all records from the database
                var data = toDoAppDbEntities.MyList.ToList();

                // Bind the DataGridView to the retrieved data
                dataGridView.DataSource = data;

                //MessageBox.Show("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                // Handle exceptions if needed
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            // Call the method to load all data
            LoadAllData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete selected item(s)?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (dataGridView.SelectedRows.Count == 1)
                        {
                            // Single item selected, display singular message
                            DeleteSingleItem();
                        }
                        else
                        {
                            // Multiple items selected, display plural message
                            DeleteMultipleItems();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions if needed
                        MessageBox.Show("An error occurred while deleting the item(s): " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one or more rows from the DataGridView to delete.");
            }
        }

        private void DeleteSingleItem()
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

            // Assuming 'Id' is the primary key of your 'MyList' entity
            int selectedItemId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            // Find the entity in the context
            var itemToDelete = toDoAppDbEntities.MyList.Find(selectedItemId);

            if (itemToDelete != null)
            {
                // Remove the entity from the context
                toDoAppDbEntities.MyList.Remove(itemToDelete);

                // Save changes to delete the record from the database
                toDoAppDbEntities.SaveChanges();

                // Refresh the DataGridView to reflect the deletion
                RefreshDataGridView();

                MessageBox.Show("Item deleted successfully.");
            }
            else
            {
                MessageBox.Show("Item not found in the database.");
            }
        }

        private void DeleteMultipleItems()
        {
            foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
            {
                // Assuming 'Id' is the primary key of your 'MyList' entity
                int selectedItemId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Find the entity in the context
                var itemToDelete = toDoAppDbEntities.MyList.Find(selectedItemId);

                if (itemToDelete != null)
                {
                    // Remove the entity from the context
                    toDoAppDbEntities.MyList.Remove(itemToDelete);
                }
                else
                {
                    MessageBox.Show("Item not found in the database.");
                    return; // Exit the loop on the first failure
                }
            }

            // Save changes to delete the records from the database
            toDoAppDbEntities.SaveChanges();

            // Refresh the DataGridView to reflect the deletions
            RefreshDataGridView();

            MessageBox.Show("Selected items deleted successfully.");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchBox.Text.Trim(); // Get the search term from the TextBox

            // Check if the search term is empty
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            try
            {
                // Get the data from the database and filter based on the search term
                var filteredData = toDoAppDbEntities.MyList
                    .Where(item => item.Title.Contains(searchTerm) || item.Description.Contains(searchTerm))
                    .ToList();

                if (filteredData.Any())
                {
                    // Bind the DataGridView to the filtered data
                    dataGridView.DataSource = null; // Clear the current data source
                    dataGridView.DataSource = filteredData; // Set the data source to the filtered data

                    MessageBox.Show("Search results loaded successfully.");
                }
                else
                {
                    // No matching results found
                    dataGridView.DataSource = null; // Clear the current data source
                    MessageBox.Show("No matching results found.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if needed
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }

    }
}
