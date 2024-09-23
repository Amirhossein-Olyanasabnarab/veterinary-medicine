using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MedicalRecord : BaseEntity
    {
        public Guid PetId { get; set; }
        public Pet Pet { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Treatment { get; set; }
        public string Medication { get; set; }
        public Guid VetId { get; set; }
        public Vet Vet { get; set; }
    }
}
