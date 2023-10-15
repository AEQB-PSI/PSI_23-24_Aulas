using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir codificação usada pela consola
            Console.OutputEncoding = Encoding.UTF8;
            
            // Criar variáveis inteiras
            int i = 5;
            uint ui = 7U;
            long l = 142L;

            // Criar variáveis reais
            float f = 15.27f;
            double d = 2.75;
            decimal z = 53.213m;

            // Criar variáveis char
            char copyrightSymbol = '\u00A9';
            char heart = '\u2665';

            // Criar variáveis bool
            bool b = true;
            bool c = 4 > 5;
            
            // Imprimir variáveis inteiras
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);

            Console.WriteLine();

            // Imprimir variáveis reais
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(z);

            Console.WriteLine();

            // Imprimir variáveis char
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(heart);

            Console.WriteLine();

            // Imprimir variáveis bool
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
