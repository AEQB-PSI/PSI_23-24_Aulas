using System;

namespace PrimeiroMetodo
{
    class Program
    {
        private static void Main(string[] args)
        {
            ContarAte10();
            Console.WriteLine();
            ContarAte10();
        }

        private static void ContarAte10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
