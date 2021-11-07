using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Domain.Core.Models;

namespace Treinamento.Adapters.DAL.Interfaces
{
    public interface IContaRepository
    {

        Task<Conta> AbrirConta(Conta conta);
    }
}
