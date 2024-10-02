using Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Pets
{
    public class PetService : IPetService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public PetDto CreatePet(PetDto pet)
        {
            var newPet = new Pet()
            {
                Id = Guid.NewGuid(),
                Name = pet.Name,
                Breed = pet.Breed,
                Species = pet.Species,
                Age = pet.Age,
                Gender = pet.Gender,
                Weight = pet.Weight,
            };
            _unitOfWork.Pets.CreatePet(newPet);
            _unitOfWork.SaveChanges();
            return pet;
        }
    }
}
