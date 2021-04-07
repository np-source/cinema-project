using Cinema.Models;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CinemaGeneral.Pages.Films
{
    public class FilmsModel : PageModel
    {
        private readonly IRepository _db;

        public FilmsModel(IRepository db)
        {
            _db = db;
        }

        public IEnumerable<Film> Films { get; set; }

        public void OnGet()
        {
            Films = _db.GetAllFilms();
        }
    }
}
