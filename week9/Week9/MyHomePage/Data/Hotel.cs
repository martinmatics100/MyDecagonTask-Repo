using System;
using System.Collections.Generic;

namespace MyHomePage.Data;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string HotelImageUrl { get; set; } = null!;

    public string HotelName { get; set; } = null!;

    public string HotelLocation { get; set; } = null!;

    public decimal? HotelPrice { get; set; }

    public string HotelDescription { get; set; } = null!;

    public string? HotelPopularity { get; set; }
}
