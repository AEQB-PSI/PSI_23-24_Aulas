using System;

namespace Unidades4X
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar instâncias de cada subclasse
            Unidade u1 = new UnidadeMilitar(5, 100, 20);
            Unidade u2 = new UnidadeColonizadora(7, 80);

            // Mover ambas as instâncias
            u1.Mover();
            u2.Mover();

            Console.WriteLine();

            // Imprimir Vida e Valor de cada instância, com recurso ao método ToString()
            Console.WriteLine("Unidade 1:");
            Console.WriteLine(u1);
            Console.WriteLine();
            Console.WriteLine("Unidade 2:");
            Console.WriteLine(u2);
        }
    }
}
