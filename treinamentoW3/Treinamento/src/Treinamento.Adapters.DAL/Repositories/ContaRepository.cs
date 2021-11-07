using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Adapters.DAL.Context;
using Treinamento.Adapters.DAL.Interfaces;
using Treinamento.Domain.Core.Models;

namespace Treinamento.Adapters.DAL.Repositories
{
    public class ContaRepository : BaseRepository, IContaRepository
    {

   
        public ContaRepository(IDBConnectionFactory connection): base(connection)
        {

        }



        public async Task<Conta> AbrirConta(Conta conta)
        {
            try
            {

                using (var connDb = connectionDB.Connection())
                {
                    string sqlCommand = $"Insert into [dbo].Conta (Agencia, Numero, Nome, Saldo, Senha) values (@Agencia, @Numero, @Nome, @Saldo, @Senha)";
                    connDb.Open();
                    await connDb.ExecuteAsync(sqlCommand, conta);
                    return conta;
                }
            }
            catch(Exception ex) { throw new Exception("Erro ao abrir conta."); }
        }
    }
}
