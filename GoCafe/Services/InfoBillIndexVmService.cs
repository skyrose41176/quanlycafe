using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.Services
{
    public class InfoBillIndexVmService : IInfoBillIndexVmService
    {
        private int pageSize = 5;
        private readonly IInfoBillService _service;

        public InfoBillIndexVmService(IInfoBillService InfoBillService)
        {
            _service = InfoBillService;
        }

        public InfoBillIndexVm GetInfoBillListVm(string searchString, int category, int pageIndex)
        {
            int count;
            var InfoBills = _service.GetInfoBills(searchString,category, pageIndex, pageSize, out count);
            var genres = _service.GetInfoBilla(category);

            return new InfoBillIndexVm
            {
                Genres = new List<float>(genres),
                InfoBills = new PaginatedList<InfoBillDto>(InfoBills, pageIndex, pageSize, count)
            };
        }
    }
}