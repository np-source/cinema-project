using Cinema.Models;
using System.Collections.Generic;

namespace Cinema.Services
{
    public class MockFilmRepository : MockBaseRepository<Film>, IFilmRepository
    {
        public MockFilmRepository()
        {
            _entitiesList = new List<Film>()
            {
                new Film() { Id = 0, Name = "Tor", Genre = Genre.Comedy },
                new Film() { Id = 1, Name = "Iron man", Genre = Genre.Drama },
                new Film() { Id = 2, Name = "Avatar", Genre = Genre.Drama },
                new Film() { Id = 3, Name = "Dodo", Genre = Genre.Comedy },
                new Film() { Id = 4, Name = "Devs", Genre = Genre.Horror }
            };
        }
    }
}
