namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            TitleTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            SearchButton = new Button();
            LoadButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            DateCreatedTextBox = new DateTimePicker();
            label5 = new Label();
            SearchBox = new TextBox();
            DueDateTextBox = new DateTimePicker();
            label6 = new Label();
            GridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(209, -2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "DateCreated";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-3, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 26);
            label3.TabIndex = 3;
            label3.Text = "Description :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-3, 43);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 4;
            label4.Text = "Title :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Menu;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-4, -2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 5;
            label1.Text = "myToDoList";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleTextBox
            // 
            TitleTextBox.AllowDrop = true;
            TitleTextBox.BorderStyle = BorderStyle.None;
            TitleTextBox.Location = new Point(4, 64);
            TitleTextBox.Margin = new Padding(2, 2, 2, 2);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(175, 16);
            TitleTextBox.TabIndex = 6;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(1, 103);
            DescriptionTextBox.Margin = new Padding(2, 2, 2, 2);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(735, 22);
            DescriptionTextBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ActiveCaption;
            SearchButton.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(645, 61);
            SearchButton.Margin = new Padding(2, 2, 2, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(78, 33);
            SearchButton.TabIndex = 8;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = SystemColors.ActiveCaption;
            LoadButton.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LoadButton.Location = new Point(536, 38);
            LoadButton.Margin = new Padding(2, 2, 2, 2);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(78, 25);
            LoadButton.TabIndex = 9;
            LoadButton.Text = "LoadAll";
            LoadButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.ActiveCaption;
            EditButton.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.Location = new Point(536, 67);
            EditButton.Margin = new Padding(2, 2, 2, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(78, 29);
            EditButton.TabIndex = 10;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.ActiveCaption;
            DeleteButton.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(439, 47);
            DeleteButton.Margin = new Padding(2, 2, 2, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(78, 33);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ActiveCaption;
            AddButton.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.Location = new Point(536, 1);
            AddButton.Margin = new Padding(2, 2, 2, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(78, 34);
            AddButton.TabIndex = 12;
            AddButton.Text = "Add/Save";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // DateCreatedTextBox
            // 
            DateCreatedTextBox.Location = new Point(209, 14);
            DateCreatedTextBox.Margin = new Padding(2, 2, 2, 2);
            DateCreatedTextBox.Name = "DateCreatedTextBox";
            DateCreatedTextBox.Size = new Size(210, 23);
            DateCreatedTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.Font = new Font("SimSun", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(634, 13);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 14);
            label5.TabIndex = 14;
            label5.Text = "Enter search...          ";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(634, 29);
            SearchBox.Margin = new Padding(2, 2, 2, 2);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(106, 23);
            SearchBox.TabIndex = 15;
            // 
            // DueDateTextBox
            // 
            DueDateTextBox.Location = new Point(209, 61);
            DueDateTextBox.Margin = new Padding(2, 2, 2, 2);
            DueDateTextBox.Name = "DueDateTextBox";
            DueDateTextBox.Size = new Size(210, 23);
            DueDateTextBox.TabIndex = 16;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(209, 46);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 17;
            label6.Text = "DueDate";
            // 
            // GridView1
            // 
            GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView1.BackgroundColor = SystemColors.ActiveCaption;
            GridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView1.Location = new Point(-4, 141);
            GridView1.Margin = new Padding(2, 2, 2, 2);
            GridView1.Name = "GridView1";
            GridView1.RowHeadersWidth = 62;
            GridView1.RowTemplate.Height = 33;
            GridView1.Size = new Size(743, 265);
            GridView1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(734, 399);
            Controls.Add(GridView1);
            Controls.Add(label6);
            Controls.Add(DueDateTextBox);
            Controls.Add(SearchBox);
            Controls.Add(label5);
            Controls.Add(DateCreatedTextBox);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(LoadButton);
            Controls.Add(SearchButton);
            Controls.Add(DescriptionTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox TitleTextBox;
        private TextBox DescriptionTextBox;
        private Button SearchButton;
        private Button LoadButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button AddButton;
        private DateTimePicker DateCreatedTextBox;
        private Label label5;
        private TextBox SearchBox;
        private DateTimePicker DueDateTextBox;
        private Label label6;
        private DataGridView GridView1;
    }
}