using Cinema.Models;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CinemaGeneral.Pages.Films
{
    public class FilmsModel : PageModel
    {
        private readonly IRepository<Film> _db;

        public FilmsModel(IRepository<Film> db)
        {
            _db = db;
        }

        public IEnumerable<Film> Films { get; set; }

        public void OnGet()
        {
            Films = _db.Get();
        }
    }
}
