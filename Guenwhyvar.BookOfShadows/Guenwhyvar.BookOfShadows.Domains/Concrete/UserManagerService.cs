using Guenwhyvar.BookOfShadows.Domains.Abstractions;
using Guenwhyvar.BookOfShadows.Domains.Extensions;
using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Concrete
{
    public sealed class UserManagerService : IUserManagerService
    {
        private readonly IUserEntityRepository _userEntityRepository;
        public UserManagerService(IUserEntityRepository userEntityRepository)
        {
            _userEntityRepository = userEntityRepository;
        }
        public async Task<UserModel> CreateUserAsync(UserModel userModel)
        {
            var entity = userModel.ToUserEntity();
            await _userEntityRepository.AddUserEntityAsync(entity);
            entity = await _userEntityRepository.GetByUserNameAsync(entity.UserName);
            return entity.ToUserModel();
        }

        public async Task<bool> DeleteUserAsync(string userName)
        {
            await _userEntityRepository.DeleteUserEntityAsync(userName);
            return (true);
        }

        public async Task<UserModel> GetUserAsync(string userName)
        {
            var entity = await _userEntityRepository.GetByUserNameAsync(userName);
            return entity.ToUserModel();
        }

        public async Task<UserModel> UpdateUserAsync(UserModel userModel)
        {
            var entity = userModel.ToUserEntity();
            await _userEntityRepository.UpdateUserEntityAsync(userModel.UserName, entity);
            entity = await _userEntityRepository.GetByUserNameAsync(userModel.UserName);
            return entity.ToUserModel();
        }
    }
}