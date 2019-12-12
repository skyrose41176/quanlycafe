using System.Collections.Generic;
using ApplicationCore.DTOs;

namespace ApplicationCore.Interfaces
{
    public interface IAccountService
    {
        AccountDto GetAccount(string username);
        IEnumerable<AccountDto> GetAccounts(string searchString, string userrole, int pageIndex, int pageSize, out int count);
        IEnumerable<string> GetAccount();
        void CreateAccount(SaveAccountDto Account);
        void UpdateAccount(SaveAccountDto Account);
        void DeleteAccount(string username);
    }
}