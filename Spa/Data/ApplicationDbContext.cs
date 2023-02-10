using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spa.Models;
using Microsoft.EntityFrameworkCore;



namespace Spa.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Spa.Models.UserRole> UserRole { get; set; } = default!;
        public DbSet<Spa.Models.User> User { get; set; } = default!;
        public DbSet<Spa.Models.Treatment> Treatment { get; set; } = default!;
        public DbSet<Spa.Models.TreatmentTime> TreatmentTime { get; set; } = default!;
        public DbSet<Spa.Models.Schedule> Schedule { get; set; } = default!;
        public DbSet<Spa.Models.BookingStatus> BookingStatus { get; set; } = default!;
        public DbSet<Spa.Models.Booking> Booking { get; set; } = default!;


    }
}