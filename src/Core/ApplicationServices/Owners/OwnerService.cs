using Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Owners
{
    public class OwnerService : IOwnerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OwnerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Owner> CreateOwnerAsync(Owner owner)
        {
            return await _unitOfWork.Owners.AddOwnerAsync(owner);
        }
    }
}
