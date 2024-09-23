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
    public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.ToTable("MedicalRecords");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Date).IsRequired();
            builder.Property(m => m.Description).HasMaxLength(500);
            builder.Property(m => m.Treatment).HasMaxLength(500);
            builder.Property(m => m.Medication).HasMaxLength(200);

            //Link to Pet
            builder.HasOne(m => m.Pet)
                .WithMany(p => p.MedicalRecords)
                .HasForeignKey(m => m.Pet.Id)
                .OnDelete(DeleteBehavior.Cascade);

            //link to Vet
            builder.HasOne(m => m.Vet)
                .WithMany(v => v.MedicalRecords)
                .HasForeignKey(m => m.VetId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
