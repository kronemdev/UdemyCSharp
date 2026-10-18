using Ex_Fixacao_ContaBancaria;

ContaBancaria conta;

Console.WriteLine("Entre Com o Número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Entre Com o Titular da conta: ");
string titular = Console.ReadLine();
Console.WriteLine(" ");
Console.WriteLine("Haverá deposito inicial (s/n)? ");
char resp = char.Parse(Console.ReadLine());
if (resp == 's' || resp == 'S')
{
    Console.WriteLine("Entre com o Valor de Depósito iniciaial: ");
    double depositoInicial = double.Parse(Console.ReadLine());
    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else
{
    conta = new ContaBancaria(numero, titular);
}
Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);
Console.WriteLine();
Console.WriteLine("Entre com um Valor para Depósito: ");
double quantia = double.Parse(Console.ReadLine());
conta.Deposito(quantia);
Console.WriteLine();
Console.WriteLine("Dados da conta Atualizados:");
Console.WriteLine(conta);
Console.WriteLine();
Console.WriteLine("Entre com um Valor para Saque: ");
quantia = double.Parse(Console.ReadLine());
conta.Saque(quantia);
Console.WriteLine();
Console.WriteLine("Dados da conta Atualizados:");
Console.WriteLine(conta);
