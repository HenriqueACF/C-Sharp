namespace ByteBank_ADM.Funcionarios;

public abstract class Funcionario
{
    // 0 -- Funcionario
    // 1 -- diretor
    // 2 -- Dev
    public Funcionario(string cpf, double salario)
    {
        CPF = cpf;
        // Console.WriteLine("Criando um funcionario");
        TotalFuncionarios++;
        Salario = salario;
    }    

    // public int Tipo;
    public string Nome { get; set; }
    public string CPF { get;  private set; }
    public double Salario { get; protected set; }

    public virtual double getBonificacao()
    {
        return Salario * 0.1;
    }
    
    public static int  TotalFuncionarios{ get;  private set;}

    public virtual void aumentarsalario()
    {
        this.Salario *= 1.1;
    }
}