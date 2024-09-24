using Domain.Entities.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public DateTime AppointmentDate { get; set; }
        public string Notes { get; set; }
        public AppintmentStatus Status { get; set; }

        public Guid VetId { get; set; }
        public Vet Vet { get; set; }

        public Guid PetId { get; set; }
        public Pet Pet { get; set; }

        public ICollection<Service> Services { get; set; }

    }
}
