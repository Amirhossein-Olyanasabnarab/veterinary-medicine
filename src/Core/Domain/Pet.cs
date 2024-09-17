using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Guid ClientId { get; set; }  // Foreign Key
        public Client Client { get; set; }  // Navigation Property
        public List<Appointment> Appointments { get; set; }  // One-to-Many relationship with Appointments

        public List<Grooming> groomings {  get; set; }  // One-to-Many relationship with Groomings
    }
}
