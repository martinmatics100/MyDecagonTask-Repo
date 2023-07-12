using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using MyHomePage.Models;
using System.Diagnostics;

namespace MyHomePage.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserRepository _userRepository;
        private readonly IFileProvider _fileProvider;

        public RegisterController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _userRepository = new UserRepository();
        }
        private string GetFilePath()
        {
            string dataFolderPath = Path.Combine(_webHostEnvironment.ContentRootPath, "DataFiles");

            //create the directory if it doesn't exist
            if(!Directory.Exists(dataFolderPath))
            {
                Directory.CreateDirectory(dataFolderPath);
            }

            string filePath = Path.Combine(dataFolderPath, "Users.txt");
            return filePath;
        }

        private void WriteUsersToFile()
        {
            string filePath = GetFilePath();
            List<User> users = _userRepository.GetAllUsers();

            List<string> lines = new List<string>();

            // Read existing lines from the file, if it exists
            if (System.IO.File.Exists(filePath))
            {
                lines.AddRange(System.IO.File.ReadAllLines(filePath));
            }

            foreach (User user in users)
            {
                string line = $"{user.Id},{user.FirstName},{user.LastName},{user.Email},{user.PassWord}";
                lines.Add(line);
            }
            System.IO.File.WriteAllLines(filePath, lines);
        }

        private void ReadUserFromFile()
        {
            string filePath = GetFilePath();

            if(!System.IO.File.Exists(filePath))
            {
                return;
            }
            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                User user = new User
                {
                    Id = int.Parse(parts[0]),
                    FirstName = parts[1],
                    LastName = parts[2],
                    Email = parts[3],
                    PassWord = parts[4],
                };

                _userRepository.AddUser(user);
            }
        }


        // Get: /User/SignUp
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //// Get: /User/Signin
        [HttpPost]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                _userRepository.AddUser(user);
                WriteUsersToFile();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if(ModelState.IsValid)
            {
                User existingUser = _userRepository.GetUserByEmailAndPassWord(user.Email, user.PassWord);
                if (existingUser != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid UserName Or PassWord");
            }
            return View(user);
        }

        public IActionResult Welcome()
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
