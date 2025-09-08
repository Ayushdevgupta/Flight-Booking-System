using System.ComponentModel.DataAnnotations;

namespace PlaneBookingSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public string PassengerName { get; set; }

        [Required]
        public string FlightNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime TravelDate { get; set; }

        [Required]
        public string SeatClass { get; set; }  // Economy, Business, First
    }
}
