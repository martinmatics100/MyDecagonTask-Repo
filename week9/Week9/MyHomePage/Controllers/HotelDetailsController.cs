using Microsoft.AspNetCore.Mvc;
using MyHomePage.Models;

namespace MyHomePage.Controllers
{
    public class HotelDetailsController : Controller
    {

        private readonly ILogger<HotelDetailsController> _logger;

        public HotelDetailsController(ILogger<HotelDetailsController> logger)
        {
            _logger = logger;
        }
        public IActionResult MostPicked()
        {
            //List<Property> Allproperties = ReadPropertiesFromFile("Allproperties.txt");
            //var section1 = Allproperties.Where(prop => prop.Type == "section1").ToList();
            //ViewData["section1"] = section1;

            return View();
        }

        //public static List<Property> ReadPropertiesFromFile(string filePath)
        //{
        //    List<Property> properties = new();

        //    using (StreamReader reader = new(filePath))
        //    {
        //        string line;
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            if (!string.IsNullOrWhiteSpace(line))
        //            {
        //                string[] fields = line.Split('|');

        //                if (fields.Length >= 8)
        //                {
        //                    string name = fields[1].Trim();
        //                    string city = fields[2].Trim();
        //                    string location = fields[3].Trim();
        //                    string price = fields[4].Trim();
        //                    string type = fields[5].Trim();
        //                    string popularity = fields[6].Trim();


        //                    Property property = new(name, city, location, price, type, popularity);
        //                    properties.Add(property);
        //                }
        //            }
        //        }
        //    }

        //    return properties;
        //}

    }
}
