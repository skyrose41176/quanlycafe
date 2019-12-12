using System;
using System.Linq.Expressions;
using ApplicationCore.Entities;

namespace ApplicationCore.Specifications
{
    public class BillSpecification : Specification<Bill>
    {
        public BillSpecification(string searchString,int category)
            : base(MakeCriteria(searchString, category))
        {
        }

        public BillSpecification(string searchString, int category, int pageIndex, int pageSize)
            : this(searchString, category)
        {
            ApplyPaging(pageIndex, pageSize);
        }

        private static Expression<Func<Bill, bool>> MakeCriteria(string searchString, int? category)
        {
            Expression<Func<Bill, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString) && category != 0 )
            {
                predicate = m => m.Id == category && m.UsernameStaff.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(searchString) && category == 0)
            {
                predicate = m => m.UsernameStaff.Contains(searchString);
            }
            else if (category != 0)
            {
                predicate = m => m.Id == category;
            }

            return predicate;
        }
    }
}