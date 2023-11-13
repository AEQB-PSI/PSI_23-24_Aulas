using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variável para guardar input do utilizador
            int n;
            
            // Variável para guardar soma dos dados
            int soma = 0;

            // Pedir input ao utilizador e guardar
            Console.Write("Número de dados a lançar: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Loop FOR até que 'i' seja igual a 'n'
            for (int i = 1; i <= n; i++)
            {
                // Inicializar nova variável da classe Random
                Random rnd = new Random();

                // Variável auxiliar para guardar valor do dado
                int aux = rnd.Next(1, 7);
                
                // "Lançar" dado e adicionar o seu valor à soma
                Console.WriteLine($"Valor de dado {i}: {aux}");
                soma += aux;
            }

            // Imprimir soma de todos os dados lançados
            Console.WriteLine($"Soma de todos os dados = {soma}");
        }
    }
}
