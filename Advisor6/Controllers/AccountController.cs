using Advisor6.Data;
//using Advisor6.Data.Repository;
using Advisor6.Data.Static;
using Advisor6.Data.ViewModels;
using Advisor6.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Advisor6.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, AppDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _roleManager = roleManager;
        }

        //Get/Account/"Register"
        public IActionResult Register() => View(new RegisterVM());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser
                {
                    FullName = model.FullName,
                    UserName = model.FullName,
                    UserPassword = model.Password,
                    Email = model.EmailAddress
                };

                // Store user data in AspNetUsers database table
                var result = await _userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    //if (_signInManager.IsSignedIn(User) && User.IsInRole("SuperAdmin"))
                    //{
                    //    return RedirectToAction("ListUsers", "Manager");
                    //}
                    //else 
                    if (_signInManager.IsSignedIn(User) && (User.IsInRole("Admin") || User.IsInRole("SuperAdmin")))
                    {
                        return RedirectToAction("ListUsers", "Manager");
                    }
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }



        //////////////////////////////Post/RegisterPage هذا  الكود يعمل وبدون مشاكل
        ////////////////////////////[HttpPost]
        ////////////////////////////public async Task<IActionResult> Register(RegisterVM registerVM)
        ////////////////////////////{
        ////////////////////////////    if (!ModelState.IsValid) return View(registerVM);
        ////////////////////////////    var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
        ////////////////////////////    if (user != null)
        ////////////////////////////    {
        ////////////////////////////        TempData["Error"] = "This email address is already in use";
        ////////////////////////////        return View(registerVM);
        ////////////////////////////    }
        ////////////////////////////    var newUser = new ApplicationUser()
        ////////////////////////////    {
        ////////////////////////////        FullName = registerVM.FullName,
        ////////////////////////////        Email = registerVM.EmailAddress,
        ////////////////////////////        UserPassword = registerVM.Password,
        ////////////////////////////        UserName = registerVM.FullName
        ////////////////////////////    };
        ////////////////////////////    var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);
        ////////////////////////////    if (newUserResponse.Succeeded)
        ////////////////////////////        await _userManager.AddToRoleAsync(newUser, UserRoles.User);
        ////////////////////////////    return View("RegisterCompleted");
        ////////////////////////////}
        //////////////////////////////هذا  الكود يعمل وبدون مشاكل


        //Get/LoginPage
        public IActionResult Login() => View(new LoginVM());

        //Post/LoginPage
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);
            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Personal");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(loginVM);
            }
            TempData["Error"] = "Wrong credentials. Please, try again!";
            return View(loginVM);
        }

        //Post/LogoutPage
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }

        //Get / allUsers
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        //Get/ChangePassword
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login");
                }
                    user.UserPassword = model.NewPassword;
                     await _userManager.UpdateAsync(user);

                // ChangePasswordAsync changes the user password
                var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

                // The new password did not meet the complexity rules or
                // the current password is incorrect. Add these errors to
                // the ModelState and rerender ChangePassword view

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }
                // Upon successfully changing the password refresh sign-in cookie
                await _signInManager.RefreshSignInAsync(user);
                return View("ChangePasswordConfirmation");
            }
            return View(model);
        }
    }
}
