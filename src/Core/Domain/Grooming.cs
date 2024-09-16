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
        public DateTime DateTime { get; set; }
    }
}
