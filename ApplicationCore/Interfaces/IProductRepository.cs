using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<int> GetProduct();
        IEnumerable<string> GetProduct1();
    }
}