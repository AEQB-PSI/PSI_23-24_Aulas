using System;

namespace Unidades4X
{
    public class UnidadeMilitar : Unidade
    {
        public int PoderAtaque { get; set; }
        public int XP { get; set; }

        public UnidadeMilitar(int mov, int vida, int pa) : base(mov, vida)
        {
            PoderAtaque = pa;
            XP = 0;
        }

        public void Atacar(Unidade u)
        {
            Console.WriteLine($"Unidade atacou {u} com dano {PoderAtaque}");
        }
    }
}