using ApplicationCore.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.ViewModels
{
    public class BillIndexVm
    {
        public SelectList Genres { get; set; }
        public PaginatedList<BillDto> Bills { get; set; }
    }
}