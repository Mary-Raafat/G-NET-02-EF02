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
    internal class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.ToTable("Organizers");

            builder.HasKey(o=>o.Id);

            builder.Property(o => o.Name)
                .IsRequired();

            builder.Property(o => o.CompanyName)
                .IsRequired(false);

            builder.Property(o=>o.IsVerfied)
                .IsRequired();

            //OrganizerProfile
            builder.HasOne(o => o.Profile)
                .WithOne(p => p.Organizer)
                .HasForeignKey<OrganizerProfile>(p => p.Id);


         

        }
    }
}
