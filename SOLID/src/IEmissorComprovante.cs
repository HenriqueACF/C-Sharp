using SOLID.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.src
{
    public interface IEmissorComprovante
    {
         public Comprovante emitir(PagamentoRequest pagamentoRequest);
    }
}