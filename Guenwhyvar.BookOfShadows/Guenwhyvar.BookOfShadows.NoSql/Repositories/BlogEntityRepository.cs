#nullable disable 
using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.NoSql.Entities;

using MongoDB.Driver;

namespace Guenwhyvar.BookOfShadows.NoSql.Repositories
{
    public sealed class BlogEntityRepository : IBlogEntityRepository
    {
        private readonly IMongoCollection<BlogEntity> _db;
        public BlogEntityRepository(IDatabaseSettings databaseSettings)
        {
            var dataBase = new MongoClient(databaseSettings.ConnectionString).GetDatabase(databaseSettings.DatabaseName);
            _db = dataBase.GetCollection<BlogEntity>(typeof(BlogEntity).FullName);
        }
        public Task AddBlogEntity(BlogEntity blogEntity) => _db.InsertOneAsync(blogEntity);
        public Task DeleteBlogEntityAsync(string blogId) => _db.DeleteOneAsync(x => x.DocumentUuid == new Guid(blogId));
        public Task<List<BlogEntity>> GetAllBlogEntitiesAsync(string tag) => _db.Find(x => x.Tag == tag).ToListAsync();
        public Task<List<BlogEntity>> GetAllBlogEntitiesAsync(string tag, string userName) => _db.Find(x => x.Tag == tag && x.BlogOwnerId == userName).ToListAsync();
        public Task<List<BlogEntity>> GetAllBlogEntitiesByUserNameAsync(string userName) => _db.Find(x => x.BlogOwnerId == userName).ToListAsync();
        public Task<List<string>> GetAllTagsAsync(string userName) => Task.Run(() => _db.Find(x => x.BlogOwnerId == userName).ToList().Select(x => x.Tag).ToList());
        public Task<BlogEntity> GetBlogEntityAsync(string blogId) => _db.Find(x => x.DocumentUuid == new Guid(blogId)).FirstOrDefaultAsync();
        public Task<BlogEntity> GetBlogEntityBySelfUrlAsync(string selfUlr) => _db.Find(x => x.SelfUrl == selfUlr).FirstOrDefaultAsync();
        public Task UpdateBlogEntityAsync(string blogId, BlogEntity blogEntity) => _db.ReplaceOneAsync(x => x.DocumentUuid == new Guid(blogId), blogEntity);
    }
}
