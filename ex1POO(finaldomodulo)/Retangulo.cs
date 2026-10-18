using System;
using System.Collections.Generic;
using System.Text;

namespace ex1_finaldomodulo_
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;

        }
        public double Perimetro()
        {
            return Largura * Altura + 2;
        }

        public  double Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }
            
    }
}
