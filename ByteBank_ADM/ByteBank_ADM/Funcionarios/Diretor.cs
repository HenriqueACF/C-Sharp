namespace ByteBank_ADM.Funcionarios;

public class Diretor: Funcionario
{
    public Diretor(string cpf): base(cpf, 4000)
    {
        //CPF = cpf;
        // Console.WriteLine("Criando um diretor");
    }
    public override double getBonificacao()
    {
        return Salario *= 0.05;
    }
    
    public override void aumentarsalario()
    {
        this.Salario *= 1.15;
    }
}