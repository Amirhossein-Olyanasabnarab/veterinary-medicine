using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment : BaseEntity
    {
        public DateTime DateTime { get; set; }
        public decimal Fee { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int VetId { get; set; }
        public Vet Vet { get; set; }
    }
}
