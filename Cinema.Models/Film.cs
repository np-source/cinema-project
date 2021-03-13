namespace Cinema.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public Genre Genre { get; set; }
    }
}
