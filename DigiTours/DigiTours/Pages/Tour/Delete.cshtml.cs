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
    public class DeleteModel : PageModel
    {
        private readonly DigiTours.Data.TourContext _context;

        public DeleteModel(DigiTours.Data.TourContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DigiTours.Models.Tour Tour { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tour = await _context.Tours.SingleOrDefaultAsync(m => m.ID == id);

            if (Tour == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tour = await _context.Tours.FindAsync(id);

            if (Tour != null)
            {
                _context.Tours.Remove(Tour);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
