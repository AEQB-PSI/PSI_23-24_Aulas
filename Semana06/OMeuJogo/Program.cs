using System;

namespace OMeuJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variável para guardar número de inimigos
            int numInimigos;
            
            // Array para guardar instâncias de Inimigo
            Inimigo[] inimigos;

            // Pedir número de inimigos ao utilizador
            Console.Write("Insere o número de inimigos: ");
            
            // Guardar input do utilizador na variável correspondente
            numInimigos = Convert.ToInt32(Console.ReadLine());
            
            // Definir tamanho do array com número de inimigos
            inimigos = new Inimigo[numInimigos];
            
            // Ciclo FOR para percorrer cada inimigo
            for (int i = 0; i < numInimigos; i++)
            {
                // Variável para guardar nome de cada inimigo
                string nomeInimigo;
                
                // Pedir nome do inimigo atual ao utilizador
                Console.Write($"Nome para inimigo {i + 1}: ");
                
                // Guardar input do utilizador na variável do nome
                nomeInimigo = Console.ReadLine();
                
                // Inicializar inimigo com nome dado
                Inimigo novoInimigo = new Inimigo(nomeInimigo);
                
                // Guardar instância de inimigo no array
                inimigos[i] = novoInimigo;
            }

            // Listar inimigos
            Console.WriteLine("Lista de inimigos:");
            
            // Ciclo FOR para cada instância no array
            for (int i = 0; i < inimigos.Length; i++)
            {        
                // Imprimir nome do inimigo atual
                Console.WriteLine($"\tInimigo {i + 1}");
                Console.WriteLine($"\t\tNome: {inimigos[i].GetNome()}");
            }
        }
    }
}
