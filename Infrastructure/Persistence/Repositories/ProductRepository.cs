
using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(GoCafeContext context) : base(context)
        {
        }

        public IEnumerable<int> GetProduct()
        {
            var genres = from m in Context.Products
                         orderby m.Category.CategoryId
                         select m.Category.CategoryId;

            return genres.Distinct().ToList();
        }
        public IEnumerable<string> GetProduct1()
        {
            var genres = from m in Context.Products
                         orderby m.Category.CategoryName
                         select m.Category.CategoryName;

            return genres.Distinct().ToList();
        }



        protected new GoCafeContext Context => base.Context as GoCafeContext;
    }
}