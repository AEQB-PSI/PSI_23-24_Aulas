using System;
using System.IO;

namespace Escrever02
{
    class Program
    {
        // Caminho universal para ficheiro no ambiente de trabalho
        private static string caminho = Path.Combine(
          Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
          "input.txt");

        static void Main(string[] args)
        {              
            // Variável para guardar input do utilizador
            string input;

            // Instância de StreamWriter para escrever no ficheiro
            StreamWriter sw = new StreamWriter(caminho);
          
            Console.Write("Escreve várias linhas de texto para guardar num ficheiro");
            Console.Write("\nPressiona a tecla ENTER quando quiseres terminar\n");

            // Ciclo para ler input do utilizador e escrever no ficheiro
            // enquanto não for inserida uma string vazia
            do 
            {
                input = Console.ReadLine();

                if (input != "")
                  sw.WriteLine(input);
            }
            while(input != "");

            // Fechar ficheiro
            sw.Close();
        }
    }
}
