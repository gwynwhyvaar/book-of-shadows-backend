#nullable disable 
using MessagePack;

namespace Guenwhyvar.BookOfShadows.Shared.Models
{
    [MessagePackObject(keyAsPropertyName: true)]
    public class UserModel : BaseModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Password { get; set; }
        public string ProfilePictureUrl { get; set; }
        public int Blogs { get; set; }
        public int Comics { get; set; }
        public List<string> ReferencedBlogLinks { get; set; }
        public List<string> ReferencedBlogImageLinks { get; set; }
        public List<string> UploadedFiles { get; set; }
    }
}
