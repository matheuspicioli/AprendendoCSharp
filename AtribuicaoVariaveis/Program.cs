using System;

namespace AtribuicaoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int idade = 20;

            int idadeMatheus = idade;

            idade = 33;

            Console.WriteLine(idade);
            Console.WriteLine(idadeMatheus);

            Console.ReadLine();
        }
    }
}
