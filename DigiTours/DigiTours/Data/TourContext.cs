using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DigiTours.Models;

namespace DigiTours.Data
{
    public class TourContext : DbContext
    {

        public TourContext (DbContextOptions<TourContext> options)
            : base(options)
        {
        }

        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourBid> TourBids { get; set; }

    }
}
