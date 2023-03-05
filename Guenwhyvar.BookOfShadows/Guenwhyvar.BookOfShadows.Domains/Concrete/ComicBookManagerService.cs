using Guenwhyvar.BookOfShadows.Domains.Abstractions;
using Guenwhyvar.BookOfShadows.Domains.Extensions;
using Guenwhyvar.BookOfShadows.NoSql.Abstract;
using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Concrete
{
    public sealed class ComicBookManagerService : IComicBookManagerService
    {
        private readonly IComicEntityRepository _repository;
        public ComicBookManagerService(IComicEntityRepository repository)
        {
            _repository = repository;
        }
        public async Task EditComicAsync(ComicModel comicModel)
        {
            var comicEntity = comicModel.ToComicEntity();
            await _repository.UpdateComicEntityAsync(comicModel.DocumentUuid.ToString(), comicEntity);
        }

        public async Task<ComicModel> GetComicAsync(string comicId)
        {
            var comicEntity = await _repository.GetComicEntityAsync(comicId);
            return comicEntity.ToComicModel();
        }

        public async Task<List<ComicModel>> GetComicsAsync(string userName)
        {
            var comics = await _repository.GetAllComicEntitiesByUserNameAsync(userName);
            return comics.Select(x => x.ToComicModel()).ToList();
        }

        public async Task SaveComicAsync(ComicModel comicModel)
        {
            var comicEntity = comicModel.ToComicEntity();
            await _repository.AddComicEntityAsync(comicEntity);
        }
    }
}
