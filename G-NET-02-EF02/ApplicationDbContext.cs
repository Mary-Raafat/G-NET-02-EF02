using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_NET_02_EF02.Models;
using Microsoft.EntityFrameworkCore;

namespace G_NET_02_EF02
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreNo.2;Trusted_Connection=True;TrustServerCertificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        DbSet<Organizer>Organizers { get; set; }
        DbSet<OrganizerProfile> OrganizersProfile { get; set; }
        DbSet<Event> Events {  get; set; }
        DbSet<Registration> Registrations { get; set; }
        DbSet<Attendee>Attendees { get; set; }
        DbSet<Badge>Badges { get; set; }



    }
}
