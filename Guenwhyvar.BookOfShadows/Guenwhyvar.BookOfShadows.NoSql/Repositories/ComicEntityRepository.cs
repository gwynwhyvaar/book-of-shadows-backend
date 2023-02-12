using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.NoSql.Entities;

namespace Guenwhyvar.BookOfShadows.NoSql.Repositories
{
    public sealed class ComicEntityRepository : IComicEntityRepository
    {
        public Task<string> AddComicEntity(ComicEntity ComicEntity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteComicEntityAsync(string blogId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ComicEntity>> GetAllComicEntitiesAsync(string tag)
        {
            throw new NotImplementedException();
        }

        public Task<List<ComicEntity>> GetAllComicEntitiesAsync(string tag, string userName)
        {
            throw new NotImplementedException();
        }

        public Task<List<ComicEntity>> GetAllComicEntitiesByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetAllTagsAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<ComicEntity> GetComicEntityAsync(string blogId)
        {
            throw new NotImplementedException();
        }

        public Task<ComicEntity> GetComicEntityBySelfUrlAsync(string selfUlr)
        {
            throw new NotImplementedException();
        }

        public Task UpdateComicEntityAsync(string blogId, ComicEntity ComicEntity)
        {
            throw new NotImplementedException();
        }
    }
}
