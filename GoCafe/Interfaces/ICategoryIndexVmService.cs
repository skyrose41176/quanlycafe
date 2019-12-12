using GoCafe.ViewModels;

namespace GoCafe.Interfaces
{
    public interface ICategoryIndexVmService
    {
        CategoryIndexVm GetCategoryListVm(string searchString, string userrole, int pageIndex = 1);
    }
}