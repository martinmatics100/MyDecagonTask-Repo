using Microsoft.AspNetCore.Mvc;
using MyHomePage.Data;
using MyHomePage.Models;
using MyHomePage.Repositories.Hotel_Repository;
using System.Diagnostics;

namespace MyHomePage.Controllers
{

    public class HomeController : Controller
    {

        private readonly IHotelRepository _repository;
        private readonly IConfiguration _configuration;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IHotelRepository repository)
        {
            _logger = logger;
            _configuration = configuration;
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Hotel> Allproperties = _repository.GetHotels();

            //List<Property> Allproperties = ReadPropertiesFromFile("Allproperties.txt");
            var mostpicks = Allproperties.Where(prop => prop.HotelPopularity == "Most Picks").ToList();
            var beautybackyard = Allproperties.Where(p => p.HotelDescription == "beauty backyard").ToList();
            var livingroom = Allproperties.Where(p => p.HotelDescription == "living room").ToList();
            var apartment = Allproperties.Where(p => p.HotelDescription == "Apartment").ToList();
            var first_mostpick = mostpicks.First();
            ViewData["mostpicks"] = mostpicks;
            ViewData["first_mostpick"] = first_mostpick;
            ViewData["beautybackyard"] = beautybackyard;
            ViewData["livingroom"] = livingroom;
            ViewData["apartment"] = apartment;

            return View();
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