using Guenwhyvar.BookOfShadows.NoSql.Entities;

namespace Guenwhyvar.BookOfShadows.NoSql.Abstract
{
    public interface IBlogEntityRepository
    {
        Task<BlogEntity> GetBlogEntityAsync(string blogId);
        Task<BlogEntity> GetBlogEntityBySelfUrlAsync(string selfUlr);
        Task<List<BlogEntity>> GetAllBlogEntitiesAsync(string tag);
        Task<List<BlogEntity>> GetAllBlogEntitiesAsync(string tag, string userName);
        Task<string> AddBlogEntity(BlogEntity blogEntity);
        Task DeleteBlogEntityAsync(string blogId);
        Task UpdateBlogEntityAsync(string blogId, BlogEntity blogEntity);
        Task<List<BlogEntity>> GetAllBlogEntitiesByUserNameAsync(string userName);
    }
}