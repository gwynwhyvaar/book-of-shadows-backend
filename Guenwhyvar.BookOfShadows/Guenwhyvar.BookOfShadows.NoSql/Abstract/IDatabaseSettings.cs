﻿namespace Guenwhyvar.BookOfShadows.NoSql.Abstract
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
