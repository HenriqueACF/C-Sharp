using System;
using Treinamento.Domain.Core.ValueObjetcs.Transacao;

namespace Treinamento.Domain.Core.Models
{
    public class Conta
    {
        public int Agencia { get; private set; }

        public int Numero { get; private set; }

        public string Nome { get; private set; }

        public double Saldo { get; private set; }

        public string Senha { get; private set; }


        public Conta(TransacaoAbrirConta conta)
        {
            this.Agencia = conta.Agencia;
            this.Nome = conta.Nome;
            this.Numero = new Random().Next(12345678,99999999);
            this.Saldo = 0;
            this.Senha = "";

        }




    }
}
