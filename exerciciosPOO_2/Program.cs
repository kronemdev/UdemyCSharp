using exerciciosPOO_2;
using System.Threading.Channels;

Funcionarios fun1 = new Funcionarios();
Funcionarios fun2 = new Funcionarios();

Console.WriteLine("========================  Dados do primeiro Funcionario  ===================================");
Console.WriteLine(" ");
Console.WriteLine("Nome:");
fun1.Nome = Console.ReadLine();
Console.WriteLine("Salario:");
fun1.Salario = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("========================  Dados do segundo Funcionario  ===================================");
Console.WriteLine(" ");
Console.WriteLine("Nome:");
fun2.Nome = Console.ReadLine();
Console.WriteLine("Salario:");
fun2.Salario = double.Parse(Console.ReadLine());
double SalarioMedio = (fun1.Salario + fun2.Salario) / 2;
Console.WriteLine(" ");
Console.WriteLine("======================================== SALARIO MEDIO DOS FUNCIONARIOS =======================================");
Console.WriteLine(" ");
Console.WriteLine($"Salario Medio = {SalarioMedio:f2}");

