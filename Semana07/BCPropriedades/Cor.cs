namespace BCPropriedades
{
    public class Cor
    {
        // Representação do estado  de uma instância de Cor
        public byte Red { get; set;}
        public byte Green { get; set;}
        public byte Blue { get; set;}
        public byte Alpha { get; set;}

        // Representação do grau de cinzento de uma instância de Cor
        public int Gray { get { return (Red + Green + Blue) / 3; } }

        // Construtor que aceita todos os parâmetros necessários para
        // inicializar o estado de uma Cor
        public Cor(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        // Construtor que aceita parâmetros RGB e define alpha com
        // o valor máximo
        public Cor(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = byte.MaxValue;
        }
    }
}