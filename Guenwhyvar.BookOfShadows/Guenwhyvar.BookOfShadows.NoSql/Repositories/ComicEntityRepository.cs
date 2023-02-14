using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.NoSql.Entities;

using MongoDB.Driver;

namespace Guenwhyvar.BookOfShadows.NoSql.Repositories
{
    public sealed class ComicEntityRepository : IComicEntityRepository
    {
        private readonly IMongoCollection<ComicEntity> _db;
        public ComicEntityRepository(IDatabaseSettings databaseSettings)
        {
            var dataBase = new MongoClient(databaseSettings.ConnectionString).GetDatabase(databaseSettings.DatabaseName);
            _db = dataBase.GetCollection<ComicEntity>(typeof(ComicEntity).FullName);
        }
        public Task AddComicEntityAsync(ComicEntity ComicEntity) => _db.InsertOneAsync(ComicEntity);

        public Task DeleteComicEntityAsync(string blogId) => _db.DeleteOneAsync(x => x.DocumentUuid == new Guid(blogId));

        public Task<List<ComicEntity>> GetAllComicEntitiesAsync(string tag) => _db.Find(x => x.Tag == tag).ToListAsync();

        public Task<List<ComicEntity>> GetAllComicEntitiesAsync(string tag, string userName) => _db.Find(x => x.Tag == tag && x.BlogOwnerId == userName).ToListAsync();

        public Task<List<ComicEntity>> GetAllComicEntitiesByUserNameAsync(string userName) => _db.Find(x => x.BlogOwnerId == userName).ToListAsync();

        public Task<List<string>> GetAllTagsAsync(string userName) => Task.Run(() => _db.Find(x => x.BlogOwnerId == userName).ToList().Select(x => x.Tag).ToList());

        public Task<ComicEntity> GetComicEntityAsync(string blogId) => _db.Find(x => x.DocumentUuid == new Guid(blogId)).FirstOrDefaultAsync();

        public Task<ComicEntity> GetComicEntityBySelfUrlAsync(string selfUlr) => _db.Find(x => x.SelfUrl == selfUlr).FirstOrDefaultAsync();

        public Task UpdateComicEntityAsync(string blogId, ComicEntity ComicEntity) => _db.ReplaceOneAsync(x => x.DocumentUuid == new Guid(blogId), ComicEntity);
    }
}
