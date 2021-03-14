using Cinema.Models;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CinemaGeneral.Pages.Films
{
    public class FilmsModel : PageModel
    {
        private readonly IFilmRepository _db;

        public FilmsModel(IFilmRepository db)
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
