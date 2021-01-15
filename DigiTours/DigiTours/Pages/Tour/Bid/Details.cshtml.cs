using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DigiTours.Data;
using DigiTours.Models;

namespace DigiTours.Pages.TourBids
{
    public class DetailsModel : PageModel
    {
        private readonly DigiTours.Data.TourContext _context;

        public DetailsModel(DigiTours.Data.TourContext context)
        {
            _context = context;
        }

        public TourBid TourBid { get; set; }
        public DigiTours.Models.Tour Tour { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _context.Tours.ToList();
            TourBid = await _context.TourBids.SingleOrDefaultAsync(m => m.ID == id);
            //Tour = await _context.Tours.SingleOrDefaultAsync(m => m.ID == 1003);

            if (TourBid == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
