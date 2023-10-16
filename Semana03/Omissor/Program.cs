using System;

namespace Omissor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis para guardar input de utilizador
            string s;
            char c;

            // Variável para guardar string com caracter omitido
            string sC;
            
            // Pedir ao utilizador uma string
            Console.Write("Escreve uma frase: ");
            
            // Guardar input de utilizador numa string
            s = Console.ReadLine();
            
            // Pedir ao utilizador um caracter
            Console.Write("Escreve um caracter: ");
            
            // Guardar input de utilizador num char
            sC = Console.ReadLine();

            // Passar char na string à variável char
            c = sC[0];
            
            Console.Write($"String com caracter omitido: ");

            // Loop FOREACH imprime cada caracter da string, sem char dado
            // pelo utilizador
            foreach (char aC in s)
            {
                if (aC != c)
                    Console.Write(aC);
            }
        }
    }
}
