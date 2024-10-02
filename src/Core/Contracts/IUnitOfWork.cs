using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUnitOfWork
    {
        IVetRepository Vets { get; set; }
        IOwnerRepository Owners { get; set; }
        IPetRepository  Pets { get; set; }
        void SaveChanges();
    }
}
