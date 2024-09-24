using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InvoiceItem : BaseEntity
    {
        public Guid InvoiceId { get; set; }
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public Invoice Invoice { get; set; }
    }
}
