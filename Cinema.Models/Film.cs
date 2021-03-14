namespace Cinema.Models
{
    public class Film : BaseEntity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public Genre Genre { get; set; }
    }
}
