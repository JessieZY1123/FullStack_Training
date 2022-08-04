using CustomerCRM.Core.Contracts.Repository;
using CustomerCRM.Core.Contracts.Service;
using CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRM.Infrastructure.Service
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IAccountRepository accountRepository;
        public AccountServiceAsync(IAccountRepository _accountRepository)
        {
            accountRepository = _accountRepository;
        }
    
        public Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            return accountRepository.SignUpAsync(model);
        }
    }
}
