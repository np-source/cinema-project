using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema.Services
{
    public class MockFilmRepository : MockBaseRepository<Film>, IFilmRepository
    {
        public MockFilmRepository()
        {
            List<Film> Films = new List<Film>();
            List<Session> Sessions = new List<Session>();
            List<Place> Places = new List<Place>();

            Films = new List<Film>()
            {
                new Film()
                {
                    Id = 0,
                    Name = "Tor",
                    Genre = Genre.Comedy
                },
                new Film()
                {
                    Id = 1,
                    Name = "Iron man",
                    Genre = Genre.Drama,
                },
                new Film()
                {
                    Id = 2,
                    Name = "Avatar",
                    Genre = Genre.Drama
                },
                new Film()
                {
                    Id = 3,
                    Name = "Dodo",
                    Genre = Genre.Comedy
                },
                new Film()
                {
                    Id = 4,
                    Name = "Devs",
                    Genre = Genre.Horror
                }
            };

            Sessions = new List<Session>()
            {
                new Session()
                {
                    Id = 0,
                    Time = new DateTime(2020, 3, 20, 10, 15, 0),
                    Places = Places,
                    Film = Films.First(x => x.Id ==  0)
                },
                new Session()
                {
                    Id = 1,
                    Time = DateTime.Now,
                    Places = Places,
                    Film = Films.First(x => x.Id ==  0)
                },
                new Session()
                {
                    Id = 2,
                    Time = DateTime.Now,
                    Places = Places,
                    Film = Films.First(x => x.Id ==  0)
                },
                new Session()
                {
                    Id = 3,
                    Time = DateTime.Now,
                    Places = Places,
                    Film = Films.First(x => x.Id ==  0)
                },
                new Session()
                {
                    Id = 4,
                    Time = DateTime.Now,
                    Places = Places,
                    Film = Films.First(x => x.Id ==  0)
                },
                new Session()
                {
                    Id = 5,
                    Time = DateTime.Now,
                    Places = Places,
                    Film = Films.First(x => x.Id ==  0)
                }
            };

            Places = new List<Place>()
            {
                new Place()
                {
                    Id = 0,
                    Row = 1,
                    Position = 1,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 1,
                    Row = 1,
                    Position = 2,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 2,
                    Row = 1,
                    Position = 3,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 3,
                    Row = 1,
                    Position = 4,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 4,
                    Row = 1,
                    Position = 5,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 5,
                    Row = 2,
                    Position = 1,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 6,
                    Row = 2,
                    Position = 2,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 7,
                    Row = 2,
                    Position = 3,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 8,
                    Row = 2,
                    Position = 4,
                    Session = Sessions.First(x => x.Id ==  0)
                },
                new Place()
                {
                    Id = 9,
                    Row = 2,
                    Position = 5,
                    Session = Sessions.First(x => x.Id ==  0)
                },
            };

            Films.First(x => x.Id == 0).Sessions = Sessions;
            Sessions.First(x => x.Id == 0).Places = Places;

            _entitiesList = Films;
        }
    }
}
