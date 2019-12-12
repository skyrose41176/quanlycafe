
using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class InfoBillRepository : Repository<InfoBill>, IInfoBillRepository
    {
        public InfoBillRepository(GoCafeContext context) : base(context)
        {
        }

        public List<float> GetInfoBill(int id)
        {
            var genres = from m in Context.InfoBills
                        where m.IdBill == id
                         select m.Bill.Total;

            return genres.Distinct().ToList();
        }



        protected new GoCafeContext Context => base.Context as GoCafeContext;
    }
}