using MyHomePage.Data;
using MyHomePage.Models;

namespace MyHomePage.Repositories.Hotel_Repository
{
    public interface IHotelRepository
    {
        List<Hotel> GetHotels();
    }
}
