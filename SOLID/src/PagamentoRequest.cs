using SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.src
{
	public class PagamentoRequest
	{

		public double valor { get; set; }

		public TipoPagamento tipoPagamento { get; set; }

		public int parcelas;

		public PagamentoRequest(TipoPagamento tipoPagamento, double valor, int parcelas)
		{
			this.valor = valor;
			this.tipoPagamento = tipoPagamento;
			this.parcelas = parcelas;
		}

		public PagamentoRequest(TipoPagamento tipoPagamento, double valor)
		{
			this.valor = valor;
			this.tipoPagamento = tipoPagamento;
		}
	}
}
