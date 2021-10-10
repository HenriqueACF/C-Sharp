using SOLID.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.src
{
    public class EmissorComprovanteDebito : IEmissorComprovante
    {
        public Comprovante emitir(PagamentoRequest pagamentoRequest)
        {
            ComprovanteDebito comprovante = new Comprovante("Pagamento realizado", pagamentoRequest.valor.ToString(), pagamentoRequest.tipoPagamento);

            comprovante.usuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

			Database.save(comprovante);

			return comprovante;
        }
    }
}