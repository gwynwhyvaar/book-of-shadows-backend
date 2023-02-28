#nullable disable 
using Guenwhyvar.BookOfShadows.Shared.Enums;

using MessagePack;

namespace Guenwhyvar.BookOfShadows.Shared.Models
{
    [MessagePackObject(keyAsPropertyName: true)]
    public class BaseModel
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string SelfUrl { get; set; }
        public string CreatedById { get; set; }
        public Guid DocumentUuid { get; set; }
        public DocumentStatusEnum Status { get; set; }
    }
}
