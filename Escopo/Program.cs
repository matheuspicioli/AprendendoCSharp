﻿using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testando condicionais");

            int idade = 16;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
            }

            Console.ReadLine();
        }
    }
}
