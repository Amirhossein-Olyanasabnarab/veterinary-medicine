using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<Pet> Pets { get; set; }  // One-to-Many relationship with Pets
        public List<Appointment> Appointments { get; set; }  // One-to-Many relationship with Appointments
        public List<Grooming> Groomings { get; set; }  // One-to-Many relationship with Groomings

    }
}
