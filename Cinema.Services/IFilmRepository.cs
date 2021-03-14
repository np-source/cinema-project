using Cinema.Models;

namespace Cinema.Services
{
    public interface IFilmRepository : IRepository<Film>
    {
        void Update(Film filmToUpdate);
    }
}
