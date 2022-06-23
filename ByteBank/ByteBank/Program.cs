using ByteBank;

Console.WriteLine("Welcome to the byteBank");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Henrique";
conta1.conta = "1234-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 133.65;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Enrique sem aga";
conta2.conta = "X-4321";
conta2.numero_agencia = 32;
conta2.nome_agencia = "Agencia Bairro";
conta2.saldo = 999.63;

    

// =============================================================
Console.WriteLine($"Titular: {conta1.titular}");
Console.WriteLine($"Conta: {conta1.conta}");
Console.WriteLine($"Numero da Agencia : {conta1.numero_agencia}");
Console.WriteLine($"Nome da Agencia : {conta1.nome_agencia}");
Console.WriteLine($"Saldo: {conta1.saldo}");

Console.WriteLine($"Titular: {conta2.titular}");
Console.WriteLine($"Conta: {conta2.conta}");
Console.WriteLine($"Numero da Agencia : {conta2.numero_agencia}");
Console.WriteLine($"Nome da Agencia : {conta2.nome_agencia}");
Console.WriteLine($"Saldo: {conta2.saldo}");

//SAQUE
Console.WriteLine($"Saldo do(a) {conta1.titular} pré saque: {conta1.saldo}");
bool saque = conta1.Sacar(40);
Console.WriteLine($"Saque realizado? {saque}");
Console.WriteLine($"Saldo do(a) {conta1.titular} pós saque: {conta1.saldo}");

//DEPOSITAR
Console.WriteLine($"Saldo do(a) {conta1.titular} pré deposito; {conta1.saldo}");
conta1.Depositar(60);
Console.WriteLine($"Saldo do(a) {conta1.titular} pós deposito: {conta1.saldo}");


Console.ReadKey();