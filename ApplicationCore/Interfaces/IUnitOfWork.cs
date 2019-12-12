using System;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Account { get; }

        IProductRepository Product { get; }

        ICategoryRepository Category { get; }

        IBillRepository Bill { get; }
        IInfoBillRepository InfoBill { get; }
        int Complete();
    }
}