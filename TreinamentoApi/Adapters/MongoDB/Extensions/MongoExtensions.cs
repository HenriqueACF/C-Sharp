using TreinamentoApi.Adapters.MongoDB.Connections;

namespace TreinamentoApi.Adapters.MongoDB.Extensions
{
    public static class MongoExtensions
    {

        public static IServiceCollection AddMongoAdapter(this IServiceCollection services)
        {

            IConfiguration configuration = new ConfigurationBuilder()
                         .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
                         .Build();

            //Repositories
            //services.AddSingleton<IDBPIXCoreRepository, DBPIXCoreRepository>();

            services.AddSingleton<DBSession>();
            services.AddSingleton<IMongoNoSQLConnectionFactory, MongoNoSQLConnectionFactory>(
                factory => new MongoNoSQLConnectionFactory(
                    new DBConnParametersModel
                    {
                        Url = configuration.GetSection("MongoDBConnections")["Url"],
                        Database = configuration.GetSection("MongoDBConnections")["Database"],
                        Username = configuration.GetSection("MongoDBConnections")["Username"],
                        Password = configuration.GetSection("MongoDBConnections")["Password"]
                    }));

            return services;
        }
    }
}
