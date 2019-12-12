using GoCafe.ViewModels;

namespace GoCafe.Interfaces
{
    public interface IAccountIndexVmService
    {
        AccountIndexVm GetAccountListVm(string searchString, string userrole, int pageIndex = 1);
    }
}