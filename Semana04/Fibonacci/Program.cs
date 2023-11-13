using System;

namespace Fibonacci
{
    /// <summary>
    /// Este programa imprime um número da sequência de Fibonacci,
    /// na posição pedida pelo utilizador.
    /// </summary>
    class Program 
    {
        /// <summary>
        /// Neste método, pedimos um número ao utilizador, e usamo-lo como
        /// um índice para encontra o número correspondente na sequência de 
        /// Fibonacci, através do método com o mesmo nome.
        /// </summary>
        /// <param name="args"> 
        /// Argumentos passados através da linha de comandos 
        /// </param>
        public static void Main (string[] args) 
        {
            // Variável para guardar input do utilizador
            int n;

            // Variável para guardar número da sequência de Fibonacci
            int fib;
            
            // Verificar se existe pelo menos 1 argumento passado na linha de comandos
            if (args.Length > 0)
            {
                // Guardar argumentos da linha de comandos na variável correspondente
                n = Convert.ToInt32(args[0]);
            }
            // Caso não existam argumentos
            else
            {
                // Pedir input do utilizador e guardar
                Console.WriteLine("Vou procurar um número na sequência de Fibonacci");
                Console.Write("Indica a posição do número: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            // Guardar número da sequência de Fibonacci na posição indicada
            fib = Fibonacci(n);
            
            // Imprimir número na posição indicada
            Console.Write($"Nº na posição {n} da sequência de Fibonacci: ");
            Console.Write(fib);
        }

        /// <summary>
        /// Determina o valor da sequência de Fibonacci
        /// que corresponde ao número dado.
        /// </summary>
        /// <param name="n"> Índice para o número da sequência </param>
        /// <returns> O número na posição 'n' da sequência </returns>
        private static int Fibonacci(int n)
        {
            // Variável para guardar o número atual da sequência
            int fib;

            // Caso base
            if (n <= 2)
                // Corresponde à posição 1 ou 2 da sequência, que têm valor '1'
                fib = 1;
            else
                // Executar operação recursiva até obter número correto
                fib = Fibonacci(n - 2) + Fibonacci(n - 1);

            // Retornar valor correspondente ao índice dado
            return fib;
        }
    }
}
