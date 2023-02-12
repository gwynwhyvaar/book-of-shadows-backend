#nullable disable
using Guenwhyvar.BookOfShadows.NoSql.Abstract;
namespace Guenwhyvar.BookOfShadows.NoSql.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
