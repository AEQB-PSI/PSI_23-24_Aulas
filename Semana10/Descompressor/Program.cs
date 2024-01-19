using System;
using System.IO;
using System.IO.Compression;

namespace Descompressor
{
    class Program
    {
        // Caminho para ficheiro na pasta especial ambiente de trabalho
        private static string ficheiro = Path.Combine(
          Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
          "ficheiro.txt");

        private static void Main(string[] args)
        {
            // Variável para guardar input do utilizador
            string input;

            // Pedir e ler input do utilizador
            Console.WriteLine("(C)omprimir ou (D)escomprimir?");
            input = Console.ReadLine().ToLower();

            // Verificar o que o utilizador selecionou
            switch (input)
            {
                case "c":
                    Comprime();
                    break;
                case "d":
                    Descomprime();
                    break;
                default:
                    Console.WriteLine("Seleção inválida.");
                    break;
            }
        }

        private static void Comprime()
        {
            // String para guardar cada linha que o utilizador escreve
            string linha;

            // Instância de FileStream para aceder a ficheiro no caminho especificado,
            // criando o mesmo em modo de escrita
            FileStream fs = new FileStream(ficheiro + ".gz", FileMode.Create, FileAccess.Write);

            // Instância de GZipStream para decorar o ficheiro com um compressor
            // para o formato GZip
            GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);

            // Instância de StreamWriter para adaptar o compressor para escrita
            // em modo de texto
            StreamWriter sw = new StreamWriter(gzs);

            // Ciclo para ler input do utilizador e escrever no ficheiro
            // enquanto não for inserida uma string vazia
            while ((linha = Console.ReadLine()).Length > 0)
            {
                sw.WriteLine(linha);
            }

            // Fechar ficheiro
            sw.Close();
        }

        private static void Descomprime()
        {
            // String para guardar cada linha que o utilizador escreve
            string linha;

            // Instância de FileStream para aceder a ficheiro no caminho especificado,
            // abrindo o mesmo em modo de leitura
            FileStream fs = new FileStream(ficheiro + ".gz", FileMode.Open, FileAccess.Read);

            // Instância de GZipStream para decorar o ficheiro com um descompressor
            GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress);

            // Instância de StreamReader para adaptar o descompressor para leitura
            // em modo de texto
            StreamReader sr = new StreamReader(gzs);

            // Instância de StreamWriter para escrever no novo ficheiro de texto
            StreamWriter sw = new StreamWriter(ficheiro);

            // Ciclo para ler linhas do ficheiro e escrever na consola
            // até chegar à última linha do ficheiro
            while ((linha = sr.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }

            // Fechar ficheiros
            sr.Close();
            sw.Close();
        }
    }
}
