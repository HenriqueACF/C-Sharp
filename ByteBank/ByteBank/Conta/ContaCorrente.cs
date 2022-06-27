using ByteBank.Titular;

namespace ByteBank;

public class ContaCorrente
{
    public ContaCorrente(int numero_agencia, int agencia)
    {
        Numero_agencia = numero_agencia;
        //Conta = conta;
        Agencia = agencia;
        
        // TaxaOperacao = 30 / TotalDeContasCriadas;
        if (agencia <= 0)
        {
            throw new ArgumentException("Os numeros da agencia devem ser maior do que 0", nameof(agencia));
        }

        if (numero_agencia <= 0)
        {
            throw new ArgumentException("Os numeros da agencia devem ser maior do que 0", nameof(numero_agencia));
        }
        TotalDeContasCriadas += 1;
    }
    // private Cliente titular;
    public Cliente Titular { get; set; }
    
   // public static double TaxaOperacao { get; private set; }
   public static int TotalDeContasCriadas { get; private set; }
   public int  ContadorDeSaquesNaoPermitidos { get; private set; }
   public int ContadorTransferenciasNaoPermitidas { get; private set; }

    private int _agencia;

    public int Agencia
    {
        get
        {
            return _agencia;
        }
        private set
        {
            if (value <= 0)
            {
                return;
            }

            _agencia = value;
        }
    }

    private int _numero_agencia;
    public int Numero_agencia { get; }
    public string Nome_agencia { get; set; }
    private double saldo;

    public void Sacar(double valor)
    {
        if (_saldo < valor)
        {
            ContadorDeSaquesNaoPermitidos++;
            throw new SaldoInsuficienteException($"Saldo Insuficiente para saque no valor de: R${valor}");
        }
        _saldo = valor;
    }

    public void Depositar(double valor)
    {
        saldo = saldo + valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        try
        {
            Sacar(valor);
        }
        catch (SaldoInsuficienteException ex)
        {
            ContadorTransferenciasNaoPermitidas++;
            throw new SaldoInsuficienteException($"Saldo insuficiente para realizar transferencia no valor de: {valor}");
        }
        _saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }

    private double _saldo = 100;
    public double Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            }
            else
            {
                saldo = value;
            }
        }
    }
}