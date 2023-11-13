using System;

namespace ValorEReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis do tipo de valor
            int x0 = 5;
            int x1 = x0;

            // Variáveis do tipo de referência
            int[] y0 = new int[] { 1, 2, 3 };
            int[] y1 = y0;

            // Imprimir valores iniciais de x0 e y0
            ImprimirVars(x0, y0);
            Console.WriteLine();

            // Alterar valor de x1 e y1
            x1 = 7;
            y1[1] = 4;

            // Voltar a imprimir valores de x0 e y0
            ImprimirVars(x0, y0);
            Console.WriteLine();

            // Reinicializar y1
            y1 = new int[] { -5, -4, -3 };

            // Voltar a imprimir valores de x0 e y0
            ImprimirVars(x0, y0);
            Console.WriteLine();
        }

        private static void ImprimirVars(int i, int[] j)
        {
            Console.WriteLine($"Valor de x0 = {i}");
            Console.Write("Valor de y0 = [ ");
            foreach (int b in j) Console.Write($"{b} ");
            Console.Write("]");

            Console.WriteLine();
        }
    }
}
