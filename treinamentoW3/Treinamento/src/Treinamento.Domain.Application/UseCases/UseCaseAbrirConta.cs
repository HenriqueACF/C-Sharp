using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Domain.Application.Interfaces;
using Treinamento.Domain.Core.Models;
using Treinamento.Domain.Core.Models.VM;

namespace Treinamento.Domain.Application.UseCases
{
    public class UseCaseAbrirConta : IUseCaseAbrirConta
    {


        public Conta NovaConta(ContaVM vm)
        {
            return new Conta(vm);
        }
    }
}
