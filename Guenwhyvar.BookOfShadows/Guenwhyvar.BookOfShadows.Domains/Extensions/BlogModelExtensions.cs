using Guenwhyvar.BookOfShadows.NoSql.Entities;
using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Extensions
{
    public static class BlogModelExtensions
    {
        public static BlogModel ToBlogModel(this BlogEntity blogEntity)
        {
            return new BlogModel()
            {
                BannerUrl = blogEntity.BannerUrl,
                BlogOwnerId = blogEntity.BlogOwnerId,
                BlogSummary = blogEntity.BlogSummary,
                BlogText = blogEntity.BlogText,
                BlogThumbPictureUrl = blogEntity.BlogThumbPictureUrl,
                BlogTypeEnum = (Shared.Enums.BlogTypeEnum)Enum.Parse(typeof(Shared.Enums.BlogTypeEnum), blogEntity.BlogTypeEnum.ToString()),
                CreatedById = blogEntity.CreatedById,
                CreatedDate = blogEntity.CreatedDate,
                DocumentUuid = blogEntity.DocumentUuid,
                ImageLinks = blogEntity.ImageLinks,
                ModifiedDate = blogEntity.ModifiedDate,
                ReferenceLinks = blogEntity.ReferenceLinks,
                SelfUrl = blogEntity.SelfUrl,
                Status = (Shared.Enums.DocumentStatusEnum)Enum.Parse(typeof(Shared.Enums.DocumentStatusEnum), blogEntity.Status.ToString()),
                Tag = blogEntity.Tag,
                Title = blogEntity.Title
            };
        }
        public static BlogEntity ToBlogEntity(this BlogModel blogModel)
        {
            return new BlogEntity()
            {
                BannerUrl = blogModel.BannerUrl,
                BlogOwnerId = blogModel.BlogOwnerId,
                BlogSummary = blogModel.BlogSummary,
                BlogText = blogModel.BlogText,
                BlogThumbPictureUrl = blogModel.BlogThumbPictureUrl,
                BlogTypeEnum = (NoSql.Entities.Enums.BlogTypeEnum)Enum.Parse(typeof(NoSql.Entities.Enums.BlogTypeEnum), blogModel.BlogTypeEnum.ToString()),
                CreatedById = blogModel.CreatedById,
                ImageLinks = blogModel.ImageLinks,
                ModifiedDate = blogModel.ModifiedDate,
                ReferenceLinks = blogModel.ReferenceLinks,
                SelfUrl = blogModel.SelfUrl,
                Status = (NoSql.Entities.Enums.DocumentStatusEnum)Enum.Parse(typeof(NoSql.Entities.Enums.DocumentStatusEnum), blogModel.Status.ToString()),
                Tag = blogModel.Tag,
                Title = blogModel.Title
            };
        }
    }
}
