using Advisor6.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);
        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);
        Task<IdentityResult> CreateUserAsync(RegisterVM registerVM);
        Task GenerateEmailConfirmationTokenAsync(ApplicationUser user);
        Task GenerateForgotPasswordTokenAsync(ApplicationUser user);
        Task<ApplicationUser> GetUserByEmailAsync(string email);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model);
        Task SignOutAsync();
    }
}