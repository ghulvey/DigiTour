using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DigiTours.Data;
using DigiTours.Models;
using Microsoft.AspNetCore.Identity;

namespace DigiTours.Pages.Tour.Bid
{
    public class AcceptModel : PageModel
    {
        private readonly DigiTours.Data.TourContext _context;

        public AcceptModel(DigiTours.Data.TourContext context)
        {
            _context = context;
        }

        public SignInManager<ApplicationUser> SignInManager { get; set; }
        public UserManager<ApplicationUser> UserManager { get; set; }

        public DigiTours.Models.Bid Bid { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                //return NotFound();
            }

            Bid = await _context.Bid.SingleOrDefaultAsync(m => m.ID == id);

            if (Bid == null)
            {
                //return NotFound();
            }
            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //var user = await UserManager.GetUserAsync(User);
            _context.TourBids.ToList();
            DigiTours.Models.TourBid bid = await _context.TourBids.SingleOrDefaultAsync(u => u.ID == id);

            //var tour = await _context.Tours.SingleOrDefaultAsync(u => u.ID == bid.Tour.ID);
            /*if(tour.User == user.Id)
            {*/
                bid.Selected = true;
            //}
            return RedirectToPage("/Index");
        }
        
    }
}
