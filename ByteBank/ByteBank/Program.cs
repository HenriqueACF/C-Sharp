﻿using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Welcome to the byteBank");

// ContaCorrente conta1 = new ContaCorrente();
// conta1.titular = "Henrique";
// conta1.conta = "1234-X";
// conta1.numero_agencia = 23;
// conta1.nome_agencia = "Agencia Central";
// conta1.saldo = 133.65;
//
// ContaCorrente conta2 = new ContaCorrente();
// conta2.titular = "Enrique sem aga";
// conta2.conta = "X-4321";
// conta2.numero_agencia = 32;
// conta2.nome_agencia = "Agencia Bairro";
// conta2.saldo = 999.63;
//
//     
//
// // =============================================================
// Console.WriteLine($"Titular: {conta1.titular}");
// Console.WriteLine($"Conta: {conta1.conta}");
// Console.WriteLine($"Numero da Agencia : {conta1.numero_agencia}");
// Console.WriteLine($"Nome da Agencia : {conta1.nome_agencia}");
// Console.WriteLine($"Saldo: {conta1.saldo}");
//
// Console.WriteLine($"Titular: {conta2.titular}");
// Console.WriteLine($"Conta: {conta2.conta}");
// Console.WriteLine($"Numero da Agencia : {conta2.numero_agencia}");
// Console.WriteLine($"Nome da Agencia : {conta2.nome_agencia}");
// Console.WriteLine($"Saldo: {conta2.saldo}");

//SAQUE
// Console.WriteLine($"Saldo do(a) {conta1.titular} pré saque: {conta1.saldo}");
// bool saque = conta1.Sacar(40);
// Console.WriteLine($"Saque realizado? {saque}");
// Console.WriteLine($"Saldo do(a) {conta1.titular} pós saque: {conta1.saldo}");
// Console.WriteLine("-------------------------------------");

//DEPOSITAR
// Console.WriteLine($"Saldo do(a) {conta1.titular} pré deposito; {conta1.saldo}");
// conta1.Depositar(60);
// Console.WriteLine($"Saldo do(a) {conta1.titular} pós deposito: {conta1.saldo}");
// Console.WriteLine("-------------------------------------");

//Tranferir
// Console.WriteLine($"Saldo do(a) {conta1.titular} pré transferencia {conta1.saldo}");
// Console.WriteLine($"Saldo do(a) {conta2.titular} pré transferencia {conta2.saldo}");
// bool transferir = conta1.Transferir(100, conta2);
// Console.WriteLine($"Transferencia realizada com sucesso? {transferir}");
//
// Console.WriteLine($"Saldo do(a) {conta1.titular} pós transferencia {conta1.saldo}");
// Console.WriteLine($"Saldo do(a) {conta2.titular} pós transferencia {conta2.saldo}");
Console.WriteLine("-------------------------------------");

// Cliente cliente = new Cliente();
// cliente.nome = "HenriqueACF";
// cliente.profissao = "Developer";
// cliente.cpf = "465746513";
//
// ContaCorrente conta3 = new ContaCorrente();
// conta3.titular = new Cliente();
//
// conta3.conta = "7894561233- X";
// conta3.nome_agencia = "Agencia Centro";
// conta3.numero_agencia = 25;
// Console.WriteLine($"cliente: {cliente.nome}");
// Console.WriteLine($"cliente': {conta3.titular.nome}"); 
// Cliente henrique = new Cliente();
// henrique.nome = "henrique";


// ContaCorrente conta4 = new ContaCorrente(23, "123456-X");
// conta4.Saldo = 150;
// conta4.Titular = henrique;
//
// Console.WriteLine(conta4.Titular.nome);
// Console.WriteLine(conta4.Saldo);
// Console.WriteLine(conta4.Numero_agencia);
// Console.WriteLine(conta4.Conta);

// ContaCorrente conta5 = new ContaCorrente(123, "123456-X");
// ContaCorrente conta6 = new ContaCorrente(321, "123456-X");
// Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta = new ContaCorrente(1000, "123456-X");
Console.WriteLine(ContaCorrente.TaxaOperacao);


Console.ReadKey();