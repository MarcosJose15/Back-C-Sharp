using System;
using System.Globalization;
using System.Security.AccessControl;

namespace SistemaBanco
{

    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        

        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        //Metodos

        public override string ToString()
        {   
            return  
                (   "\nConta "
                    + Numero
                    + ", Titular: "
                    + Titular
                    + ", Saldo Atual: $"
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture));
                
        }
    }
}