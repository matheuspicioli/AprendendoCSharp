using System;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4!!!");
            double salario = 1200.50;
            int salarioInteiro  = (int)salario;
            Console.WriteLine(salarioInteiro);
            long idade = 13000000000;

            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.75f;
            Console.WriteLine(altura);
        }
    }
}