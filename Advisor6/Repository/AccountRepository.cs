using Advisor6.Data.ViewModels;
using Advisor6.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        


    //private readonly UserManager<IdentityResult> _userManager;
    ////private readonly SignInManager<ApplicationUser> _signInManager;
    ////private readonly RoleManager<IdentityRole> _roleManager;
    ////private readonly IUserService _userService;
    ////private readonly IEmailService _emailService;
    ////private readonly IConfiguration _configuration;

    public AccountRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;

        }
        //SignInManager<ApplicationUser> signInManager,
        //RoleManager<IdentityRole> roleManager,
        //IUserService userService,
        //IEmailService emailService,
        //IConfiguration configuration)
        //{
        //
        //_signInManager = signInManager;
        //_roleManager = roleManager;
        //_userService = userService;
        //_emailService = emailService;
        //_configuration = configuration;
        //}

        public async Task<IdentityResult> CreateUserAsync(RegisterVM registerVM)
        {

            var user = new ApplicationUser()
            {

                //FirstName = userModel.FirstName,
                ////LastName = userModel.LastName,
                //FirstName = registerVM.FirstName,
                Email = registerVM.EmailAddress

            };
            var result = await _userManager.CreateAsync(user, registerVM.Password);
            //if (result.Succeeded)
            //{
            //    await GenerateEmailConfirmationTokenAsync(user);
            //}
            return result;
        }

    }
}
