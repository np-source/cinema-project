using Cinema.Models;
using System;
using System.Collections.Generic;

namespace Cinema.Services
{
    public class MockFilmRepository : MockBaseRepository<Film>, IFilmRepository
    {
        List<Place> Places = new List<Place>()
        {
            new Place() {Row = 1, Position = 1 },
            new Place() {Row = 1, Position = 2 },
            new Place() {Row = 1, Position = 3 },
            new Place() {Row = 1, Position = 4 },
            new Place() {Row = 2, Position = 1 },
            new Place() {Row = 2, Position = 2 },
            new Place() {Row = 2, Position = 3 },
            new Place() {Row = 2, Position = 4 },
        };
        public MockFilmRepository()
        {
            _entitiesList = new List<Film>()
            {
                new Film()
                {
                    Id = 0,
                    Name = "Tor",
                    Genre = Genre.Comedy,
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 0,
                            Time = DateTime.Now,
                            Places = Places
                        },
                        new Session()
                        {
                            Id = 1,
                            Time = DateTime.Now,
                            Places = Places
                        },
                        new Session()
                        {
                            Id = 2,
                            Time = DateTime.Now,
                            Places = Places
                        },
                        new Session()
                        {
                            Id = 3,
                            Time = DateTime.Now,
                            Places = Places
                        }
                    }
                },
                new Film() { Id = 1, Name = "Iron man", Genre = Genre.Drama },
                new Film() { Id = 2, Name = "Avatar", Genre = Genre.Drama },
                new Film() { Id = 3, Name = "Dodo", Genre = Genre.Comedy },
                new Film() { Id = 4, Name = "Devs", Genre = Genre.Horror }
            };
        }
    }
}
