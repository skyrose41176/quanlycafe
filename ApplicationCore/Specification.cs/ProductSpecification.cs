using System;
using System.Linq.Expressions;
using ApplicationCore.Entities;

namespace ApplicationCore.Specifications
{
    public class ProductSpecification : Specification<Product>
    {
        public ProductSpecification(string searchString,int category)
            : base(MakeCriteria(searchString, category))
        {
        }
        public ProductSpecification(string searchString, int category, int pageIndex, int pageSize)
            : this(searchString, category)
        {
            ApplyPaging(pageIndex, pageSize);
        }
        private static Expression<Func<Product, bool>> MakeCriteria(string searchString, int? category)
        {
            Expression<Func<Product, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString) && category != 0)
            {
                predicate = m => m.Category.CategoryId == category && m.ProductName.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(searchString) && category == 0)
            {
                predicate = m => m.ProductName.Contains(searchString);
            }
            else if (category != 0)
            {
                predicate = m => m.Category.CategoryId == category;
            }

            return predicate;
        }
        public ProductSpecification(string searchString,string category)
        : base(MakeCriteria1(searchString,category))
        {
        }
        public ProductSpecification(string searchString, string category, int pageIndex, int pageSize)
            : this(searchString, category)
        {
            ApplyPaging(pageIndex, pageSize);
        }
        private static Expression<Func<Product, bool>> MakeCriteria1(string searchString, string category)
        {
            Expression<Func<Product, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString) && category != null)
            {
                predicate = m => m.Category.CategoryName == category && m.ProductName.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(searchString) && category == null)
            {
                predicate = m => m.ProductName.Contains(searchString);
            }
            else if (category != null)
            {
                predicate = m => m.Category.CategoryName == category;
            }

            return predicate;
        }
    }
}