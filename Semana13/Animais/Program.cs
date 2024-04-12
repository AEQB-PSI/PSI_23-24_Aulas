using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Animal[] animais = new Animal[10];

            for (int i = 0; i < animais.Length; i++)
            {
                int valor = random.Next(0, 4);

                switch (valor)
                {
                    case 0:
                        animais[i] = new Cao();
                        break;
                    case 1:
                        animais[i] = new Gato();
                        break;
                    case 2:
                        animais[i] = new Morcego();
                        break;
                    case 3:
                        animais[i] = new Abelha();
                        break;
                }

                Console.WriteLine($"Animal {i + 1}: {animais[i].Som()}");
    
                if (animais[i] is IMamifero)
                {
                    // Converter explicitamente objeto do tipo Animal num objeto do tipo IMamifero
                    Console.WriteLine($"--- tem {((IMamifero)animais[i]).NumeroDeMamilos} mamilos");
                }
    
                if (animais[i] is IVoador)
                {
                    // Converter explicitamente objeto do tipo Animal num objeto do tipo IVoador
                    Console.WriteLine($"--- tem {((IVoador)animais[i]).NumeroDeAsas} asas");
                }

            }
        }
    }
}
