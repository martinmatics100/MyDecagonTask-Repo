using MyHomePage.Models;

namespace MyHomePage.Repositories.Hotel_Repository
{
    public interface IHotelRepository
    {
        List<Property> GetHotels();
    }
}
