using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }  // Foreign Key
        public Role Role { get; set; } // Navigation Property
    }
}
