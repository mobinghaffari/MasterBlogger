using Microsoft.EntityFrameworkCore;

namespace _01_Framework.Infrastructure
{
    public class UnitOfWorkEf:IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWorkEf(DbContext context)
        {
            _context = context;
        }

        public void BeginTran()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTran()
        {
            _context.Database.CommitTransaction();   
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }
    }
}