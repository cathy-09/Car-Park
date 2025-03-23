using System.ComponentModel.DataAnnotations;

namespace Car_Park.Data
{
    public class Trip
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Route { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime ExpectedReturnTime { get; set; }

        public DateTime? ActualReturnTime { get; set; }

        [Required]
        public string Status { get; set; }  // "Pending", "InProgress", "Canceled", "Completed"

        public string DriverId { get; set; }
        public ApplicationUser Driver { get; set; } 
    }
}
