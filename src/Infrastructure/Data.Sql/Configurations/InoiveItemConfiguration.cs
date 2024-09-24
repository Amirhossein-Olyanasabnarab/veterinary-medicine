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
    public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.ToTable("InvoiceItems");
            builder.HasKey(a => a.Id);
            

          
            builder.HasOne(a => a.Invoice)
                .WithMany(a => a.InvoiceItems)
                .HasForeignKey(a => a.InvoiceId)
                .OnDelete(DeleteBehavior.Cascade);

     

         
        }
    }
}
