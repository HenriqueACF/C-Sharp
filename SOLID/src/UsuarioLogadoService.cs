using Lime.Protocol;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ModeloPagamento.src
{
	[DataContract]
	class UsuarioLogadoService
	{
		public static string GetUsuarioLogado()
		{
			return "henrique.assis145@gmail.com";
		}
	}
}
