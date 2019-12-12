using ApplicationCore.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoCafe.ViewModels
{
    public class AccountIndexVm
    {
        public SelectList Genres { get; set; }
        public PaginatedList<AccountDto> Accounts { get; set; }
    }
}