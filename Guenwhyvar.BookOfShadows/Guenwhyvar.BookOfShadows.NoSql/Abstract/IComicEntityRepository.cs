using Guenwhyvar.BookOfShadows.NoSql.Entities;

namespace Guenwhyvar.BookOfShadows.NoSql.Abstract
{
    public interface IComicEntityRepository
    {
        Task<ComicEntity> GetComicEntityAsync(string blogId);
        Task<ComicEntity> GetComicEntityBySelfUrlAsync(string selfUlr);
        Task<List<ComicEntity>> GetAllComicEntitiesAsync(string tag);
        Task<List<ComicEntity>> GetAllComicEntitiesAsync(string tag, string userName);
        Task AddComicEntityAsync(ComicEntity ComicEntity);
        Task DeleteComicEntityAsync(string blogId);
        Task UpdateComicEntityAsync(string blogId, ComicEntity ComicEntity);
        Task<List<ComicEntity>> GetAllComicEntitiesByUserNameAsync(string userName);
        Task<List<string>> GetAllTagsAsync(string userName);
    }
}
