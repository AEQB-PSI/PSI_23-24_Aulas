using System;

namespace BCPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
          // Criar várias bolas
          Bola b1 = new Bola(new Cor(200, 0, 255), 10.5f);
          Bola b2 = new Bola(new Cor(147, 55, 0), 5.7f);
          Bola b3 = new Bola(new Cor(0, 120, 150), 19.1f);

          // Atirar cada bola algumas vezes
          b1.Atirar();
          b2.Atirar();
          b3.Atirar();
          b2.Atirar();
          b1.Atirar();
          b1.Atirar();

          // Rebentar algumas bolas
          b2.Pop();
          b1.Pop();

          // Tentar atirar as bolas outra vez
          b1.Atirar();
          b2.Atirar();
          b3.Atirar();

          // Imprimir estado de cada bola
          Console.WriteLine("Bola 1");
          Console.WriteLine("- Cor");
          Console.WriteLine($"-- R: {b1.Cor.Red}");
          Console.WriteLine($"-- G: {b1.Cor.Green}");
          Console.WriteLine($"-- B: {b1.Cor.Blue}");
          Console.WriteLine($"- Vezes atirada: {b1.VezesAtirada}");

          Console.WriteLine();

          Console.WriteLine("Bola 2");
          Console.WriteLine("- Cor");
          Console.WriteLine($"-- R: {b2.Cor.Red}");
          Console.WriteLine($"-- G: {b2.Cor.Green}");
          Console.WriteLine($"-- B: {b2.Cor.Blue}");
          Console.WriteLine($"- Vezes atirada: {b2.VezesAtirada}");

          Console.WriteLine();

          Console.WriteLine("Bola 3");
          Console.WriteLine("- Cor");
          Console.WriteLine($"-- R: {b3.Cor.Red}");
          Console.WriteLine($"-- G: {b3.Cor.Green}");
          Console.WriteLine($"-- B: {b3.Cor.Blue}");
          Console.WriteLine($"- Vezes atirada: {b3.VezesAtirada}");
        }
    }
}
