using System;
using System.Globalization;

namespace IDADES_SOMA_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int idade, cont;
            cont = 0;

            do
            {
                Console.WriteLine("Entre com a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                soma = soma + idade;
                cont++;
            }
            while (idade > 0);

            Console.WriteLine();
            double media = (soma - idade)/--cont;
            Console.WriteLine($"Média das idades {media.ToString("F2", CultureInfo. InvariantCulture)}.");
        }
    }
}
