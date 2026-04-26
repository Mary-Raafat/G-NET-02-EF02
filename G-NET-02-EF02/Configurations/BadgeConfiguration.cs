using G_NET_02_EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_02_EF02.Configurations
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badges");
            builder.Property(b => b.BadgeNumber)
                .IsRequired();
            builder.Property(b=>b.IssuedDate)
                .IsRequired();
            builder.Property(b=>b.Tier)
                .IsRequired() ;

            builder.HasOne(b => b.Attendee)
                .WithOne(a => a.Badge)
                .HasForeignKey<Badge>(b => b.AttendeeId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
