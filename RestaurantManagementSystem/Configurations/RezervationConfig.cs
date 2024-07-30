using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Configurations
{
    public class RezervationConfig : IEntityTypeConfiguration<Rezervation>
    {
        public void Configure(EntityTypeBuilder<Rezervation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RezervTime)
                .IsRequired();
            builder.Property(x=>x.TableNumber)
                .IsRequired();

        }
    }
}
