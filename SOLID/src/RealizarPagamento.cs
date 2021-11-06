using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.src
{
	public class RealizarPagamento
	{

		private IEmissorComprovante _emissorComprovante;

		public RealizarPagamento(IEmissorComprovante emissorComprovante)
		{
			this._emissorComprovante = emissorComprovante;
		}
	
		public Comprovante RegistrarPagamento(PagamentoRequest pagamento)
		{
			Comprovante comprovante = _emissorComprovante.emitir(pagamento);

			return comprovante;

		}
	
	}
}
