using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DigiTours.Data;
using DigiTours.Models;

namespace DigiTours.Pages.Tour
{
    public class GuideModel : PageModel
    {
        private readonly DigiTours.Data.TourContext _context;

        public GuideModel(DigiTours.Data.TourContext context)
        {
            _context = context;
        }

        public IList<DigiTours.Models.Tour> Tour { get;set; }

        public async Task OnGetAsync()
        {
            Tour = await _context.Tours.ToListAsync();
        }
    }
}
