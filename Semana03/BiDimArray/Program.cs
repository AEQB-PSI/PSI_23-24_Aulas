using System;

namespace BiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array bidimensional de floats
            float[,] biDim;
            
            // Variáveis para guardar dimensões do array
            int h, v;
            
            // Variáveis para guardar valor médio e soma das médias
            float soma = 0;
            float[] media;
            
            // Pedir dimensões horizontais ao utilizador e converter
            Console.Write("Dimensões horizontais do array: ");
            h = Convert.ToInt32(Console.ReadLine());
            
            // Pedir dimensões verticais ao utilizador e converter
            Console.Write("Dimensões verticais do array: ");
            v = Convert.ToInt32(Console.ReadLine());
            
            // Definir dimensões dos arrays com base no input do utilizador
            biDim = new float[v, h];
            media = new float[v];
            
            // Percorrer cada linha do array bidimensional de floats
            for (int i = 0; i < biDim.GetLength(0); i++)
            {
                // Pedir e guardar valor para cada posição
                for (int j = 0; j < biDim.GetLength(1); j++)
                {
                    Console.Write($"Float para a posição {i}, {j} do array: ");
                    biDim[i, j] = Convert.ToSingle(Console.ReadLine());
                    
                    // Adicionar valor de posição atual à soma
                    soma += biDim[i, j];
                }

                // Guardar valor da média na posição correspondente
                media[i] = soma / h;

                // Reiniciar variável auxiliar da soma
                soma = 0;
            }

            // Percorrer cada linha do array de médias
            for (int i = 0; i < media.Length; i++)
            {
                // Imprimir média da linha atual
                Console.WriteLine($"Média da linha {i}: {media[i]}");

                // Adicionar média da linha atual ao valor da soma
                soma += media[i];
            }

            // Imprimir soma de todas as médias
            Console.WriteLine($"Soma de todas as médias: {soma}");
        }
    }
}
