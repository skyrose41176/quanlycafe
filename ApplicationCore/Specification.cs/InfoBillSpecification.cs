using System;
using System.Linq.Expressions;
using ApplicationCore.Entities;

namespace ApplicationCore.Specifications
{
    public class InfoBillSpecification : Specification<InfoBill>
    {
        public InfoBillSpecification(string searchString,int category)
            : base(MakeCriteria(searchString, category))
        {
        }

        public InfoBillSpecification(string searchString, int category, int pageIndex, int pageSize)
            : this(searchString, category)
        {
            ApplyPaging(pageIndex, pageSize);
        }

        private static Expression<Func<InfoBill, bool>> MakeCriteria(string searchString, int? category)
        {
            Expression<Func<InfoBill, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString) && category != 0 )
            {
                predicate = m => m.IdBill == category && m.IdBill.ToString().Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(searchString) && category == 0)
            {
                predicate = m => m.IdBill.ToString().Contains(searchString);
            }
            else if (category != 0)
            {
                predicate = m => m.IdBill == category;
            }

            return predicate;
        }
    }
}