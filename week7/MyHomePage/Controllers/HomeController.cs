using Microsoft.AspNetCore.Mvc;
using MyHomePage.Models;
using System.Diagnostics;

namespace MyHomePage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Property> Allproperties = ReadPropertiesFromFile("Allproperties.txt");
            var mostpicks = Allproperties.Where(prop => prop.Type == "Most Picks").ToList();
            var beautybackyard = Allproperties.Where(p => p.Type == "beauty backyard").ToList();
            var livingroom = Allproperties.Where(p => p.Type == "living room").ToList();
            var apartment = Allproperties.Where(p => p.Type == "Apartment").ToList();
            var first_mostpick = mostpicks.First();
            ViewData["mostpicks"] = mostpicks;
            ViewData["first_mostpick"] = first_mostpick;
            ViewData["beautybackyard"] = beautybackyard;
            ViewData["livingroom"] = livingroom;
            ViewData["apartment"] = apartment;


            return View();
        }


        public static List<Property> ReadPropertiesFromFile(string filePath)
        {
            List<Property> properties = new();

            using (StreamReader reader = new(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] fields = line.Split('|');

                        if (fields.Length >= 8)
                        {
                            string name = fields[1].Trim();
                            string city = fields[2].Trim();
                            string location = fields[3].Trim();
                            string price = fields[4].Trim();
                            string type = fields[5].Trim();
                            string popularity = fields[6].Trim();
                        

                            Property property = new(name, city, location, price, type, popularity);
                            properties.Add(property);
                        }
                    }
                }
            }

            return properties;
        }


        public IActionResult Stories()
        {
            return View();
        }
        public IActionResult Browse_by()
        {
            return View();
        }

        public IActionResult Agents()
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