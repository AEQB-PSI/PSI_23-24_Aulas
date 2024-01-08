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
          catch (FormatException)
          {
            Console.WriteLine("Valor inserido não está no formato correto");
          }
          catch (OverflowException)
          {
            Console.WriteLine("Valor inserido é demasiado grande ou pequeno");
          }
          catch (Exception)
          {
            Console.WriteLine("Ocorreu um erro desconhecido");
          }
          
          Console.WriteLine($"Número inserido: {i}");
        }
    }
}
