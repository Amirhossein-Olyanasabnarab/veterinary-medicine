using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Common;

namespace Domain.Entities
{
    public class MedicalRecord : BaseEntity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Treatment { get; set; }
        public string Medication { get; set; }
        public Guid PetId { get; set; }
        public Pet Pet { get; set; }
    }
}
