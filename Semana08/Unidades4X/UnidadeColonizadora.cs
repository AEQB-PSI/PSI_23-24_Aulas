using System;

namespace Unidades4X
{
    public class UnidadeColonizadora : Unidade 
    {
        public UnidadeColonizadora(int mov, int vida) : base(mov, vida) {}

        public void Colonizar()
        {
            Console.WriteLine("Unidade colonizou bloco atual");
        }
    }
}