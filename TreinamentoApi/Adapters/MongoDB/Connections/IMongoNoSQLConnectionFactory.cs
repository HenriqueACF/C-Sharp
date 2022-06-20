using MongoDB.Driver;

namespace TreinamentoApi.Adapters.MongoDB.Connections
{
    public interface IMongoNoSQLConnectionFactory
    {
        public IMongoDatabase Connection();
        public MongoClient Transaction();
    }
}
