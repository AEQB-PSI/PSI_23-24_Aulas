using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2, c, d;

            // Incrementa 'a' e 'b', só atualiza depois da operação
            // a = 5 + 1; b = 2 + 1; c = 5 + 2
            c = a++ + b++; // Depois desta operação, 'a' = 6 e 'b' = 3 
            Console.WriteLine(c);

            // Decrementa 'a' e 'b' antes da operação
            // a = 6 - 1; b = 3 - 1; c = 5 + 2
            d = --a + --b;
            Console.WriteLine(d);
        }
    }
}
