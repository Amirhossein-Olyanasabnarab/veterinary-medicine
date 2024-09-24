using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Sql.Configurations
{
    public class VetConfiguration : IEntityTypeConfiguration<Vet>
    {
        public void Configure(EntityTypeBuilder<Vet> builder)
        {
            builder.ToTable("Vets");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(v => v.LastName).IsRequired().HasMaxLength(50);
            builder.Property(v => v.Email).HasMaxLength(100);
            builder.Property(v => v.Specialty).HasMaxLength(100);


       
        }
    }
}
