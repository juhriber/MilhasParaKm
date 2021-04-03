using System;

namespace Pasta_Visual
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhas;
            const double km = 1.609;

            Console.WriteLine("Digite Seu Valor em Milhas: ");
            milhas = double.Parse(Console.ReadLine());

            Console.WriteLine("Seu Valor de Milhas para KM");
            Console.WriteLine($"{milhas * km}");
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
