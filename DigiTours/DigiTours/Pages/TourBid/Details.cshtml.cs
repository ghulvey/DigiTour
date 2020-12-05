﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DigiTours.Data;
using DigiTours.Models;

namespace DigiTours.Pages.TourBid
{
    public class DetailsModel : PageModel
    {
        private readonly DigiTours.Data.TourContext _context;

        public DetailsModel(DigiTours.Data.TourContext context)
        {
            _context = context;
        }

        public TourBid TourBid { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TourBid = await _context.TourBid.SingleOrDefaultAsync(m => m.ID == id);

            if (TourBid == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
