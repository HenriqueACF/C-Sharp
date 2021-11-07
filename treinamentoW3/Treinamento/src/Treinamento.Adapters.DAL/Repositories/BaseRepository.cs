using Treinamento.Adapters.DAL.Context;

namespace Treinamento.Adapters.DAL.Repositories
{
    public class BaseRepository
    {
        public readonly IDBConnectionFactory connectionDB;

        public BaseRepository(IDBConnectionFactory connection)
        {
            connectionDB = connection;
        }

    }
}
