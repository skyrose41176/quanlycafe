using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.DTOs;

namespace Infrastructure.Persistence.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        protected DbContext Context => _context;

        public void Add(T entity)
        {
            _context.Add(entity);
        }
        public T GetBy(string username)
        {
            return _context.Set<T>().Find(username);
        }
        public T GetCa(string name)
        {
            return _context.Set<T>().Find(name);
        }
        public T GetPro(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public AccountDto GetAccount(string username)
        {
            return _context.Set<AccountDto>().Find(username);
        }
        public ProductDto GetProduct(int id)
        {
            return _context.Set<ProductDto>().Find(id);
        }
        public CategoryDto GetCategory(int id)
        {
            return _context.Set<CategoryDto>().Find(id);
        }
         public CategoryDto GetCategory(string id)
        {
            return _context.Set<CategoryDto>().Find(id);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.AddRange(entities);
        }

        public IEnumerable<T> Find(ISpecification<T> spec)
        {
            return ApplySpecification(spec).ToList();
        }

        public int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            var query = _context.Set<T>().AsQueryable();
            return SpecificationEvaluator<T>.Evaluate(query, spec);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

    }
}