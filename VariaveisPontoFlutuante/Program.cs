using System;

namespace VariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, valor;
            Console.WriteLine("Ponto flutuante");
            salario = 1200.50;
            Console.WriteLine(salario);

            valor = 15 / 2;
            Console.WriteLine("15 / 2 = " + valor);

            valor = 15.0 / 2;
            Console.WriteLine("15.0 / 2 = " + valor);
        }
    }
}