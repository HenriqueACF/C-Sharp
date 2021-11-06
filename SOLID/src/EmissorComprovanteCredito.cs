using SOLID.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.src
{
    public class EmissorComprovanteCredito : IEmissorComprovante
    {
        public Comprovante emitir(PagamentoRequest pagamentoRequest)
        {
            ComprovanteCredito comprovante = new ComprovanteCredito(pagamentoRequest.parcela, "Pagamento realizado", pagamentoRequest.valor.ToString(), pagamentoRequest.tipoPagamento);

            comprovante.usuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

            ChecarLimite();

			Database.save(comprovante);

			return comprovante;
        }

        public string ChecarLimite()
        {
            return "Não pode comprar";
        }
    }
}