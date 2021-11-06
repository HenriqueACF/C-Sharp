using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Domain.Core.Models.VM;

namespace Treinamento.Domain.Core.Models
{
    public class Conta
    {
        public int Agencia { get; private set; }

        public int Numero { get; private set; }

        public string Nome { get; private set; }

        public double Saldo { get; private set; }

        public string Senha { get; private set; }


        public Conta(ContaVM conta)
        {
            this.Agencia = conta.Agencia;
            this.Nome = conta.Nome;
            this.Numero = new Random().Next(12345678,99999999);
            this.Saldo = 0;
            this.Senha = "";

        }




    }
}
