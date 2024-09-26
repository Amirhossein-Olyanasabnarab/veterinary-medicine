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

        public OwnerDto AddOwner(string name, string family, string phone)
        {
            var owner = new Owner()
            {
                FirstName = name,
                LastName = family,
                PhoneNumber = phone,
                CreatedDate = DateTime.Now,
            };
            _unitOfWork.Owners.AddOwner(owner);
            _unitOfWork.SaveChanges();
            return new OwnerDto
            {
                FirstName = owner.FirstName,
                LastName = owner.LastName,
                PhoneNumber = owner.PhoneNumber,
            };
        }
    }
}
