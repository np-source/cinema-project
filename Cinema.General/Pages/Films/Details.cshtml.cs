using Cinema.Models;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.General.Pages.Films
{
    public class DetailsModel : PageModel
    {
        private readonly IFilmRepository _db;

        public DetailsModel(IFilmRepository db)
        {
            _db = db;
        }

        public Film Film { get; private set; }

        public IActionResult OnGet(int id)
        {
            Film = _db.GetByID(id);

            return Page();
        }
    }
}
