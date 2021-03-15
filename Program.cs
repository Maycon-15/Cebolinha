using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string FraseDoCebolinha;
            Console.WriteLine("Digite algo para que o Cebolinha possa repetir:");
            frase = Console.ReadLine();

            Console.WriteLine();

            FraseDoCebolinha = frase.Replace("rr","l");
            FraseDoCebolinha = frase.Replace("r","l");
            

            Console.WriteLine($"Cebolinha: {FraseDoCebolinha}");
            
        }
    }
}
