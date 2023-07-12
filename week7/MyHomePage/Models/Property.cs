namespace MyHomePage.Models
{
    public class Property
    {
        public Property(string name, string? city, string? location, string? price, string? type, string? popularity)
        {
            Name = name;
            City = city;
            Location = location;
            Price = price;
            Type = type;
            Popularity = popularity; 
        }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Location { get; set; }
        public string? Price { get; set; }
        public string? Type { get; set; }
        public string? Popularity { get; set; }
    }
}
