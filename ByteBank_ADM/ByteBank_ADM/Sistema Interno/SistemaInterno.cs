using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.Sistema_Interno.Interface;

namespace ByteBank_ADM.Sistema_Interno;

public class SistemaInterno
{
    public bool Logar(IAuth funcionario, string senha)
    {
        bool usuario_autenticado = funcionario.Autenticar(senha);
        if (usuario_autenticado)
        {
            Console.WriteLine($"bem vindo ao sistema");
            return  true;
        }
        else
        {
            Console.WriteLine($"Senha incorreta");
            return false;
        }
    }
}