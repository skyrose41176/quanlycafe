using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using GoCafe.Interfaces;
using GoCafe.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.Services
{
    public class AccountIndexVmService : IAccountIndexVmService
    {
        private int pageSize = 5;
        private readonly IAccountService _service;

        public AccountIndexVmService(IAccountService AccountService)
        {
            _service = AccountService;
        }

        public AccountIndexVm GetAccountListVm(string searchString, string userrole, int pageIndex)
        {
            int count;
            var Accounts = _service.GetAccounts(searchString, userrole, pageIndex, pageSize, out count);
            var genres = _service.GetAccount();

            return new AccountIndexVm
            {
                Genres = new SelectList(genres),
                Accounts = new PaginatedList<AccountDto>(Accounts, pageIndex, pageSize, count)
            };
        }
    }
}