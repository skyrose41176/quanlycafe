using GoCafe.ViewModels;

namespace GoCafe.Interfaces
{
    public interface IInfoBillIndexVmService
    {
        InfoBillIndexVm GetInfoBillListVm(string searchString, int category, int pageIndex = 1);
    }
}