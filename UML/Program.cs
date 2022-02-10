using UML.Banco;
using UML.ClasseAbstrata;
using UML.ClasseSealed;
using UML.Interface;
using UML.InterfaceAbstract;
using UML.InterfacePratica;

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

Console.WriteLine();

/*** Instânciando uma sealed class ***/
CalculaSoma soma = new CalculaSoma();

var resultado = soma.Somar(50, 50, 30, 70);
Console.WriteLine($"Resultado da operação Somar da sealed class CalculaSoma: {resultado}");

Console.WriteLine();

/*** Treinando interfaces ***/
GravarJSON gravarJSON = new GravarJSON();
GravarXML gravarXML = new GravarXML();

gravarJSON.GravarArquivo();
gravarXML.GravarArquivo();

Console.WriteLine();

// Criando instância da nossa classe concreta
var registraOcorrenciaConsole = new RegistraOcorrencia(new RegistrarConsole());
registraOcorrenciaConsole.Registrar("Registro console");

var registraOcorrenciaArquivo = new RegistraOcorrencia(new RegistrarArquivo(@"C:\Users\lcsef\Documents\Workspaces\dotnet-udemy\SOLID\teste.txt"));
registraOcorrenciaArquivo.Registrar("Registro arquivo");

Console.WriteLine();

/*** Interface x Classe abstrata ***/
// Interface
var myCircle = new CirculoInt();
myCircle.Desenhar();
myCircle.Identificar();

Console.WriteLine();

var mySquare = new QuadradoAbs("Square");
mySquare.Desenhar();
mySquare.Identificar();
