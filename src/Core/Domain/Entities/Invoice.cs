using Domain.Entities.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public InvoiceStatus Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }


    }
}
