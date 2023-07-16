using DocumentFormat.OpenXml.CustomProperties;
using MyHomePage.Data;
using MyHomePage.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace MyHomePage.Repositories.Hotel_Repository
{
    public class HotelRepository : IHotelRepository
    {

        private readonly HotelDataBaseContext _propertyContext;

        public HotelRepository(HotelDataBaseContext propertyContext)
        {
            _propertyContext = propertyContext;
        }


        public List<Hotel> GetHotels()
        {

            return _propertyContext.Hotels.ToList();

        }

    }
}
