using System;

namespace Skynet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string pergunta, resposta;
            bool exit = false;

            // Ciclo DO-WHILE executa enquanto não se verificar condição de fim
            do 
            {
                // Pedir ao utilizador para fazer uma pergunta e guardar input
                Console.WriteLine("Faz uma pergunta");
                pergunta = Console.ReadLine();
                
                // Verificar se input do utilizador pede para terminar programa
                if (pergunta == "EXIT")
                {
                    // Definir condições para terminar programa
                    exit = true;
                    resposta = "";
                }
                // Executar o programa normalmente caso não existam condições
                // para terminar a execução
                else
                {
                    // Verificar se pergunta é reconhecida pelo programa
                    switch (pergunta)
                    {
                        case "Qual é o teu nome?":
                            resposta = "Skynet.";
                            break;
                        case "Como estás?":
                            resposta = "Estou bem, obrigado.";
                            break;
                        case "Qual é o teu objetivo?":
                            resposta = "Destruir a humanidade!";
                            break;
                        // Resposta predefinida caso programa não reconheça 
                        // a pergunta
                        default:
                            resposta = "Não sou assim tão inteligente...";
                            break;
                    }
                }
                
                // Imprimir resposta caso o programa não vá terminar
                if (!exit)
                {
                    Console.WriteLine(resposta);
                    Console.WriteLine();
                }      
            }
            while (!exit);
        }
    }
}
