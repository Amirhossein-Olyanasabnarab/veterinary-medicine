using Contracts;
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
       
        public Vet GetVetById(Guid id)
        {
            return new Vet
            {
                Id = Guid.NewGuid(),
                FirstName = "Amir",
                LastName = "Olyanasab",
                Specialty = "All kind of pets"
            };
        }
    }
}
