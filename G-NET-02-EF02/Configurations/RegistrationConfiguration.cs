using G_NET_02_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_02_EF02.Configurations
{
    internal class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.ToTable("Registrations");
            builder.HasKey(r => new
            {
                r.AttendeeId,
                r.EventId
            });

            builder.Property(r=>r.Note).
                IsRequired();

            builder.Property(r=>r.RegisteredAt).IsRequired();
            builder.HasOne(r => r.Attendee)
                .WithMany(a => a.Registrations)
                .HasForeignKey(r => r.AttendeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r=>r.Event)
                .WithMany(e=>e.Registrations)
                .HasForeignKey(r => r.EventId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(r => r.RegisteredAt)
          .HasDefaultValueSql("GETDATE()");


        }
    }
}
