using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Domain.Core.Models.VM
{
    public struct ContaVM
    {
        public int Agencia { get; set; }
        public string Nome { get; set; }


        public ContaVM(int agencia, string Nome)
        {
            this.Agencia = agencia;
            this.Nome = Nome;
        }
    }
}
