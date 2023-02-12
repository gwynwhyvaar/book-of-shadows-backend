#nullable disable 
using Guenwhyvar.BookOfShadows.NoSql.Entities.Enums;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Guenwhyvar.BookOfShadows.NoSql.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            DocumentUuid = Guid.NewGuid();
            CreatedDate = DateTimeOffset.UtcNow.DateTime;
            Status = DocumentStatusEnum.Active;
        }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime ModifiedDate { get; set; }
        public string SelfUrl { get; set; }
        public string CreatedById { get; set; }
        public Guid DocumentUuid { get; private set; }
        public DocumentStatusEnum Status { get; set; }
    }
}
