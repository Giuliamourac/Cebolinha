using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva algo para o Cebolinha te imitar.");

            string frase = Console.ReadLine()!;

            string cebolinha = frase.Replace("R", "L").Replace("r", "l");

            Console.WriteLine($"Cebolinha: {cebolinha}");

        }
    }
}