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

            // Nova instância da classe Random
            Random r = new Random();

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

                // Danificar inimigo com valor aleatório
                float dano = r.Next(1, 200);
                Console.WriteLine($"Dano aplicado a inimigo {i + 1}: {dano}");
                inimigos[i].Danificar(dano);
            }

            Console.WriteLine();

            // Listar inimigos
            Console.WriteLine("Lista de inimigos:");
            
            // Ciclo FOR para cada instância no array
            for (int i = 0; i < inimigos.Length; i++)
            {        
                // Imprimir nome, vida e escudo do inimigo atual
                Console.WriteLine($"\tInimigo {i + 1}");
                Console.WriteLine($"\t\tNome: {inimigos[i].GetNome()}");
                Console.WriteLine($"\t\tEscudo: {inimigos[i].GetEscudo()}");
                Console.WriteLine($"\t\tVida: {inimigos[i].GetVida()}\n");
            }

            // Ciclo para abastecer vida e escudo de cada inimigo 
            // com valores aleatórios
            for (int i = 0; i < inimigos.Length; i++)
            {
                // Variáveis para guardar valores aleatórios para abastecimento
                // de vida e escudo
                float abVida = r.Next(1, 50), abEscudo = r.Next(1, 50);

                // Abastecer vida e escudo do inimigo atual
                inimigos[i].Abastecer(Abastecimento.Vida, abVida);
                Console.WriteLine(
                    $"Vida abastecida a inimigo {i + 1}: {abVida}");
                inimigos[i].Abastecer(Abastecimento.Escudo, abEscudo);
                Console.WriteLine(
                    $"Escudo abastecida a inimigo {i + 1}: {abEscudo}\n");
            }

             // Listar inimigos novamente
            Console.WriteLine("Lista de inimigos:");
            
            // Ciclo FOR para cada instância no array
            for (int i = 0; i < inimigos.Length; i++)
            {        
                // Imprimir nome, vida e escudo abastecidos do inimigo atual
                Console.WriteLine($"\tInimigo {i + 1}");
                Console.WriteLine($"\t\tNome: {inimigos[i].GetNome()}");
                Console.WriteLine($"\t\tEscudo: {inimigos[i].GetEscudo()}");
                Console.WriteLine($"\t\tVida: {inimigos[i].GetVida()}");
            }
        }
    }
}
