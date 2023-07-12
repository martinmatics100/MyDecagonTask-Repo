using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Configuration;
using MyHomePage.Models;
using System.Diagnostics;
using System.Data.SqlClient;
using MyHomePage.Repositories.User_Repository;

namespace MyHomePage.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserRepository _userRepository;

        public RegisterController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //("register", Name = "RegisterPost")
        [HttpPost("register", Name = "RegisterPost")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Access the form data from the signUpModel object
                int id = user.Id;
                string? FirstName = user.FirstName;
                string? LastName = user.LastName;
                string? Email = user.Email;
                string? PassWord = user.PassWord;
                string? hashedPassword = _userRepository.HashPassword(PassWord);
                DateTime? dateCreated = user.RegDate;


                User? UserExist = _userRepository.GetUserByEmail(Email);

                if (UserExist is null)
                {
                    _userRepository.AddUser(user);
                    // Redirect to Login page
                    TempData["Message"] = "Registration was successful. Login here.";
                    return RedirectToAction("Login");

                }
                else
                {
                    TempData["ErrorMessage"] = "User Already Exist.";
                    return View(user);
                }

            }
            else
            {
                // If the model state is not valid, return the view with validation errors
                TempData["ErrorMessage"] = "A problem occurred. Please check your input.";
                return View(user);
            }


        }

        // Get: /User/SignUp
        [HttpGet("register", Name = "RegisterGet")]
        public IActionResult Register()
        {
            return View();
        }





        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                // Retrieve the user's input
                string? email = user.Email;
                string? password = user.PassWord;


                var UserExist = _userRepository.GetUserByEmailAndPassword(email, password);

                if (UserExist != null)
                {
                    string loggedInUserId = UserExist.Id.ToString();
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
