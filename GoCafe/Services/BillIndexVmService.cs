using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.Services
{
    public class BillIndexVmService : IBillIndexVmService
    {
        private int pageSize = 5;
        private readonly IBillService _service;

        public BillIndexVmService(IBillService BillService)
        {
            _service = BillService;
        }

        public BillIndexVm GetBillListVm(string searchString, int userrole, int pageIndex)
        {
            int count;
            var Bills = _service.GetBills(searchString, userrole, pageIndex, pageSize, out count);
            var genres = _service.GetBill();

            return new BillIndexVm
            {
                Genres = new SelectList(genres),
                Bills = new PaginatedList<BillDto>(Bills, pageIndex, pageSize, count)
            };
        }
    }
}