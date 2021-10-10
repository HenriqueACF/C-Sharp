using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.src
{
    class ComprovanteCredito : Comprovante
    {
        public int parcelas { get; set; }

        public ComprovanteCredito(int parcelas, string descricao,  string valor, TipoPagamento tipoPagamento ) 
            : base(descricao, valor, tipoPagamento)
            {
                this.parcelas = parcelas;
            }
    }
}