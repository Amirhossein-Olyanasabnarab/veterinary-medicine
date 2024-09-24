using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }
        public Guid OwenerId { get; set; }
        public Owner Owner { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        public ICollection<MedicalRecord> MedicalRecords { get; set; }
    }
}
