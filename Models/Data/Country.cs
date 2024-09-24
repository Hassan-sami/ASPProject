namespace Booking.Models.Data
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Continent { get; set; }

        public List<City> Cities { get; set; }

    }
}
