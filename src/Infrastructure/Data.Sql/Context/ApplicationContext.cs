using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Sql.Context
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Vet> Vets { get; set; }
    }
}
