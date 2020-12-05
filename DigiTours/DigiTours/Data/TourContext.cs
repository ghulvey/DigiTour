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

        public DbSet<DigiTours.Models.Tour> Tour { get; set; }
        public DbSet<DigiTours.Models.TourBid> TourBid { get; set; }

    }
}
