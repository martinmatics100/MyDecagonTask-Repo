using System.Data;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MyHomePage.Models;

namespace MyHomePage.Repositories.User_Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string connectionString;


        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }







        public User GetUserByEmail(string email)
        {
            List<User> users = GetUsers();
            User exists = users.Find(user => user.Email == email);
            return exists;
        }








        public User GetUserByEmailAndPassword(string email, string password)
        {
            List<User> users = GetUsers();
            User exists = users.Find(user => user.Email == email && user.PassWord == HashPassword(password));
            return exists;
        }






        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO users (FirstName, LastName, Email, Pwd) VALUES (@FirstName, @LastName, @Email, @Pwd)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = user.FirstName;
                        command.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = user.LastName;
                        command.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = user.Email;
                        command.Parameters.AddWithValue("@Pwd", SqlDbType.VarChar).Value = HashPassword(user.PassWord);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    // You may want to throw or handle the exception in a different way
                }
            }
        }






        public List<User> GetUsers()
        {
            string query = "SELECT * FROM users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                List<User> users = new List<User>();

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                            string LastName = reader.GetString(reader.GetOrdinal("LastName"));
                            string Email = reader.GetString(reader.GetOrdinal("Email"));
                            string PassWord = reader.GetString(reader.GetOrdinal("Pwd"));
                            DateTime date = reader.GetDateTime(reader.GetOrdinal("DateCreation"));

                            var user = new User(Id, FirstName, LastName, Email, PassWord, date);
                            users.Add(user);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception or log the error
                    Console.WriteLine(ex.ToString());
                    throw; // Rethrow the exception or handle it in a different way
                }

                return users;
            }
        }







        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
