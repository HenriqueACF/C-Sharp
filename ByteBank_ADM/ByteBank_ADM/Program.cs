using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Funcionarios.Utils;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.Sistema_Interno;

Console.WriteLine("Welcome to the ByteBank_ADM");

// GerenciadorBonificaçao gerenciador = new GerenciadorBonificaçao();
//
// Funcionario henrique = new Funcionario("123456789", 2000);
// henrique.Nome = "Henrique";
// Console.WriteLine($"Total de funcionarios {Funcionario.TotalFuncionarios}");
//
// Console.WriteLine($"Bonificação {henrique.getBonificacao()}");
//
// Diretor henriqueAssis = new Diretor("987654321", 2000);
// henriqueAssis.Nome = "Assis";
// Console.WriteLine($"Total de funcionarios {Funcionario.TotalFuncionarios}");
//
// Console.WriteLine($"Bonificação {henriqueAssis.getBonificacao()}");
// Diretor phil = new Diretor("987654321", 4000);
// phil.Nome = "phil";
// Console.WriteLine($"Total de funcionarios {Funcionario.TotalFuncionarios}");
//
// gerenciador.Registrar(henrique);
// gerenciador.Registrar(henriqueAssis);
//
//
//
// Console.WriteLine($"Total de Bonificação {gerenciador.getBonificacao()}");
//
// Console.WriteLine($"Salario antigo: {henrique.Salario}");
// henrique.aumentarsalario();
// Console.WriteLine($"Aumento do salario {henrique.Salario}");
//
// Console.WriteLine($"Salario antigo: {henriqueAssis.Salario}");
// henriqueAssis.aumentarsalario();
// Console.WriteLine($"Aumento do salario {henriqueAssis.Salario}");
//
// Dev teste = new Dev("20000000");
// teste.aumentarsalario();
//
// Console.WriteLine($"Salario antigo: {teste.Salario}");
// teste.aumentarsalario();
// Console.WriteLine($"Aumento do salario {teste.Salario}");
//
//
// Auxiliar aux = new Auxiliar("264645646");
// teste.aumentarsalario();
//
// Console.WriteLine($"Salario antigo: {aux.Salario}");
// aux.aumentarsalario();
// Console.WriteLine($"Aumento do salario {aux.Salario}");


//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorBonificaçao gerenciador = new GerenciadorBonificaçao();

    Dev desenvolvedor = new Dev("123456789");
    desenvolvedor.Nome = "Henrique";
    
    Auxiliar auxiliar = new Auxiliar("741852963");
    auxiliar.Nome = "nome de auxiliar";
    
    Diretor diretor = new Diretor("963852741");
    diretor.Nome = "nome de diretor";
    
    Gerente gerente = new Gerente("999999999");
    gerente.Nome = "nome de gerente";
    
    
    gerenciador.Registrar(desenvolvedor);
    gerenciador.Registrar(auxiliar);
    gerenciador.Registrar(diretor);
    gerenciador.Registrar(gerente);

    Console.WriteLine($"Total de bonificação: {gerenciador.getBonificacao()}");
    
    
    
    

}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("1111111");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";
    
    Gerente roberto = new Gerente("22222222");
    roberto.Nome = "Roberto";
    roberto.Senha = "123";
    
    ParceiroComercial henrique = new ParceiroComercial();
    henrique.Senha = "321";

    sistemaInterno.Logar(roberta, "123");
    sistemaInterno.Logar(roberto, "123");
    sistemaInterno.Logar(henrique, "321");
}


