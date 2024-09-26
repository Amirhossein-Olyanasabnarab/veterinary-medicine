using Contracts;
using Data.Sql.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Sql
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context, IVetRepository vetRepository, IOwnerRepository owners)
        {
            _context = context;
            this.Vets = vetRepository;
            Owners = owners;    
        }
        public IVetRepository Vets { get ; set; }
        public IOwnerRepository Owners { get; set; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
