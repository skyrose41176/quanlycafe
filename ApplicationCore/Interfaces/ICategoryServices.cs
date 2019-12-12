using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ICategoryService
    {
        CategoryDto GetCategory(int id);
        CategoryDto GetCategory(string id);
        IEnumerable<CategoryDto> GetCategorys(string searchString, string userrole, int pageIndex, int pageSize, out int count);
        IEnumerable<int> GetCategory();
        void CreateCategory(SaveCategoryDto Category);
        void UpdateCategory(SaveCategoryDto Category);
        void DeleteCategory(int id);
    }
}