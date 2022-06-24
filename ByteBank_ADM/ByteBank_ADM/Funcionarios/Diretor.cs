namespace ByteBank_ADM.Funcionarios;

public class Diretor
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }

    public double getBonificacao()
    {
        return Salario * 0.2;
    }
}