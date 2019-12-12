using System.Collections.Generic;
using ApplicationCore.DTOs;

namespace ApplicationCore.Interfaces
{
    public interface IInfoBillService
    {
        InfoBillDto GetInfoBill(int id);
        IEnumerable<InfoBillDto> GetInfoBills(string searchString, int category, int pageIndex, int pageSize, out int count);
        List<float> GetInfoBilla(int id);
        void CreateInfoBill(SaveInfoBillDto infoBillDto);
        void UpdateInfoBill(SaveInfoBillDto infoBillDto);
        void DeleteInfoBill(int id);
    }
}