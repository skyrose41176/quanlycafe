using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using AutoMapper;

namespace ApplicationCore.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<string> GetAccount()
        {
            return _unitOfWork.Account.GetAccount();
        }
        public void CreateAccount(SaveAccountDto saveAccountDto)
        {
            var account = _mapper.Map<SaveAccountDto,Account>(saveAccountDto);
            _unitOfWork.Account.Add(account);
            _unitOfWork.Complete();
        }
        public void DeleteAccount(string Username)
        {
            var account = _unitOfWork.Account.GetBy(Username);
            if (account != null)
            {
                _unitOfWork.Account.Remove(account);
                _unitOfWork.Complete();
            }
        }
        public AccountDto GetAccount(string Username)
        {
            var account = _unitOfWork.Account.GetBy(Username);
            return _mapper.Map<Account, AccountDto>(account);
        }
        public IEnumerable<AccountDto> GetAccounts(string searchString, string userrole, int pageIndex, int pageSize, out int count)
        {
            
            AccountSpecification accountFilterPaginated = new AccountSpecification(searchString, userrole, pageIndex, pageSize);
            AccountSpecification accountFilter = new AccountSpecification(searchString, userrole);

            var account = _unitOfWork.Account.Find(accountFilterPaginated);
            count = _unitOfWork.Account.Count(accountFilter);

            return _mapper.Map<IEnumerable<Account>, IEnumerable<AccountDto>>(account);

        }

        public void UpdateAccount(SaveAccountDto saveAccountDto)
        {
            var account = _unitOfWork.Account.GetBy(saveAccountDto.Username);
            if (account == null) return;
            _mapper.Map<SaveAccountDto,Account>(saveAccountDto,account);
            _unitOfWork.Complete();
        }
    }
}