using exercicioPOO_LerDadosDeProdutoEmEstoque;

Console.WriteLine("=============== Entre com os Dados dos produtos =================");
Console.Write("Nome:");
string nome = Console.ReadLine();
Console.Write("Preço:");
double preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade no Estoque:");
int quantidade = int.Parse(Console.ReadLine());

Produto Produto = new Produto( nome, preco,quantidade);


//Console.WriteLine($"Dados do Produto: {Produto.Nome}, ${Produto.Preco}, Total: ${}");
Console.WriteLine($"Dados do Produto: {Produto} ");
Console.WriteLine(" ");
Console.WriteLine("Digite o Numero de Produtos a Ser Adicionado ao estoque: ");
int padd = int.Parse(Console.ReadLine());
Produto.AdicionarProdutos(padd);
Console.WriteLine(" ");
Console.WriteLine($"Dados Atualizados: {Produto} ");
Console.WriteLine(" ");
Console.WriteLine("Digite o numero de produtos a ser Removido do estoque: ");
int premov = int.Parse(Console.ReadLine());
Produto.RemoverProdutos(premov);
Console.WriteLine(" ");
Console.WriteLine($"Dados Atualidados: {Produto} ");