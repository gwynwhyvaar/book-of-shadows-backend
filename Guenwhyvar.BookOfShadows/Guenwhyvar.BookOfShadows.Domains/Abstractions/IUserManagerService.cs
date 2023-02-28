using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Abstractions
{
    public interface IUserManagerService
    {
        Task<UserModel> GetUserAsync(string userName);
        Task<UserModel> UpdateUserAsync(UserModel userModel);
        Task<UserModel> CreateUserAsync(UserModel userModel);
        Task<bool> DeleteUserAsync(string userName);
    }
}
