using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Vet : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }

        public List<Appointment> Appointments { get; set; }  // One-to-Many relationship with Appointments
        public List<Schedule> AvailableTimes { get; set; } // Doctor's available times

    }
}
