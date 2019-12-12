using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.Services
{
    public class CategoryIndexVmService : ICategoryIndexVmService
    {
        private int pageSize = 5;
        private readonly ICategoryService _service;

        public CategoryIndexVmService(ICategoryService CategoryService)
        {
            _service = CategoryService;
        }

        public CategoryIndexVm GetCategoryListVm(string searchString,string userrole, int pageIndex)
        {
            int count;
            var Categorys = _service.GetCategorys(searchString, userrole, pageIndex, pageSize, out count);
            var genres = _service.GetCategory();
            return new CategoryIndexVm
            {
                Genres = new SelectList(genres),
                Categorys = new PaginatedList<CategoryDto>(Categorys, pageIndex, pageSize, count)
            };
        }
    }
}