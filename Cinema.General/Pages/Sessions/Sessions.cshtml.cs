using Cinema.Models;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        private readonly ISessionRepository _db;

        public SessionsModel(ISessionRepository db)
        {
            _db = db;
        }

        public Session Session { get; private set; }

        public void OnGet(int id)
        {
            Session = _db.GetByID(id);
        }

        //public void OnPostReservePlaces(int id)
        //{
        //    Session = _db.GetByID(id);

        //    //foreach (var place in Session.Places)
        //    //{
        //    //    place.Position = 0;
        //    //    place.Row = 0;
        //    //}

        //    _db.Update(Session);
        //}

        public ActionResult OnPostSend()
        {
            Places places = null;
            {
                var stream = new MemoryStream();
                Request.Body.CopyTo(stream);
                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    string requestBody = reader.ReadToEnd();

                    if (requestBody.Length > 0)
                    {
                        var obj = JsonConvert.DeserializeObject<Places>(requestBody);

                        if (obj != null)
                            places = obj;

                    }
                }
            }

            return new JsonResult(places);
        }
    }
}
