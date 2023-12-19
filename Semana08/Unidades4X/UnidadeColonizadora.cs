using System;

namespace Unidades4X
{
    public class UnidadeColonizadora : Unidade 
    {  
        // Propriedade
        public override float Valor { get => 5; }

        // Construtor
        public UnidadeColonizadora(int mov, int vida) : base(mov, vida) {}

        // Método
        public void Colonizar()
        {
            Console.WriteLine("Unidade colonizou bloco atual");
        }
    }
}