using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Abstractions
{
    public interface IBlogManagerService
    {
        Task SaveBlogPostAsync(BlogModel blogModel);
        Task EditBlogPostAsync(BlogModel blogModel);
        Task<BlogModel> GetBlogPostAsync(string blogId);
        Task<List<BlogModel>> GetBlogPostsAsync(string userName);
    }
}
