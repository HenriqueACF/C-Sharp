using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Sistema_Interno;
using ByteBank_ADM.Sistema_Interno.Interface;

namespace ByteBank_ADM.Parceria;

public class ParceiroComercial: IAuth
{
    public string Senha { get; set; }

    public bool Autenticar(string senha)
    {
        
        return this.Senha == senha;
    }
    
}