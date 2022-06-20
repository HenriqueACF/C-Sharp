using MongoDB.Driver;

namespace TreinamentoApi.Adapters.MongoDB.Connections
{
    public sealed class DBSession
    {
        public Guid _id;
        public IMongoDatabase Connection { get; set; }
        public MongoClient Transaction { get; set; }
        public DBSession(IMongoNoSQLConnectionFactory connection)
        {
            _id = Guid.NewGuid();
            Connection = connection.Connection();
            Transaction = connection.Transaction();
        }
    }
}
