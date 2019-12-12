using ApplicationCore.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.ViewModels
{
    public class ProductIndexVm
    {
        public SelectList Genres { get; set; }
        public SelectList Genres1 { get; set; }
        public PaginatedList<ProductDto> Products { get; set; }
    }
}