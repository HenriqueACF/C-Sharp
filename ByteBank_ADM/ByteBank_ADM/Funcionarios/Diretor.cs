namespace ByteBank_ADM.Funcionarios;

public class Diretor: Funcionario
{
    public Diretor(string cpf, double salario): base(cpf, salario)
    {
        //CPF = cpf;
        Console.WriteLine("Criando um diretor");
    }
    public override double getBonificacao()
    {
        return Salario + base.getBonificacao();
    }
    
    public override void aumentarsalario()
    {
        this.Salario *= 1.15;
    }
}