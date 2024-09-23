using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment : BaseEntity
    {
        public Guid PetId { get; set; }
        public Pet Pet { get; set; }
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
        public Guid VetId { get; set; }
        public Vet Vet { get; set; }

        public List<Service> Services { get; set; }
        public decimal TotalCoast { get
            {
                return Services.Sum(s => s.Price);
            } 
        }
        public string Notes { get; set; }
    }
}
