using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Domain.Core.ValueObjetcs.Transacao
{
    public class TransacaoAbrirConta : BaseTransacao
    {
        public int Agencia { get; set; }
        public string Nome { get; set; }


        public TransacaoAbrirConta(int agencia, string Nome)
        {
            this.Agencia = agencia;
            this.Nome = Nome;
        }
    }
}
