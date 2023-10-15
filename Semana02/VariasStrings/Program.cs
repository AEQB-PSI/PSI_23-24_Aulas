using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir codificação usada pela consola
            Console.OutputEncoding = Encoding.UTF8;

            // Criar strings normais e verbatim
            string s = "Uma string";
            string t = "Outra string";
            string r = @"""Uma string entre aspas""";
            string i = @"\Uma string sem aspas\";
            string n = "\u00A9 \u2665";
            string g = @"\u0010 sem UTF";

            // Imprimir strings na consola
            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(r);
            Console.WriteLine(i);
            Console.WriteLine(n);
            Console.WriteLine(g);
        }
    }
}
