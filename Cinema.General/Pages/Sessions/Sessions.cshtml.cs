using Cinema.Models;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Cinema.General.Pages.Sessions
{
    public class SessionsModel : PageModel
    {
        class Place
        {
            public int Id { get; set; }
        }

        class Places
        {
            public List<Place> places { get; set; }
        }

        private readonly IRepository _db;

        public SessionsModel(IRepository db)
        {
            _db = db;
        }

        public Session Session { get; private set; }

        public void OnGet(int id)
        {
            Session = _db.GetSessionById(id);
            Session.Places = _db.GetAllPlaces().ToList();
        }

        public void OnPostSend([FromBody] JsonElement body)
        {
            if (body.ValueKind.ToString() != "Undefined")
            {
                //Session = _db.GetByID(0);
                string json = System.Text.Json.JsonSerializer.Serialize(body);
            }
        }
    }
}
