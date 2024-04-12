using System;

namespace Animais
{
    public class Morcego : Animal, IMamifero, IVoador
    {
        public int NumeroDeMamilos { get => 2; }
        public int NumeroDeAsas { get => 2; }
      
        public override string Som()
        {
            return base.Som() + "Screech!";
        }
    }  
}