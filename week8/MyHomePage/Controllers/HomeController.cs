using Microsoft.AspNetCore.Mvc;
using MyHomePage.Models;
using MyHomePage.Repositories.Hotel_Repository;
using System.Diagnostics;

namespace MyHomePage.Controllers
{

    public class HomeController : Controller
    {
        private readonly IHotelRepository _hotelRepository;
        public HomeController(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public IActionResult Index()
        {
            List<Property> Allproperties = _hotelRepository.GetHotels();

            //List<Property> Allproperties = ReadPropertiesFromFile("Allproperties.txt");
            var mostpicks = Allproperties.Where(prop => prop.Popularity == "Most Picks").ToList();
            var beautybackyard = Allproperties.Where(p => p.Type == "beauty backyard").ToList();
            var livingroom = Allproperties.Where(p => p.Type == "living room").ToList();
            var apartment = Allproperties.Where(p => p.Type == "Apartment").ToList();
            //var first_mostpick = mostpicks.First();
            ViewData["mostpicks"] = mostpicks;
            //ViewData["first_mostpick"] = first_mostpick;
            ViewData["beautybackyard"] = beautybackyard;
            ViewData["livingroom"] = livingroom;
            ViewData["apartment"] = apartment;


            string? LoggedInuserId = HttpContext.Session.GetString("loggedIn_UserId");

            ViewBag.SuccessMessage = TempData["Message"]?.ToString();

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