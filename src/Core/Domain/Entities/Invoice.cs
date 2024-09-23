using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
