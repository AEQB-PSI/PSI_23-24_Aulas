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
            if(pergunta == "Qual é o teu nome?")
            {
                resposta = "Skynet.";
            }
            else if (pergunta == "Como estás?")
            {
                resposta = "Estou bem, obrigado.";
            }
            else if (pergunta == "Qual é o teu objetivo?")
            {
                resposta = "Destruir a humanidade!";
            }
            // Resposta predefenida caso pergunta não seja reconhecida
            else 
            {
                resposta = "Não sou assim tão inteligente...";
            }

            // Imprimir resposta
            Console.WriteLine(resposta);
        }
    }
}
