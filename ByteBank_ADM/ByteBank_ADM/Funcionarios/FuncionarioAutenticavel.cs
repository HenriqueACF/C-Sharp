using ByteBank_ADM.Sistema_Interno.Interface;

namespace ByteBank_ADM.Funcionarios;

public abstract class FuncionarioAutenticavel: Funcionario, IAuth
{
    public FuncionarioAutenticavel(string cpf, double salario): base(cpf, salario)
    {
        
    }

    public string Senha{ get; set; }

    public bool Autenticar(string senha)
    {
        return Senha == senha;
    }
}