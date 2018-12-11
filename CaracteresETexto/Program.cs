using System;

namespace CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto de caracteres e textos!");

            char letra = 'a';
            Console.WriteLine(letra);

            letra = (char)61;
            Console.WriteLine(letra);

            letra = (char)(letra + 1);
            Console.WriteLine(letra);

            string titulo = "Matheus - aprendendo básico do C#";
            string cursosProgramacao = ".NET " +
                " - JAVA" +
                " - PYTHON";
            Console.WriteLine(titulo);


            Console.ReadLine();
        }
    }
}
