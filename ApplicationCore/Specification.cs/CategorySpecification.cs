using System;
using System.Linq.Expressions;
using ApplicationCore.Entities;

namespace ApplicationCore.Specifications
{
    public class CategorySpecification : Specification<Category>
    {
        public CategorySpecification(string searchString, string userrole)
            : base(MakeCriteria(searchString, userrole))
        {
        }

        public CategorySpecification(string searchString, string userrole, int pageIndex, int pageSize)
            : this(searchString, userrole)
        {
            ApplyPaging(pageIndex, pageSize);
        }

        private static Expression<Func<Category, bool>> MakeCriteria(string searchString, string userrole)
        {
            Expression<Func<Category, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString) && !string.IsNullOrEmpty(userrole))
            {
                predicate = m => m.CategoryName == userrole && m.CategoryName.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(searchString))
            {
                predicate = m => m.CategoryName.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(userrole))
            {
                predicate = m => m.CategoryName == userrole;
            }

            return predicate;
        }
    }
}