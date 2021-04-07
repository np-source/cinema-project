using Cinema.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Services
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> opt) : base(opt) { }


        public DbSet<Film> Films { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
