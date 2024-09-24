using System.ComponentModel.DataAnnotations;

namespace Booking.Models.Data
{
    public class Trip
    {
        public int Id { get; set; }

        [Required]
        public string From { get; set; }

        [Required]
        public string To { get; set; }  

        [Required]
        public decimal PricePerAdult { get; set; }

        public decimal PricePerChild { get; set; }

        public bool IsRoundTrip { get; set; }
 
        public int  MaxNumberOfPassenger { get; set; }   
        
        public List<User> Users { get; set; }
        public List <UserTrip> UserTrips { get; set; }

        
       
    }

    public class OneWayTrip : Trip
    {
        
    }

    public class RoundTrip : Trip 
    {
        
    }


}
