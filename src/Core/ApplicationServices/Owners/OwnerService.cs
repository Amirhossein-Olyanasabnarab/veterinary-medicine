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

        public async Task<OwnerDto> AddNewOwner(string firstName, string lastName, string phoneNumber)
        {
            var owner = new Owner()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                CreatedDate = DateTime.Now,
            };

            await _unitOfWork.Owners.AddOwnerAsync(owner);
            await _unitOfWork.CompleteAsync();

            return new OwnerDto
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
            };
        }
    }
}
