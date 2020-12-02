using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiTours.Models
{
    public enum Type
    { 
        L, V
    }
    public class Tour
    {
        public int ID { get; set; }
        public int User { get; set; }
        public string Location { get; set; }
        public string Requests { get; set; }
        public Type? Type { get; set; }
    }
}
