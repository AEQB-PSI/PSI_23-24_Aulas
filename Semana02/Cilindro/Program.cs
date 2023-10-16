using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis para guardar todos os valores
            string sAltura, sRaio;
            double altura, raio, volume, area;

            Console.WriteLine("Insere a altura e o raio de um cilindro:");

            // Guarda input do utilizador em strings
            sAltura = Console.ReadLine();
            sRaio = Console.ReadLine();

            // Converte strings em floats
            altura = double.Parse(sAltura);
            raio = double.Parse(sRaio);

            // Calcula volume e área de superfície
            volume = Math.PI * (Math.Pow(raio, 2)) * altura;
            area = 2 * Math.PI * raio * (raio + altura);

            // Imprime valores do volume e área do cilindro
            Console.WriteLine();
            Console.Write($"Cilindro com {altura} altura e {raio} raio tem:\n");
            Console.Write($"Volume: {volume}\n");
            Console.Write($"Área de superfície; {area}");
        }
    }
}
