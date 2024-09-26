using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Owners
{
    public interface IOwnerService 
    {
        OwnerDto AddOwner(String name, string family, string phone);
    }
}
