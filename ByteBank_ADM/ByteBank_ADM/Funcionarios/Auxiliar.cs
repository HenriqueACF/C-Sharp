namespace ByteBank_ADM.Funcionarios;

public class Auxiliar: Funcionario
{
    public Auxiliar(string cpf) : base(cpf, 1500)
    {
    }
    
    public override double getBonificacao()
    {
        return Salario *= 0.1;
    }
    
    public override void aumentarsalario()
    {
        this.Salario *= 1.05;
    }
}