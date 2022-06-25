namespace ByteBank_ADM.Funcionarios;

public class Dev: Funcionario
{
    public Dev(string cpf) : base(cpf, 3000)
    {
    }
    
    public override double getBonificacao()
    {
        return Salario * 0.1;
    }
    
    public override void aumentarsalario()
    {
        this.Salario *= 0.15;
    }
}