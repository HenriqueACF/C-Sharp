namespace ByteBank_ADM.Funcionarios.Utils;

public class GerenciadorBonificaçao
{
    private double totalBonificacao { get; set;}

    public void Registrar(Funcionario funcionario)
    {
        this.totalBonificacao += funcionario.getBonificacao();
    }
    
    public void Registrar(Diretor diretor)
    {
        this.totalBonificacao += diretor.getBonificacao();
    }

    public double getBonificacao()
    {
        return this.totalBonificacao;
    }
}