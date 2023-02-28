using Guenwhyvar.BookOfShadows.NoSql.Entities;
using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Extensions
{
    public static class ComicModelExtensions
    {
        public static ComicModel ToComicModel(this ComicEntity comicEntity)
        {
            return new ComicModel()
            {
                BannerUrl = comicEntity.BannerUrl,
                BlogOwnerId = comicEntity.BlogOwnerId,
                BlogSummary = comicEntity.BlogSummary,
                BlogText = comicEntity.BlogText,
                BlogThumbPictureUrl = comicEntity.BlogThumbPictureUrl,
                BlogTypeEnum = (Shared.Enums.BlogTypeEnum)Enum.Parse(typeof(Shared.Enums.BlogTypeEnum), comicEntity.BlogTypeEnum.ToString()),
                CreatedById = comicEntity.CreatedById,
                CreatedDate = comicEntity.CreatedDate,
                DocumentUuid = comicEntity.DocumentUuid,
                ImageLinks = comicEntity.ImageLinks,
                ModifiedDate = comicEntity.ModifiedDate,
                ReferenceLinks = comicEntity.ReferenceLinks,
                SelfUrl = comicEntity.SelfUrl,
                Status = (Shared.Enums.DocumentStatusEnum)Enum.Parse(typeof(Shared.Enums.DocumentStatusEnum), comicEntity.Status.ToString()),
                Tag = comicEntity.Tag,
                Title = comicEntity.Title
            };
        }
        public static ComicEntity ToComicEntity(this ComicModel comicModel)
        {
            return new ComicEntity()
            {
                BannerUrl = comicModel.BannerUrl,
                BlogOwnerId = comicModel.BlogOwnerId,
                BlogSummary = comicModel.BlogSummary,
                BlogText = comicModel.BlogText,
                BlogThumbPictureUrl = comicModel.BlogThumbPictureUrl,
                BlogTypeEnum = (NoSql.Entities.Enums.BlogTypeEnum)Enum.Parse(typeof(NoSql.Entities.Enums.BlogTypeEnum), comicModel.BlogTypeEnum.ToString()),
                CreatedById = comicModel.CreatedById,
                ImageLinks = comicModel.ImageLinks,
                ModifiedDate = comicModel.ModifiedDate,
                ReferenceLinks = comicModel.ReferenceLinks,
                SelfUrl = comicModel.SelfUrl,
                Status = (NoSql.Entities.Enums.DocumentStatusEnum)Enum.Parse(typeof(NoSql.Entities.Enums.DocumentStatusEnum), comicModel.Status.ToString()),
                Tag = comicModel.Tag,
                Title = comicModel.Title
            };
        }
    }
}
