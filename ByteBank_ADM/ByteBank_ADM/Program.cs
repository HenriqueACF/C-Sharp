using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Funcionarios.Utils;

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


CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorBonificaçao gerenciador = new GerenciadorBonificaçao();

    Dev henrique = new Dev("123456789");
    henrique.Nome = "Henrique";
    
    Auxiliar auxiliar = new Auxiliar("741852963");
    auxiliar.Nome = "nome de auxiliar";
    
    Diretor diretor = new Diretor("963852741");
    diretor.Nome = "nome de diretor";
    
    
    gerenciador.Registrar(henrique);
    gerenciador.Registrar(auxiliar);
    gerenciador.Registrar(diretor);

    Console.WriteLine($"Total de bonificação: {gerenciador.getBonificacao()}");
    
    
    
    

}


