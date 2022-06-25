using ByteBank_ADM.Sistema_Interno;
using ByteBank_ADM.Sistema_Interno.Interface;

namespace ByteBank_ADM.Funcionarios.Utils;

public class Gerente: FuncionarioAutenticavel
{
    public Gerente(string cpf): base(cpf, 6000)
    {
        //CPF = cpf;
        // Console.WriteLine("Criando um diretor");
    }
    public override double getBonificacao()
    {
        return Salario * 0.22;
    }
    
    public override void aumentarsalario()
    {
        this.Salario *= 0.35;
    }
    
    // public string Senha { get; set; }
    //
    // public bool Autenticar(string senha)
    // {
    //     
    //     return this.Senha == senha;
    // }
}