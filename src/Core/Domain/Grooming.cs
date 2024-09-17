using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Grooming : BaseEntity
    {
        public string Service { get; set; }
        public Decimal Fee { get; set; }
        public List<Schedule> AvailableTimes { get; set; }  // Available time slots for grooming services
        public int PetId { get; set; }  // Foreign Key
        public Pet Pet { get; set; }  // Navigation Property
    }
}
