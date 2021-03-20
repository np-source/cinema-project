using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public class Session : BaseEntity
    {
        public DateTime Time { get; set; }
        public Film Film { get; set; }
        public List<Place> Places { get; set; }
    }
}
