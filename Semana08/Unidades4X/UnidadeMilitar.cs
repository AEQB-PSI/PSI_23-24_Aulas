using System;

namespace Unidades4X
{
    public class UnidadeMilitar : Unidade
    {
        // Propriedades
        public override int Vida { get => base.Vida + XP; }
        public int PoderAtaque { get; set; }
        public int XP { get; set; }
        public override float Valor { get => PoderAtaque + XP; }

        // Construtor
        public UnidadeMilitar(int mov, int vida, int pa) : base(mov, vida)
        {
            PoderAtaque = pa;
            XP = 0;
        }

        // Método
        public void Atacar(Unidade u)
        {
            Console.WriteLine($"Unidade atacou {u} com dano {PoderAtaque}");
        }

        public override string ToString() 
        {
            return base.ToString() + $"\n\tUnidade tem {PoderAtaque} de poder de ataque e {XP} de XP";
        }
    }
}