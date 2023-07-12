using MyHomePage.Models;

namespace MyHomePage.Models
{
    public class UserRepository
    {
        private List<User> _users;
        private int _nextId;

         public UserRepository()
        {
            _users = new List<User>();
            _nextId = 1;
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public void AddUser(User user)
        {
            user.Id = _nextId;
            _users.Add(user);
            _nextId++;
        }

        public User GetUserByEmailAndPassWord(string email, string passWord)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.PassWord == passWord);
        }
    }
}
