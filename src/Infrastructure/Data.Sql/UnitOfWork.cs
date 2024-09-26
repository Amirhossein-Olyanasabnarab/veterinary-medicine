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
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }
        public IVetRepository Vets { get ; set; }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
