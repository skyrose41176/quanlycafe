using System.Collections.Generic;
using ApplicationCore.DTOs;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        //account
        T GetBy(string username);
        T GetPro(int id);
        T GetCa(string name);
        AccountDto GetAccount(string username);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(ISpecification<T> spec);
        int Count(ISpecification<T> spec);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        //product
        ProductDto GetProduct(int id);
        //category
        CategoryDto GetCategory(int id);
        CategoryDto GetCategory(string id);
        
    }
}