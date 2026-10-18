using exerciciosPOO_1;

Pessoas pessoa1 = new Pessoas();
Pessoas pessoa2 = new Pessoas();

Console.WriteLine("===================  Dados da primeira Pessoa  ======================== ");
Console.WriteLine("Nome:");
pessoa1.Nome = Console.ReadLine();
Console.WriteLine("Idade:");
pessoa1.Idade = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("===================  Dados da segunda Pessoa  =========================");
Console.WriteLine("Nome:");
pessoa2.Nome = Console.ReadLine();
Console.WriteLine("Idade:");
pessoa2.Idade = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
if(pessoa1.Idade > pessoa2.Idade)
{
    Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
}
else
{
    Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
}

