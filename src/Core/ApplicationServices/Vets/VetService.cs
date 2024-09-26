using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Vets
{
    public class VetService : IVetService
    {
        private readonly IUnitOfWork _unitOfWork;
        public VetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public VetDto GetVetById(Guid id)
        {
            var vet = _unitOfWork.Vets.GetVetById(id);
            if (vet == null)
                throw new Exception("There doesn't exist any vet.");
            return new VetDto
            {
                FirstName = $"First name is {vet.FirstName}",
                LastName = $"Last name is {vet.LastName}",
            };
        }
    }
}
