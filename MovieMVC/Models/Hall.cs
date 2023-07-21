namespace MovieMVC.Models
{
    public class Hall
    {
        public int HallId { get; set; }
        public string HallName { get; set; }

        // Foreign key to establish the one-to-many relationship with Movie
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        // Navigation property for the one-to-many relationship with Shift
        public ICollection<Shift> Shifts { get; set; }
    }

}
