using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace PartiSitesi.Model.HelperClass
{
    public class DBManager
    {
        private static readonly string connString  = "Host=localhost;Username=postgres;Password=12345;Database=political_party_db";
        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            return connection;
        }
    }
}
