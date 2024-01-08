using System;

namespace TesteErros
{
    class Program
    {
        static void Main(string[] args)
        {
          int i = 0;
          
          Console.Write("Insere um número inteiro: ");
          
          try
          {
            // Código que pode lançar exceções
            i = Convert.ToInt32(Console.ReadLine());
          }
          catch (FormatException e)
          {
            // Código para tratar exceção
            Console.WriteLine("Ocorreu o seguinte problema: " + e.Message);
          }
          
          Console.WriteLine($"Número inserido: {i}");
        }
    }
}
