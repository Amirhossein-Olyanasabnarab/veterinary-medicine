using Contracts;
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
        public OwnerDto AddNewOwner(string firstName, string lastName, string phoneNumber)
        {
            _unitOfWork.Owners.AddNewOwner(firstName, lastName, phoneNumber);
            return new OwnerDto()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber
            };
        }
    }
}
