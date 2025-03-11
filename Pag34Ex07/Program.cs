using Pag34Ex07;

ContaBancaria contaBancaria = new ContaBancaria();

int numeroDoCartao;
double saldo, saque, deposito, desconto;
string nomeDoTitular, classificacao;

Console.WriteLine("Qual o nome no seu cartão: ");
nomeDoTitular = Console.ReadLine();

Console.WriteLine("Qual a sua classificação (comum ou especial): ");
classificacao = Console.ReadLine();

Console.WriteLine("Qual o numero do seu cartão: ");
numeroDoCartao = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu saldo: ");
saldo = double.Parse(Console.ReadLine());

Console.WriteLine("Quantos você quer depositar: ");
deposito = double.Parse(Console.ReadLine());

contaBancaria.Deposito(saldo, deposito);

Console.WriteLine("Quantos você quer sacar: ");
saque = double.Parse(Console.ReadLine());

contaBancaria.Saque(saldo, saque, deposito, classificacao);

Console.WriteLine($"Nome do titular: {nomeDoTitular} classificação do titular: {classificacao} numero do cartão: {numeroDoCartao} deposito feito na conta: {contaBancaria.Deposito} saque feito na conta: {contaBancaria.Saque}");



