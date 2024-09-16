using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Vet : BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Specialty { get; set; }

    }
}
