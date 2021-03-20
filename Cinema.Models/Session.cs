using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
    public class Session : BaseEntity
    {
        public DateTime Time { get; set; }
        public List<Place> Places { get; set; }
    }
}
