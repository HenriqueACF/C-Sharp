using MongoDB.Driver;

namespace TreinamentoApi.Adapters.MongoDB.Connections
{
    public class MongoNoSQLConnectionFactory : IMongoNoSQLConnectionFactory
    {
        private readonly DBConnParametersModel _model;
        private readonly MongoClient _session;

        public MongoNoSQLConnectionFactory(DBConnParametersModel model)
        {
            _model = model;
            _session = new MongoClient(GetConnectionString());
        }

        public IMongoDatabase Connection()
        {
            return _session.GetDatabase(_model.Database);
        }

        private string GetConnectionString()
        {
            return $"mongodb://{_model.Url}/?authSource=admin";
        }

        public MongoClient Transaction()
        {
            return _session;
        }
    }
}
   
