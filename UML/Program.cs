using UML.Banco;

var contaPoupanca = new ContaPoupanca(1, "Lucas Eduardo Ferreira da Rosa");

contaPoupanca.Depositar(5000);

Console.WriteLine($"Saldo da conta poupança: {contaPoupanca.Saldo}");

var contaCorrente = new ContaCorrente(1, "Lara Maria Ferreira da Rosa");

contaCorrente.Depositar(2000);
contaCorrente.Sacar(1000);

Console.WriteLine($"Saldo da conta corrente: {contaCorrente.Saldo}");