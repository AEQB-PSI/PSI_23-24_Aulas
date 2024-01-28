using System;

namespace OMeuJogoMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modelo representado por um array de objetos da classe Inimigo
            Inimigo[] inimigos = new Inimigo[0];

            // Controlador com referência ao modelo
            Controller controller = new Controller(inimigos);

            // Vista com referência ao controlador
            View view = new View(controller);

            // Iniciar o programa
            controller.Iniciar(view);
        }
    }
}
