using MyHomePage.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace MyHomePage.Repositories.Hotel_Repository
{
    public class HotelRepository : IHotelRepository
    {

        private readonly string connectionString;



        public HotelRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }







        public List<Property> GetHotels()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Hotel";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Property> hotels = new List<Property>();

                        while (reader.Read())
                        {
                            int hotelID = reader.GetInt32(reader.GetOrdinal("hotelID"));
                            string hotelImageUrl = reader.GetString(reader.GetOrdinal("hotelImageURL"));
                            string hotelName = reader.GetString(reader.GetOrdinal("hotelName"));
                            string hotelLocation = reader.GetString(reader.GetOrdinal("hotelLocation"));
                            decimal hotelPrice = reader.GetDecimal(reader.GetOrdinal("hotelPrice"));
                            string hotelDescription = reader.GetString(reader.GetOrdinal("hotelDescription"));
                            string hotelPopularity = reader.GetString(reader.GetOrdinal("hotelPopularity"));

                            var hotel = new Property(hotelID, hotelImageUrl, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelPopularity);

                            hotels.Add(hotel);
                        }

                        return hotels;
                    }
                }
            }
        }

    }
}
