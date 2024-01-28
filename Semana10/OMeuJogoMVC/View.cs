using System;

namespace OMeuJogoMVC
{
    class View
    {  
        // Referência ao controlador
        private Controller controller;

        // Construtor
        public View(Controller controller)
        {
            this.controller = controller;
        }

        // Método para imprimir mensagem genérica
        public void ImprimirMensagem(string msg)
        {
            Console.WriteLine(msg);
        }

        // Método para pedir número de inimigos e retornar valor ao controlador
        public int DefinirNumInimigos()
        {
            // Pedir número de inimigos ao utilizador
            Console.Write("Insere o número de inimigos: ");

            // Retornar input do utilizador
            return Convert.ToInt32(Console.ReadLine());
        }

        // Método para pedir nome de inimigo e retornar valor ao controlador
        public string DefinirNomeInimigo(int i)
        {
            // Pedir nome do inimigo atual ao utilizador
            Console.Write($"Nome para inimigo {i + 1}: ");

            // Retornar input do utilizador
            return Console.ReadLine();
        }

        // Método para imprimir dano aplicado a inimigo atual
        public void MostrarDano(int i, float dano)
        {
            Console.WriteLine($"Dano aplicado a inimigo {i + 1}: {dano}");
        }

        // Método para listar número, nome, escudo e vida de um inimigo
        public void ListarInimigos(int i, Inimigo[] inimigos)
        {
            Console.WriteLine($"\tInimigo {i + 1}");
            Console.WriteLine($"\t\tNome: {inimigos[i].GetNome()}");
            Console.WriteLine($"\t\tEscudo: {inimigos[i].GetEscudo()}");
            Console.WriteLine($"\t\tVida: {inimigos[i].GetVida()}\n");
        }

        // Método para imprimir vida e escudo abastecidos de um inimigo
        public void MostrarAbastecimento(int i, float valorVida, float valorEscudo)
        {
            Console.WriteLine($"Vida abastecida a inimigo {i + 1}: {valorVida}");
            Console.WriteLine($"Escudo abastecido a inimigo {i + 1}: {valorEscudo}\n");
        }

        // Método para imprimir número total de abastecimentos no decorrer do programa
        public void ImprimirNumAbastecimentos()
        {
            // Imprimir número total de abastecimentos no decorrer do programa
            Console.WriteLine(
                $"Número total de abastecimentos: {Inimigo.GetNumAbast()}");
        }
    }
}