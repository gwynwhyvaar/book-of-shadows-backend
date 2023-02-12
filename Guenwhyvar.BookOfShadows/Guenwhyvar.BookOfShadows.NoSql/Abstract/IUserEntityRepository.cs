using Guenwhyvar.BookOfShadows.NoSql.Entities;

namespace Guenwhyvar.BookOfShadows.NoSql.Abstract
{
    public interface IUserEntityRepository
    {
        Task<UserEntity> GetByUserNameAsync(string userName);
        Task<UserEntity> GetByUserBySelfUrlAsync(string selfUrl);
        Task<UserEntity> GetByUserNameAndPasswordAsync(string userName, byte[] password);
        Task AddUserEntityAsync(UserEntity entity);
        Task DeleteUserEntityAsync(string userName);
        Task UpdateUserEntityAsync(string userName, UserEntity entity);
    }
}
