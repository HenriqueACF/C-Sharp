using ByteBank_ADM.Funcionarios;

Console.WriteLine("Welcome to the ByteBank_ADM");

Funcionario henrique = new Funcionario();
henrique.Nome = "Henrique";
henrique.CPF = "123456789";
henrique.Salario = 2000;

Console.WriteLine($"Bonificação {henrique.getBonificacao()}");

Diretor henriqueAssis = new Diretor();
henriqueAssis.Nome = "Assis";
henriqueAssis.CPF = "987654321";
henriqueAssis.Salario = 4000;

Console.WriteLine($"Bonificação {henriqueAssis.getBonificacao()}");
