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
    public class OwnerSqlRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;
        public OwnerSqlRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Owner AddNewOWner(Owner owner)
        {
            _context.Owners.Add(owner);
            return owner;
        }
    }
}
