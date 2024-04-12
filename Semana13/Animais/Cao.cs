using System;

namespace Animais
{
    public class Cao : Animal, IMamifero
    {
        public int NumeroDeMamilos { get => 8; }
      
        public override string Som()
        {
            return base.Som() + "Woof!";
        }
    }  
}