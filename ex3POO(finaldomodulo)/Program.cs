using ex3_finaldomodulo_;

Aluno aluno = new Aluno();
Console.Write("Nome do Aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do Aluno: ");
double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double n3 = double.Parse(Console.ReadLine());
aluno.Nota = n1 + n2 + n3;
Console.WriteLine($"NOTA FINAL = {aluno.Nota:F2} ");
aluno.NotaFaltando = 60 - aluno.Nota;
if(aluno.Nota < 60)
{
    Console.WriteLine("Reprovado");
    Console.WriteLine($"FALTARAM {aluno.NotaFaltando:F2} PONTOS");
}
else
{
    Console.WriteLine("APROVADO");
}