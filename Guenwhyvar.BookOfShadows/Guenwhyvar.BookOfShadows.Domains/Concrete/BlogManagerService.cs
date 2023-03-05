using Guenwhyvar.BookOfShadows.Domains.Abstractions;
using Guenwhyvar.BookOfShadows.Domains.Extensions;
using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Concrete
{
    public sealed class BlogManagerService : IBlogManagerService
    {
        private readonly IBlogEntityRepository _blogRepository;
        public BlogManagerService(IBlogEntityRepository blogEntityRepository)
        {
            _blogRepository = blogEntityRepository;
        }
        public async Task EditBlogPostAsync(BlogModel blogModel)
        {
            var blogEntity = blogModel.ToBlogEntity();
            await _blogRepository.UpdateBlogEntityAsync(blogModel.DocumentUuid.ToString(), blogEntity);
        }

        public async Task<BlogModel> GetBlogPostAsync(string blogId)
        {
            var blogEntity = await _blogRepository.GetBlogEntityAsync(blogId);
            return blogEntity.ToBlogModel();
        }

        public async Task<List<BlogModel>> GetBlogPostsAsync(string userName)
        {
            var blogs = await _blogRepository.GetAllBlogEntitiesByUserNameAsync(userName);
            return blogs.Select(x => x.ToBlogModel()).ToList();
        }

        public async Task SaveBlogPostAsync(BlogModel blogModel)
        {
            var blogEntity = blogModel.ToBlogEntity();
            await _blogRepository.AddBlogEntityAsync(blogEntity);
        }
    }
}
