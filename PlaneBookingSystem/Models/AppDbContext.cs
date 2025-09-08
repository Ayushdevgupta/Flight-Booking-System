using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PlaneBookingSystem.Models
{
    
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Booking> Bookings { get; set; }

    }
}
