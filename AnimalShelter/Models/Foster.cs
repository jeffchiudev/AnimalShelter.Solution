using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Foster
    {
        public int FosterId { get; set; }
        [Required]
        public string FosterName { get; set; }
        [Required]
        public string FosterEmail { get; set; } //contact info
        public bool FosterAvailability { get; set; } //is foster open for fostering
    }
}