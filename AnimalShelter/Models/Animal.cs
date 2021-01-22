using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        public string AnimalName { get; set; }
        [Required]
        public string Species { get; set; }
        public string Breed { get; set; }
        [Required]
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}