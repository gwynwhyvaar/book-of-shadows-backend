using Guenwhyvar.BookOfShadows.NoSql.Entities;
using Guenwhyvar.BookOfShadows.Shared.Models;

namespace Guenwhyvar.BookOfShadows.Domains.Extensions
{
    public static class UserModelExtensions
    {
        public static UserModel ToUserModel(this UserEntity userEntity)
        {
            return new UserModel()
            {
                Blogs = userEntity.Blogs,
                Comics = userEntity.Comics,
                CreatedDate = userEntity.CreatedDate,
                CreatedById = userEntity.CreatedById,
                DisplayName = userEntity.DisplayName,
                DocumentUuid = userEntity.DocumentUuid,
                EmailAddress = userEntity.EmailAddress,
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName,
                MiddleName = userEntity.MiddleName,
                ModifiedDate = userEntity.ModifiedDate,
                ProfilePictureUrl = userEntity.ProfilePictureUrl,
                ReferencedBlogImageLinks = userEntity.ReferencedBlogImageLinks,
                ReferencedBlogLinks = userEntity.ReferencedBlogLinks,
                SelfUrl = userEntity.SelfUrl,
                Status = (Shared.Enums.DocumentStatusEnum)Enum.Parse(typeof(Shared.Enums.DocumentStatusEnum), userEntity.Status.ToString()),
                UploadedFiles = userEntity.UploadedFiles,
                UserName = userEntity.UserName
            };
        }
        public static UserEntity ToUserEntity(this UserModel user)
        {
            return new UserEntity()
            {
                Blogs = user.Blogs,
                Comics = user.Comics,
                CreatedById = user.CreatedById,
                DisplayName = user.DisplayName,
                EmailAddress = user.EmailAddress,
                FirstName = user.FirstName,
                LastName = user.LastName,
                MiddleName = user.MiddleName,
                ModifiedDate = user.ModifiedDate,
                ProfilePictureUrl = user.ProfilePictureUrl,
                ReferencedBlogImageLinks = user.ReferencedBlogImageLinks,
                ReferencedBlogLinks = user.ReferencedBlogLinks,
                SelfUrl = user.SelfUrl,
                Status = (NoSql.Entities.Enums.DocumentStatusEnum)Enum.Parse(typeof(NoSql.Entities.Enums.DocumentStatusEnum), user.Status.ToString()),
                UploadedFiles = user.UploadedFiles,
                UserName = user.UserName
            };
        }
    }
}
