using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Vets
{
    public interface IVetService 
    {
        VetDto GetVetById(Guid id);
    }
}
