using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _01_Framework.Domain;
using Microsoft.EntityFrameworkCore;

namespace _01_Framework.Infrastructure
{
    public class BaseRepository<TKey, T>: IRepository<TKey, T>where T:DomainBase<TKey>
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add<T>(entity);
        }

        public T Get(TKey id)
        {
            return _context.Find<T>(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public bool Exist(Expression<Func<T,bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }
    }
}
