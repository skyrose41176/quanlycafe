using System.Collections.Generic;
using ApplicationCore.DTOs;

namespace ApplicationCore.Interfaces
{
    public interface IBillService
    {
        BillDto GetBill(int id);
        IEnumerable<BillDto> GetBills(string searchString, int userrole, int pageIndex, int pageSize, out int count);
        IEnumerable<string> GetBill();
        void CreateBill(SaveBillDto Bill);
        void UpdateBill(SaveBillDto Bill);
        void DeleteBill(int id);
    }
}