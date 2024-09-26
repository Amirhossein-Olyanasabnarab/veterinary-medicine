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
        private readonly IVetRepository _vetRepository;
        public VetService(IVetRepository vetRepository)
        {
            _vetRepository = vetRepository;
        }
        public VetDto GetVetById(Guid id)
        {
            var vet = _vetRepository.GetVetById(id);
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
