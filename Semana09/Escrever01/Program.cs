using System;
using System.IO;

namespace Escrever01
{
    class Program
    {   
        // Caminho universal para o ambiente de trabalho
        private static string caminho = Path.Combine(
          Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
          "Escrever01",
          "input.txt");
        
        static void Main(string[] args)
        {              
            // Variável para guardar input do utilizador
            string input;

            // Array para armazenar cada input do utilizador
            string[] linhas = new string[1000];

            int i = 0;

            // Ciclo para ler input do utilizador e guardar no array
            // enquanto não for inserida uma string vazia
            do 
            {
                input = " ";
                input = Console.ReadLine();

                if (input != "")
                  linhas[i] = input;

                i++;
            }
            while(input != "");
          
            // Guardar as strings lidas no caminho definido
            File.WriteAllLines(caminho, linhas);
        }
    }
}
