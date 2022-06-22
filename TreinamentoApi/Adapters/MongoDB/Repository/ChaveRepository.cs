using MongoDB.Driver;
using TreinamentoApi.Adapters.MongoDB.Connections;
using TreinamentoApi.Domain.SharedKernel.Entities;
using TreinamentoApi.Domain.SharedKernel.Interfaces;

namespace TreinamentoApi.Adapters.MongoDB.Repository
{
    public class ChaveRepository: IChaveRepository
    {
        public DBSession _dbSession;

        public ChaveRepository(DBSession dbSession)
        {
            _dbSession = dbSession;
        }

        public async Task<Chave> CadastrarChave(Chave chave)
        {
            IMongoCollection<Chave> colNews = _dbSession.Connection.GetCollection<Chave>("Chaves");
            var filter = Builders<Chave>.Filter.Where(x => x.indice == chave.indice);
            var update = Builders<Chave>.Update.Set("Chave", chave);
            var retChave = await colNews.FindOneAndUpdateAsync(filter, update);
            return retChave;
        }

        public async Task<Chave> ConsultarChave(int indice)
        {
            var ret = _dbSession.Connection.GetCollection<Chave>("CHAVES")
                .Find( e => e.indice == indice)
                .FirstOrDefaultAsync()
                .Result;

            if (ret is null)
                throw new Exception("Chave não encontrada.");

            return ret;
        }    
    }
}
