using UML.Banco;
using UML.ClasseAbstrata;

var contaPoupanca = new ContaPoupanca(1, "Lucas Eduardo Ferreira da Rosa");

contaPoupanca.Depositar(5000);

Console.WriteLine($"Saldo da conta poupança: {contaPoupanca.Saldo}");

var contaCorrente = new ContaCorrente(1, "Lara Maria Ferreira da Rosa");

contaCorrente.Depositar(2000);
contaCorrente.Sacar(1000);

Console.WriteLine($"Saldo da conta corrente: {contaCorrente.Saldo}");

Console.WriteLine();

var quadrado = new Quadrado();

Console.WriteLine(quadrado.Descricao());

Console.WriteLine("Informe a cor da figura: ");
quadrado.Cor = Console.ReadLine();

Console.WriteLine("Informe o lado do quadrado: ");
quadrado.Lado = double.Parse(Console.ReadLine());

quadrado.CalcularArea();
quadrado.CalcularPerimetro();

Console.WriteLine($"A área do quadrado é: {quadrado.Area}");
Console.WriteLine($"O perímetro do quadrado é: {quadrado.Perimetro}");
Console.WriteLine($"A cor do quadrado é: {quadrado.Cor}");