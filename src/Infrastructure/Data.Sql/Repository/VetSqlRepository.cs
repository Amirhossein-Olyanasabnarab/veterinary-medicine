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
    public class VetSqlRepository : IVetRepository
    {
        private readonly ApplicationContext _contex;
        public VetSqlRepository(ApplicationContext context)
        {
            _contex = context;
        }
        public Vet GetVetById(Guid id)
        {
            return _contex.Vets.FirstOrDefault(x => x.Id == id);
        }
    }
}
