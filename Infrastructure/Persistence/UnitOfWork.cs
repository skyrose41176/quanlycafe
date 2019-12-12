using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repositories;

namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GoCafeContext _context;
        public IAccountRepository Account { get; private set; }

        public IProductRepository Product { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public IBillRepository Bill { get; private set; }
        public IInfoBillRepository InfoBill { get; private set; }


        public UnitOfWork(GoCafeContext context)
        {
            Account = new AccountRepository(context);
            Product = new ProductRepository(context);
            Category = new CategoryRepository(context);
            Bill = new BillRepository(context);
            InfoBill = new InfoBillRepository(context);
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}