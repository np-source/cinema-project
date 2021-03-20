namespace Cinema.Models
{
    public class Place : BaseEntity
    {
        public int Row { get; set; }
        public int Position { get; set; }
        public Session Session { get; set; }
    }
}
