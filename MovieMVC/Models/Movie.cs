namespace MovieMVC.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }

        // Navigation property for the one-to-many relationship with Shift
        public ICollection<Shift> Shifts { get; set; }
    }

}
