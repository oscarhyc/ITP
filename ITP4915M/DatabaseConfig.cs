using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M
{
    public static class DatabaseConfig
    {
        public const string Database = "4915";
        public const string DatabaseServer = "itp4915.ddns.net";
        public const string DatabaseUser = "root";
        public const string DatabasePassword = "1qaz@WSX3edc";
        public const string Port = "3306";

        public static string ConnectionString =>
            $"server={DatabaseServer};" +
            $"user={DatabaseUser};" +
            $"password={DatabasePassword};" +
            $"database={Database};" +
            "charset=utf8;";

    }
}
