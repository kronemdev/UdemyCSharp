using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Fixacao_ContaBancaria
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; } // propriedade
        public string Titular { get; set; } // propriedade
        public double Saldo { get; private set; } // propriedade

        public ContaBancaria(int numero,string titular) // construtor
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular,double saldo) : this(numero, titular) // construtor
        {
            Saldo = saldo;
        }
        public void Deposito(double quantia) // metodo
        {
            Saldo += quantia;

        }
        public void Saque(double quantia) // metodo
        {
            Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2");
                
        }
    }

}
