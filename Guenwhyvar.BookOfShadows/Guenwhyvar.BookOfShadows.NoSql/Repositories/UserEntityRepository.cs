using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.NoSql.Entities;

namespace Guenwhyvar.BookOfShadows.NoSql.Repositories
{
    public sealed class UserEntityRepository : IUserEntityRepository
    {
        public Task AddUserEntityAsync(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserEntityAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetByUserBySelfUrlAsync(string selfUrl)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetByUserNameAndPasswordAsync(string userName, byte[] password)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserEntityAsync(string userName, UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
