using System;
using System.Linq.Expressions;
using ApplicationCore.Entities;

namespace ApplicationCore.Specifications
{
    public class AccountSpecification : Specification<Account>
    {
        public AccountSpecification(string searchString, string userrole)
            : base(MakeCriteria(searchString, userrole))
        {
        }

        public AccountSpecification(string searchString, string userrole, int pageIndex, int pageSize)
            : this(searchString, userrole)
        {
            ApplyPaging(pageIndex, pageSize);
        }

        private static Expression<Func<Account, bool>> MakeCriteria(string searchString, string userrole)
        {
            Expression<Func<Account, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString) && !string.IsNullOrEmpty(userrole))
            {
                predicate = m => m.UserRole == userrole && m.Fullname.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(searchString))
            {
                predicate = m => m.Fullname.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(userrole))
            {
                predicate = m => m.UserRole == userrole;
            }

            return predicate;
        }
    }
}