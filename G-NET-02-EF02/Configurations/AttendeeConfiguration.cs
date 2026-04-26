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
    internal class AttendeeConfiguration : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {

            builder.ToTable("Attendees");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.FullName)
                .IsRequired();
            builder.Property(a => a.EmailAddress)
                .IsRequired();

            //OwnedEntity
            builder.OwnsOne(a => a.Address, address =>
            {
                address.Property(address => address.Street).IsRequired();
                address.Property(address => address.City).IsRequired();
                address.Property(address => address.PostalCode).IsRequired();
                address.Property(address => address.Country).IsRequired();
            });
           
            

        }
    }
}
