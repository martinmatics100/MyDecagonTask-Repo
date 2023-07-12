namespace MyHomePage.Models
{
    public class Property
    {
        public Property(int id, string name, string? city, string? location, decimal price, string? type, string? popularity)
        {
            Id = id;
            Name = name;
            City = city;
            Location = location;
            Price = price;
            Type = type;
            Popularity = popularity; 
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Location { get; set; }
        public decimal Price { get; set; }
        public string? Type { get; set; }
        public string? Popularity { get; set; }
    }
}