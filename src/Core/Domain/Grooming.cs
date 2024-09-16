using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Grooming : BaseEntity
    {
        public string Services { get; set; }
        public Decimal Fee { get; set; }
        public List<DateTime> AvailableTimes { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}
