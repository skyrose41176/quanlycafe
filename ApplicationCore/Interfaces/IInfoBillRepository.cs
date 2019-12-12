using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IInfoBillRepository : IRepository<InfoBill>
    {
         List<float> GetInfoBill(int id);
    }
}