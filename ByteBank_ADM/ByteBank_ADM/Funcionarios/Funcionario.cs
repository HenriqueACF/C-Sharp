namespace ByteBank_ADM.Funcionarios;

public class Funcionario
{
    // 0 -- Funcionario
    // 1 -- diretor
    // 2 -- Dev
    

    // public int Tipo;
    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }

    public double getBonificacao()
    {
        return Salario * 0.1;
    }
}