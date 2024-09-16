using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Pet> Pets { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Grooming> Groomings { get; set; }

    }
}
