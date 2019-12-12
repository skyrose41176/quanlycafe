using System.Collections.Generic;
using ApplicationCore.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.ViewModels
{
    public class InfoBillIndexVm
    {
        public List<float> Genres { get; set; }
        public PaginatedList<InfoBillDto> InfoBills { get; set; }
        
    }
}