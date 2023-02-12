#nullable disable 
using Guenwhyvar.BookOfShadows.NoSql.Entities.Enums;

namespace Guenwhyvar.BookOfShadows.NoSql.Entities
{
    public class BlogEntity : BaseEntity
    {
        public string Title { get; set; }
        public string BlogOwnerId { get; set; }
        public string BlogSummary { get; set; }
        public string BlogText { get; set; }
        public string BlogThumbPictureUrl { get; set; }
        public BlogTypeEnum BlogTypeEnum { get; set; }
        public List<string> ReferenceLinks { get; set; }
        public List<string> ImageLinks { get; set; }
        public string BannerUrl { get; set; }
        public string Tag { get; set; }
    }
}
