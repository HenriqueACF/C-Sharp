using ByteBank_ADM.Sistema_Interno;
using ByteBank_ADM.Sistema_Interno.Interface;

namespace ByteBank_ADM.Funcionarios;

public class Diretor: FuncionarioAutenticavel
{
    public Diretor(string cpf): base(cpf, 4000)
    {
        //CPF = cpf;
        // Console.WriteLine("Criando um diretor");
    }
    public override double getBonificacao()
    {
        return Salario * 0.05;
    }
    
    public override void aumentarsalario()
    {
        this.Salario *= 0.3;
    }
    
    // public string Senha { get; set; }
    //
    // public bool Autenticar(string senha)
    // {
    //     
    //     return this.Senha == senha;
    // }
}