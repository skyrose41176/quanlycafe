using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
 public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(GoCafeContext context) : base(context)
        {
        }

        public IEnumerable<int> GetCategory()
        {
            var genres = from m in Context.Categories
                         orderby m.CategoryId
                         select m.CategoryId;
            return genres.Distinct().ToList();
        }
        protected new GoCafeContext Context => base.Context as GoCafeContext;
    }
}