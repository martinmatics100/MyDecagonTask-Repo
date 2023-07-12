using MyHomePage.Models;

namespace MyHomePage.Repositories.User_Repository
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUserByEmailAndPassword(string email, string password);
        User GetUserByEmail(string email);
        void AddUser(User user);
        string HashPassword(string password);
    }
}
