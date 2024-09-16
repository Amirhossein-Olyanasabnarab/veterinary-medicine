using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
     public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
