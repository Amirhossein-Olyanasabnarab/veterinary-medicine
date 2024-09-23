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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("Appointments");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.AppointmentDate).IsRequired();
            builder.Property(a => a.Notes).HasMaxLength(500);

            //Relate to Pet
            builder.HasOne(a => a.Pet)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PetId)
                .OnDelete(DeleteBehavior.Cascade);

            //Relate to Vet
            builder.HasOne(a => a.Vet)
                .WithMany(v => v.Appointments)
                .HasForeignKey(a => a.VetId)
                .OnDelete(DeleteBehavior.Restrict);

            //Relate to Service
            builder.HasOne(a => a.Service).WithMany(s => s.Appointments)
                .HasForeignKey(a =>a.ServiceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
