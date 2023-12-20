using System;

namespace Unidades4X
{
    public abstract class Unidade
    {
        // Variável de instância
        private int movimento;

        // Propriedades
        public virtual int Vida { get; set; }
        public abstract float Valor { get; }

        // Construtor
        public Unidade(int movimento, int vida)
        {
            this.movimento = movimento;
            Vida = vida;
        }

        // Método
        public void Mover()
        {
            Console.WriteLine($"Uma unidade andou {movimento} blocos");
        }

        public override string ToString() 
        {
            return $"\tUnidade tem {Vida} de vida e {Valor} de valor";
        }
    }
}