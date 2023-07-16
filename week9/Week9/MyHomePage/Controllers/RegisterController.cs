using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Configuration;
using MyHomePage.Models;
using System.Diagnostics;
using System.Data.SqlClient;
using MyHomePage.Repositories.User_Repository;
using Microsoft.EntityFrameworkCore;
using MyHomePage.Data;
using User = MyHomePage.Data.User;

namespace MyHomePage.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly IServiceProvider _serviceProvider;

        public RegisterController(IUserRepository repository, IServiceProvider serviceProvider)
        {
            _repository = repository;
            _serviceProvider = serviceProvider;
        }

        // Get: /User/SignUp
        [HttpGet("register", Name = "RegisterGet")]
        public IActionResult Register()
        {
            return View();
        }


        //("register", Name = "RegisterPost")
        [HttpPost("register", Name = "RegisterPost")]
        public IActionResult Register(User user)
        {
            try
            {
                user.Pwd = _repository.HashPassword(user.Pwd); // Assuming _repository is an instance of your repository or service class

                using (var context = new HotelDataBaseContext(_serviceProvider.GetRequiredService<DbContextOptions<HotelDataBaseContext>>()))
                {
                    context.Set<User>().Add(user);
                    context.SaveChanges();
                }

                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during signup: " + ex.Message);
                return View();
            }

        }






        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                // Retrieve the user's input
                string email = user.Email;
                string password = user.Pwd;

                var userExist = _repository.GetUserByEmailAndPassword(email, password);

                if (userExist != null)
                {
                    string loggedInUserId = userExist.Id.ToString();
                    HttpContext.Session.SetString("loggedIn_UserId", loggedInUserId);
                    TempData["Message"] = "Login Successful";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Invalid credentials, display an error message
                    TempData["ErrorMessage"] = "Invalid Sign in Credentials.";
                    return View(user);
                }
            }
            else
            {
                // If the model state is not valid or the login is unsuccessful,
                // return the view with validation errors or error message
                TempData["ErrorMessage"] = "A problem occurred. Please check your input.";
                return View(user);
            }
        }




        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
