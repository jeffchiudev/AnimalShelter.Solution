namespace AnimalShelter.Models
{
    public class Foster
    {
        public int FosterId { get; set; }
        public string FosterName { get; set; }
        public string FosterEmail { get; set; } //contact info
        public bool FosterAvailability { get; set; } //is foster open for fostering
    }
}