namespace BCPropriedades
{
    public class Bola
    {
        // Cor da instância de Bola
        public Cor Cor { get; }

        // Raio da instância de Bola
        public float Raio { get; private set; }

        // Nº de vezes que instância de Bola é atirada
        public int VezesAtirada { get; private set; }

        // BOOL para determinar se instância de Bola rebentou
        private bool rebentou;

        // Construtor que inicializa uma nova bola com
        // cor e raio dados
        public Bola(Cor cor, float raio)
        {
            Cor = cor;
            Raio = raio;
        }

        // Rebentar a bola, metendo o seu raio a 0
        public void Pop()
        {
            Raio = 0;
            rebentou = true;
        }

        // Atirar a bola uma vez, se não estiver rebentada
        public void Atirar()
        {
            if (!rebentou)
                VezesAtirada++;
        }
    }
}