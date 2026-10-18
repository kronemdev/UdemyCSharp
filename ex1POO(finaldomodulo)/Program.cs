using ex1_finaldomodulo_;

Retangulo ret = new Retangulo();
Console.WriteLine("Entre com a Largura:");
ret.Largura = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Entre com a Altura:");
ret.Altura = double.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine($"AREA = {ret.Area()}");
Console.WriteLine(" ");
Console.WriteLine($"PERIMETRO = {ret.Perimetro()}");
Console.WriteLine(" ");
Console.WriteLine($"DIAGONAL = {ret.Diagonal()}");
