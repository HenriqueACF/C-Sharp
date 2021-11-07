using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Treinamento.Adapters.DAL.Settings;

namespace Treinamento.Adapters.DAL.Context
{
    public class DBConnectionFactory : IDBConnectionFactory
    {
        private DatabaseSettings dataSettings;


        public DBConnectionFactory(IConfiguration configuration)
        {
            this.dataSettings = new DatabaseSettings(configuration.GetConnectionString("DefaultConnection"));

        }

        public string GetConnectionString()
        {
            return dataSettings.DefaultConnection;
        }

        public IDbConnection Connection()
        {
            return new SqlConnection(dataSettings.DefaultConnection);
        }

    }
}
