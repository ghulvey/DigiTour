using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigiTours.Data;
using DigiTours.Models;

namespace DigiTours.Pages.TourBids
{
    public class EditModel : PageModel
    {
        private readonly DigiTours.Data.TourContext _context;

        public EditModel(DigiTours.Data.TourContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TourBid TourBid { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TourBid = await _context.TourBids.SingleOrDefaultAsync(m => m.ID == id);

            if (TourBid == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TourBid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourBidExists(TourBid.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TourBidExists(int id)
        {
            return _context.TourBids.Any(e => e.ID == id);
        }
    }
}
