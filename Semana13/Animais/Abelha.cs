using System;

namespace Animais
{
    public class Abelha : Animal, IVoador
    {
        public int NumeroDeAsas { get => 4; }
      
        public override string Som()
        {
            return base.Som() + "Bzzzzz";
        }
    }  
}