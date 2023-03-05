using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Abstractions
{
    public interface IComicBookManagerService
    {
        Task SaveComicAsync(ComicModel comicModel);
        Task EditComicAsync(ComicModel comicModel);
        Task<ComicModel> GetComicAsync(string comicId);
        Task<List<ComicModel>> GetComicsAsync(string userName);
    }
}
