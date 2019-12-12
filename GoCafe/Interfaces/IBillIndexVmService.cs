using GoCafe.ViewModels;

namespace GoCafe.Interfaces
{
    public interface IBillIndexVmService
    {
        BillIndexVm GetBillListVm(string searchString, int userrole, int pageIndex = 1);
    }
}