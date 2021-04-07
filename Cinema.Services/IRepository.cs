using Cinema.Models;
using System;
using System.Collections.Generic;

namespace Cinema.Services
{
    public interface IRepository
    {
        IEnumerable<Film> GetAllFilms();
        Film GetFilmById(int id);

        IEnumerable<Session> GetAllSessions();
        Session GetSessionById(int id);

        IEnumerable<Place> GetAllPlaces();
    }
}
