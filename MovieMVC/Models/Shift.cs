namespace MovieMVC.Models
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public DateTime ShiftTime { get; set; }

        //// Foreign keys to establish the one-to-many relationships
        //public int MovieId { get; set; }
        //public Movie Movie { get; set; }

        public int HallId { get; set; }
        public Hall Hall { get; set; }
    }

}
