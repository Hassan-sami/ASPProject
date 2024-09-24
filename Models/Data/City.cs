namespace Booking.Models.Data
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public int CountryId { get; set; }

        public bool FromTopTen { get; set; }

        public Country Country { get; set; }

        public List<Hotel> Hotels { get; set; }
    }
}
