using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Pets
{
    public interface IPetService
    {
        PetDto CreatePet(PetDto pet);
    }
}
