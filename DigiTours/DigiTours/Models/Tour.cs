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

    public enum State
    {
        AK, AL, AR, AS, AZ, CA, CO, CT, DC, DE, FL, GA, GU, HI, IA, ID, IL, IN, KS, KY, LA, MA, MD, ME, MI, MN, MO, MP, MS, MT, NC, ND, NE, NH, NJ, NM, NV, NY, OH, OK, OR, PA, PR, RI, SC, SD, TN, TX, UM, UT, VA, VI, VT, WA, WI, WV, WY
    }

    public class Tour
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public State? State { get; set; }
        public int ZipCode { get; set; }
        public string Location { get; set; }
        public string Requests { get; set; }
        public Type? Type { get; set; }

        public ICollection<TourBid> TourBids { get; set; }


    }
}
