using MyHomePage.Models;
using User = MyHomePage.Data.User;

namespace MyHomePage.Repositories.User_Repository
{
    public interface IUserRepository
    {
       
        User GetUserByEmailAndPassword(string email, string password);
        User GetUserByEmail(string email);
        void AddUser(User user);
        string HashPassword(string password);
        List<User> GetUsers();
    }
}
