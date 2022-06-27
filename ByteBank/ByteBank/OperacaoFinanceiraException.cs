namespace ByteBank;

public class OperacaoFinanceiraException: Exception
{
    public OperacaoFinanceiraException()
    {
        
    }

    public OperacaoFinanceiraException(string message) : base(message)
    {
        
    }

    public OperacaoFinanceiraException(string message, Exception excecaoInterna) : base(message, excecaoInterna)
    {
        
    }
}