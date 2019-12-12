using ApplicationCore.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.ViewModels
{
    public class CategoryIndexVm
    {
        public SelectList Genres { get; set; }
        public PaginatedList<CategoryDto> Categorys { get; set; }
    }
}