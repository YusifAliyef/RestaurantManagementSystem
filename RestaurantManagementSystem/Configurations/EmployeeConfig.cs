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
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(30)");
            builder.Property(x=>x.LastName)
                .IsRequired()
                .HasColumnType("nvarchar(30)");
            builder.Property(x => x.Salary)
            .IsRequired();
            builder.Property(x=>x.Age)
                .IsRequired();
        }
    }
}
