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

        public OwnerDto CreateNewOwner(OwnerDto ownerDto)
        {
            var newOwner = new Owner()
            {
                Id = Guid.NewGuid(),
                FirstName = ownerDto.FirstName,
                LastName = ownerDto.LastName,
                Email = ownerDto.Email,
                PhoneNumber = ownerDto.PhoneNumber,
                CreatedDate = DateTime.Now,
            };
            _unitOfWork.Owners.AddNewOWner(newOwner);
            _unitOfWork.SaveChanges();
            return ownerDto;
        }
    }
}
