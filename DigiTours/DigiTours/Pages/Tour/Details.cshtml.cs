using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DigiTours.Data;
using DigiTours.Models;

namespace DigiTours.Pages.Dashboard
{
    public class DetailsModel : PageModel
    {
        private readonly DigiTours.Data.TourContext _context;

        public DetailsModel(DigiTours.Data.TourContext context)
        {
            _context = context;
        }

        public DigiTours.Models.Tour Tour { get; set; }
        public ICollection<TourBid> TourBid { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _context.TourBids.ToList();
            Tour = await _context.Tours.SingleOrDefaultAsync(m => m.ID == id);

            if (Tour == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
