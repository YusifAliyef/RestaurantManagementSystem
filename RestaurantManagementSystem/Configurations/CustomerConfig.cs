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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(30)");
            builder.Property(x=>x.LastName)
                .IsRequired()
                .HasColumnType("nvarchar(30)");
            builder.HasOne(x => x.Rezervation)
                .WithOne(x => x.Customer)
                .HasForeignKey<Customer>(x => x.RezervationId);
           
                
        }
    }
}
