using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            int linha;
            string sLinha;
            bool exit = false;


            // Ciclo DO-WHILE executa enquanto condição de fim não se verificar
            do
            {
                // Mensagem introdutória
                Console.Write("Insere nº de linhas para fazer uma pirâmide: ");

                // Receber input do utilizador e converter em INT
                sLinha = Console.ReadLine();

                // Verificar se input do utilizador pede para terminar programa
                if (sLinha == "EXIT")
                    exit = true;
                // Executar o programa normalmente caso não existam condições
                // para terminar a execução
                else 
                {
                    // Converter input do utilizador em INT
                    linha = Convert.ToInt32(sLinha);

                    Console.WriteLine();
    
                    // Ciclo FOR para desenhar a pirâmide
                    for (int i = 1; i <= linha; i++)
                    {
                        // Ciclo FOR para imprimir espaços antes de asteriscos
                        for (int j = 1; j <= linha - i; j++)
                            Console.Write(" ");
                        // Ciclo FOR para imprimir asteriscos
                        for (int k = 1; k <= 2 * i - 1; k++)
                            Console.Write("*");
                        // Mudar para a próxima linha
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }
            }
            while (!exit);
        }
    }
}
