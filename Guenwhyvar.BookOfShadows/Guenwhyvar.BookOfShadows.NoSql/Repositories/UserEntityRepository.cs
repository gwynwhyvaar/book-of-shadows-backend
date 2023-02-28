using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.NoSql.Entities;

using MongoDB.Driver;

namespace Guenwhyvar.BookOfShadows.NoSql.Repositories
{
    public sealed class UserEntityRepository : IUserEntityRepository
    {
        private readonly IMongoCollection<UserEntity> _db;
        public UserEntityRepository(IDatabaseSettings databaseSettings)
        {
            var dataBase = new MongoClient(databaseSettings.ConnectionString).GetDatabase(databaseSettings.DatabaseName);
            _db = dataBase.GetCollection<UserEntity>(typeof(UserEntity).FullName);
        }
        public Task AddUserEntityAsync(UserEntity entity) => _db.InsertOneAsync(entity);

        public Task DeleteUserEntityAsync(string userName) => _db.DeleteOneAsync(x => x.UserName == userName);

        public Task<UserEntity> GetByUserBySelfUrlAsync(string selfUrl) => _db.Find(x => x.SelfUrl == selfUrl).FirstOrDefaultAsync();

        public Task<UserEntity> GetByUserNameAsync(string userName) => _db.Find(x => x.UserName == userName).FirstOrDefaultAsync();

        public Task UpdateUserEntityAsync(string userName, UserEntity entity) => _db.ReplaceOneAsync(x => x.UserName == userName, entity);
    }
}
