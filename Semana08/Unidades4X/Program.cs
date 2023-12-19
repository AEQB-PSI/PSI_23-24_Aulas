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

              // Imprimir Vida e Valor de cada instância
              Console.WriteLine($"Vida de unidade 1: {u1.Vida}");
              Console.WriteLine($"Valor de unidade 1: {u1.Valor}");
              Console.WriteLine($"Vida de unidade 2: {u2.Vida}");
              Console.WriteLine($"Valor de unidade 2: {u2.Valor}");
        }
    }
}
