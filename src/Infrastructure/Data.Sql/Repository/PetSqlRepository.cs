using Contracts;
using Data.Sql.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Sql.Repository
{
    public class PetSqlRepository : IPetRepository
    {
        private readonly ApplicationContext _context;
        public PetSqlRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Pet CreatePet(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
            return pet;
        }
    }
}
