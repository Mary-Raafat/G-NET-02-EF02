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
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {

            //Event
            builder.ToTable("Events");

            builder.HasKey(e=>e.Id);
            builder.Property(e => e.EndDate)
                .IsRequired(false);
            builder.Property(e => e.StartDate)
                .IsRequired();
            builder.Property(e => e.Title)
                .IsRequired();
            builder.Property(e => e.Description)
                .IsRequired();




            //Organizer
            builder.HasOne(e=>e.Organizer)
                .WithMany(o=>o.Events)
                .HasForeignKey(e => e.OrganizerId)
                .OnDelete(DeleteBehavior.Cascade);

            //Event Self Relation

            builder.HasOne(e => e.ParentEvent)
                .WithMany(e => e.Sessions)
                .HasForeignKey(e => e.ParentEventId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property<DateTime>("CreatedAt")
                .HasDefaultValueSql("GETDATE()");
            builder.Property<DateTime>("LastModified");




        }
    }
}
