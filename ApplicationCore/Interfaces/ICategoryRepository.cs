using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
         IEnumerable<int> GetCategory();
    }
}