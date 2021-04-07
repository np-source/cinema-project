using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Services
{
    public class Repository : IRepository
    {
        private readonly CinemaDbContext _context;

        public Repository(CinemaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Film> GetAllFilms()
        {
            return _context.Films.ToList();
        }

        public Film GetFilmById(int id)
        {
            var film = _context.Films.FirstOrDefault(x => x.Id == id);
            film.Sessions = GetAllSessions().ToList();
            return film;
        }

        public IEnumerable<Session> GetAllSessions()
        {
            return _context.Sessions.ToList();
        }

        public Session GetSessionById(int id)
        {
            var session = _context.Sessions.FirstOrDefault(x => x.Id == id);
            return session;
        }

        public IEnumerable<Place> GetAllPlaces()
        {
            return _context.Places.ToList();
        }
    }
}
