﻿using CustomerCRM.Core.Contracts.Repository;
using CustomerCRM.Core.Entities;
using CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRM.Infrastructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        public AccountRepository(UserManager<ApplicationUser> m)
        {
            userManager = m;   
        }
        public  Task<IdentityResult> SignUpAsync(SignUpModel user)
        {
            ApplicationUser appuser = new ApplicationUser();
            appuser.FirstName = user.FirstName;
            appuser.LastName = user.LastName;
            appuser.Email = user.Email;
            appuser.UserName = user.Email;

            return  userManager.CreateAsync(appuser,user.Password);
        }
    }
}
