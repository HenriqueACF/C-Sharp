

using System.Data;

namespace Treinamento.Adapters.DAL.Context
{
    public interface IDBConnectionFactory
    {
        IDbConnection Connection();
    }
}
