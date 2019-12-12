using GoCafe.ViewModels;

namespace GoCafe.Interfaces
{
    public interface IProductIndexVmService
    {
        ProductIndexVm GetProductListVm(string searchString, int category, int pageIndex = 1);
        ProductIndexVm GetProductListVm1(string searchString, string category, int pageIndex = 1);
    }
}