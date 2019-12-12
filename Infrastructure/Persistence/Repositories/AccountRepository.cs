
using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(GoCafeContext context) : base(context)
        {
        }

        public IEnumerable<string> GetAccount()
        {
            var genres = from m in Context.Accounts
                         orderby m.UserRole
                         select m.UserRole;

            return genres.Distinct().ToList();
        }



        protected new GoCafeContext Context => base.Context as GoCafeContext;
    }
}