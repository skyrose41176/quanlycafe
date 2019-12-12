using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IBillRepository : IRepository<Bill>
    {
         IEnumerable<string> GetBill();
    }
}