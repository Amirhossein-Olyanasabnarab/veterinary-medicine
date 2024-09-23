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
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pets");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Species).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Breed).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Sex).IsRequired().HasMaxLength(10);
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.Species).IsRequired().HasMaxLength(50);

            builder.HasOne(p => p.Owner).WithMany(o => o.Pets)
                .HasForeignKey(p => p.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
