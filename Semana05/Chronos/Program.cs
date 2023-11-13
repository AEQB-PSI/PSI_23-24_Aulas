using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar e instanciar 2 cronómetros
            Stopwatch cron1 = new Stopwatch(), cron2 = new Stopwatch();

            // Iniciar contagem de tempo em cron1
            cron1.Start();

            // Pausar programa durante 1 segundo
            Thread.Sleep(1000);

            // Iniciar contagem de tempo em cron2
            cron2.Start();

            // Pausar programa durante 1 segundo
            Thread.Sleep(1000);

            // Parar contagem de tempo em ambos os cronómetros
            cron1.Stop();
            cron2.Stop();

            // Imprimir contagem de tempo em cada cronómetro, em milissegundos
            Console.WriteLine(
                $"Cronómetro 1 : {cron1.ElapsedMilliseconds} milissegundos"
            );
            Console.WriteLine(
                $"Cronómetro 2 : {cron2.ElapsedMilliseconds} milissegundos"
            );
        }
    }
}
