using System;

namespace Animais
{
    public class Gato : Animal, IMamifero
    {
        public int NumeroDeMamilos { get => 6; }
      
        public override string Som()
        {
            return base.Som() + "Miau";
        }
    }  
}