using System;
using System.IO;

namespace Exercicio2
{
    class Program
    {
        // Nomes dos ficheiros
        private const string ficheiroTexto = "dados.txt";
        private const string ficheiroBinario = "dados.bin";

        // Dados a escrever e ler nos ficheiros
        private const string dadosString = "Hello world!";
        private const int dadosInt = 17;
        private const float dadosFloat = 3.1415f;
      
        static void Main(string[] args)
        {
            // String para guardar opção inserida pelo utilizador
            string input;

            // Ciclo para ler opção do utilizador
            do
            {
                // Menu principal
                Console.WriteLine("Programas:");
                Console.WriteLine("\t1 - Escrever dados em ficheiro texto");
                 Console.WriteLine("\t2 - Ler dados de ficheiro texto");
                Console.WriteLine("\t3 - Escrever dados em ficheiro binário");
                Console.WriteLine("\t4 - Ler dados de ficheiro binário");
                Console.WriteLine("\t5 - Sair");

                // Ler input do utilizador
                input = Console.ReadLine();

                // Verificar opção inserida
                switch (input)
                {
                    case "1":
                        EscreverTexto();
                        break;
                    case "2":
                        LerTexto();
                        break;
                    case "3":
                        EscreverBin();
                        break;
                    case "4":
                        LerBin();
                        break;
                    case "5":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                // Esperar que utilizador pressione algum botão para repetir ciclo
                Console.WriteLine("Pressiona qualquer tecla para continuar...");
                Console.ReadKey();
            } 
            while (input != "5");
        }

        private static void EscreverTexto()
        {
            // Instância de TextWriter para escrever dados no ficheiro
            TextWriter sw = File.CreateText(ficheiroTexto);
          
            // Escrever dados no ficheiro
            sw.WriteLine(dadosString);
            sw.WriteLine(dadosInt);
            sw.WriteLine(dadosFloat);
          
            // Fechar ficheiro
            sw.Close();
        }

        private static void LerTexto()
        {
            // Instância de TextReader para ler dados do ficheiro
            TextReader sr = File.OpenText(ficheiroTexto);

            // Ler dados do ficheiro
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());

            // Fechar ficheiro
            sr.Close();
        }

        private static void EscreverBin()
        {
            // Instância de BinaryWriter para escrever dados no ficheiro
            BinaryWriter bw = new BinaryWriter(File.Create(ficheiroBinario));

            // Escrever dados no ficheiro
            bw.Write(dadosString);
            bw.Write(dadosInt);
            bw.Write(dadosFloat);

            // Fechar ficheiro
            bw.Close();
        }

        private static void LerBin()
        {
            // Instância de BinaryReader para ler dados do ficheiro
            BinaryReader br = new BinaryReader(File.Open(ficheiroBinario, FileMode.Open));

            // Ler dados do ficheiro
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadSingle());

            // Fechar ficheiro
            br.Close();
        }
    }
}
