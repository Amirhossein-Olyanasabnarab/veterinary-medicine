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

        public Client ClientId { get; set; }
        public Client Client { get; set; }
        public List<Appointment> Appointments { get; set; }

        List<Grooming> groomings {  get; set; }
    }
}
