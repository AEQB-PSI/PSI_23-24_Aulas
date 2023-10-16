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

            // Variáveis de apoio
            int x = 10;
            char c = 'a';

            // Criar strings normais e verbatim
            string s = "Uma string";
            string t = "Outra string";
            string r = @"""Uma string entre aspas""";
            string i = @"\Uma string sem aspas\";
            string n = "\u00A9 \u2665";
            string g = @"\u0010 sem UTF";
            
            // Criar strings concatenadas
            string cs = "Uma" + "string" + 2;
            string cr = s + t + x;

            // Criar strings interpoladas
            string si = $"{s} interpolado";
            string ri = $@"{s} + {c} = {t} verbatim {x}";

            // Criar strings com String.Format()
            string sf = String.Format("{0} e {1}", s, t);

            // Imprimir strings na consola
            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(r);
            Console.WriteLine(i);
            Console.WriteLine(n);
            Console.WriteLine(g);

            Console.WriteLine();

            Console.WriteLine(cs);
            Console.WriteLine(cr);

            Console.WriteLine(si);
            Console.WriteLine(ri);

            Console.WriteLine();

            Console.WriteLine(sf);
            Console.WriteLine(@"Verbatim com x = {0}", x);
            Console.WriteLine();
        }
    }
}
