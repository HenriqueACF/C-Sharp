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

    
Console.WriteLine($"Titular: {titular}");
Console.WriteLine($"Conta: {conta}");
Console.WriteLine($"Numero da Agencia : {numero_agencia}");
Console.WriteLine($"Nome da Agencia : {nome_agencia}");
Console.WriteLine($"Saldo: {saldo}");   
Console.ReadKey();