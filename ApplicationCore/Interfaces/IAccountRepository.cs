using System.Collections.Generic;
using ApplicationCore.Entities;
namespace ApplicationCore.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        IEnumerable<string> GetAccount();
    }
}