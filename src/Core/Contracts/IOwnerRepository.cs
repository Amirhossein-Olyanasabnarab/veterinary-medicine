using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IOwnerRepository
    {
        string AddNewOwner(string firstName, string lastName, string phoneNumber);
    }
}
