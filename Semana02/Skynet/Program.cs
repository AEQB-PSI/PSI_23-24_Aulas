using System;

namespace Skynet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string pergunta, resposta;

            // Pedir ao utilizador para fazer uma pergunta e guardar input
            Console.WriteLine("Faz uma pergunta");
            pergunta = Console.ReadLine();

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
                // Resposta predefinida caso programa não reconheça a pergunta
                default:
                    resposta = "Não sou assim tão inteligente...";
                    break;
            }

            // Imprimir resposta
            Console.WriteLine(resposta);
        }
    }
}
