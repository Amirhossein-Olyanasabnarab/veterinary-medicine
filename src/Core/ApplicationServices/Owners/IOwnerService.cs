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
        OwnerDto CreateNewOwner(OwnerDto owner);
        OwnerDto GetOwnerDtoById(Guid ownerId);
    }
}
