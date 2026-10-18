using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioPOO_LerDadosDeProdutoEmEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco,int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade; 
        }
        


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco  ;
        }


        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;   
        }


        public override string ToString()
        {
            return Nome + ", $ "+  Preco + ", " + Quantidade + " Unidade, Total: $ " + ValorTotalEmEstoque().ToString("f2");       
           
        }
        
    }
}
