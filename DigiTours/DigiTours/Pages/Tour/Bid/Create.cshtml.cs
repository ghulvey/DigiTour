using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DigiTours.Data;
using DigiTours.Models;
using Microsoft.EntityFrameworkCore;

namespace DigiTours.Pages.TourBids
{
    public class CreateModel : PageModel
    {
        private readonly DigiTours.Data.TourContext _context;

        public CreateModel(DigiTours.Data.TourContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TourBid TourBid { get; set; }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            DigiTours.Models.Tour tour = await _context.Tours.SingleOrDefaultAsync(u => u.ID == id);
            Console.WriteLine(tour);
            TourBid.Tour = tour;

            _context.TourBids.Add(TourBid);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}