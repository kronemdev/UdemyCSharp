using ex2_finaldomodulo_;

Funcionario f = new Funcionario();
Console.Write("Nome:");
f.Nome = Console.ReadLine();
Console.WriteLine(" ");
Console.Write("Salário bruto:");
f.SalarioBruto = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Imposto:");
f.Imposto = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine($"Funcionário: {f.Nome} , $ {f.SalarioLiquido()}");
Console.WriteLine(" ");
Console.WriteLine("Digite a percentagem para aumentar o salario: ");
double porcentagem = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
f.AumentarSalrio(porcentagem);
Console.WriteLine($"Dados Atualizados: {f}");
