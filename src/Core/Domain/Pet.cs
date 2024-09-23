using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Sex { get; set; }

        public Owner Owner { get; set; }
    }
}
