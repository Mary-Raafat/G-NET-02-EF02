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
    internal class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.ToTable("OrganizersProfiles");
            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Website)
                .IsRequired();
            builder.Property(p => p.LogoUrl)
                .IsRequired(false);
            builder.Property(p => p.Bio)
                .IsRequired();

        }
    }
}
