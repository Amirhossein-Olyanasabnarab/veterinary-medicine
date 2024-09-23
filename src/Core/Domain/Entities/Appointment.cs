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
        //Relation to Pet
        public Guid PetId { get; set; }
        public Pet Pet { get; set; }
        //Relation to Vet
        public Guid VetId { get; set; }
        public Vet Vet { get; set; }

        //Relation to Service
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        //public decimal TotalCoast
        //{
        //    get
        //    {
        //        return Services.Sum(s => s.Price);
        //    }
        //}

    }
}
