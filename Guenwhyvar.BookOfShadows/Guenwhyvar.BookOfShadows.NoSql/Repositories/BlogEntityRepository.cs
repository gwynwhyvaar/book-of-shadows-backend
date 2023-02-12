using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.NoSql.Entities;

namespace Guenwhyvar.BookOfShadows.NoSql.Repositories
{
    public sealed class BlogEntityRepository : IBlogEntityRepository
    {
        public Task<string> AddBlogEntity(BlogEntity blogEntity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlogEntityAsync(string blogId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogEntity>> GetAllBlogEntitiesAsync(string tag)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogEntity>> GetAllBlogEntitiesAsync(string tag, string userName)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogEntity>> GetAllBlogEntitiesByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetAllTagsAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<BlogEntity> GetBlogEntityAsync(string blogId)
        {
            throw new NotImplementedException();
        }

        public Task<BlogEntity> GetBlogEntityBySelfUrlAsync(string selfUlr)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlogEntityAsync(string blogId, BlogEntity blogEntity)
        {
            throw new NotImplementedException();
        }
    }
}
