using SOLID.OCP;
using SOLID.OCP.Extensions;

Produto produto = new Produto(1, "Teclado Logitech", "Teclado bluetooth", 240.00M, 320.00M, 100, true);

// Utilizando um método de extensão, estando de acordo com o OCP
Console.WriteLine($"Produto: {produto.Nome} Lucro: {produto.MargemLucroOCP()}");