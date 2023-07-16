using System.Data;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MyHomePage.Models;
using MyHomePage.Data;
using User = MyHomePage.Data.User;

namespace MyHomePage.Repositories.User_Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly HotelDataBaseContext _signupcontext;

        public UserRepository(HotelDataBaseContext signupcontext)
        {
            _signupcontext = signupcontext;
        }




        public User GetUserByEmail(string email)
        {
            return _signupcontext.Users.FirstOrDefault(signup => signup.Email == email);
        }




        public User GetUserByEmailAndPassword(string email, string password)
        {
            string hashedPassword = HashPassword(password);
            return _signupcontext.Users.FirstOrDefault(signup => signup.Email == email && signup.Pwd == password);
        }






        public void AddUser(User user)
        {
            user.Pwd = HashPassword(user.Pwd);
            _signupcontext.Users.Add(user);
            _signupcontext.SaveChanges();
        }






        public List<User> GetUsers()
        {
            return _signupcontext.Users.ToList();
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
