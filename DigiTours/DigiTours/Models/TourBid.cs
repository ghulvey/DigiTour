using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiTours.Models
{
    public class TourBid
    {
        public int ID { get; set; }
        public Tour Tour { get; set; }
        public string User { get; set; }
        public double Cost { get; set; }
        public double Commission { get; set; }
        public string Notes { get; set; }
        public DateTime Delivery { get; set; }
        public DateTime Expiration { get; set; }
        public bool Selected { get; set; }
    }
}