using SOLID.LSP;
using SOLID.OCP;
using SOLID.OCP.Extensions;

Produto produto = new Produto(1, "Teclado Logitech", "Teclado bluetooth", 240.00M, 320.00M, 100, true);

// Utilizando um método de extensão, estando de acordo com o OCP - Open/Closed Principle
Console.WriteLine($"Produto: {produto.Nome} Lucro: {produto.MargemLucroOCP()}");

Console.WriteLine();

/*** Implementação do LSP - Liskov Substitution Principle ***/
Console.WriteLine("Usando a classe base");
var conta = new Conta();
conta.Saldo = 100;
conta.Saque(250);
Console.WriteLine($"Saldo da conta: {conta.Saldo}");

Console.WriteLine();

Console.WriteLine("Usando a classe derivada");
var contaPP = new ContaPoupanca();
contaPP.Saldo = 100;

// Quebrando o LSP, pois a classe derivada tem o mesmo comportamento da classe base
contaPP.Saque(250);

// Uma solução seria criar uma classe abstrata Conta e classes ContaComum e ContaCorrente herdarem dela

Console.WriteLine($"Saldo da conta: {contaPP.Saldo}");