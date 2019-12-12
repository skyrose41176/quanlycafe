using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
 public class BillRepository : Repository<Bill>, IBillRepository
    {
        public BillRepository(GoCafeContext context) : base(context)
        {
        }

        public IEnumerable<string> GetBill()
        {
            var genres = from m in Context.Bills
                         orderby m.UsernameStaff
                         select m.UsernameStaff;

            return genres.Distinct().ToList();
        }


        protected new GoCafeContext Context => base.Context as GoCafeContext;
    }
}