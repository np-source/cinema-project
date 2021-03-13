using Cinema.Models;
using System.Collections.Generic;

namespace Cinema.Services
{
    public interface IFilmRepository
    {
        IEnumerable<Film> GetAllFilms();
    }
}
