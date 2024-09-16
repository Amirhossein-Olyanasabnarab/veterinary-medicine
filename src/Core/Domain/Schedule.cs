using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Schedule : BaseEntity
    {
        public string ServiceType { get; set; } // "Appointment" or "Grooming"
        public DateTime Date { get; set; }
    }
}
