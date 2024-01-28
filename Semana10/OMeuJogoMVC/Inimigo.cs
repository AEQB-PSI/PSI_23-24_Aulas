using System;

namespace OMeuJogoMVC
{
    class Inimigo
    {
        // Variáveis de instância
        private string nome;
        private float vida;
        private float escudo;

        // Variável de classe
        private static int numAbast;

        // Construtor com definição do nome da instância
        public Inimigo(string nome)
        {
            SetNome(nome);
            vida = 100;
            escudo = 100;
        }

        // Construtor de classe
        static Inimigo()
        {
            numAbast = 0;
        }

        // Método que retorna nome da instância
        public string GetNome()
        {
            return nome;
        }

        // Método que retorna vida da instância
        public float GetVida()
        {
            if (vida < 50) vida = 50;
            return vida;
        }

        // Método que retorna escudo da instância
        public float GetEscudo()
        {
            return escudo;
        }

        // Método que retorna número de abastecimentos associados à classe
        public static int GetNumAbast()
        {
            return numAbast;
        }

        // Método que especifica novo nome para a instância
        public void SetNome(string novoNome)
        {
            // Retirar espaços do início e fim da string contendo o novo nome
            string trimNome = novoNome.Trim();
            this.nome = trimNome;
        }

        // Método para danificar instância com valor dado
        public void Danificar(float dano)
        {
            // Decrementar escudo com valor de dano
            escudo -= dano;

            // Verificar se valor de escudo é negativo depois de decrementar
            if (escudo < 0)
            {
                // Guardar dano residual
                float residual = -escudo;
                // Definir escudo a 0
                escudo = 0;
                // Decrementar vida com dano residual
                vida -= residual;
            }

            // Definir vida a 0 se valor for negativo depois de decrementar
            if (vida < 0) vida = 0;
        }

        // Método para abastecer vida ou escudo de instância com valor dado
        public void Abastecer(Abastecimento ab, float valor)
        {
            // Incrementar número de abastecimentos da classe
            numAbast++;

            // Se tipo de abastecimento for Vida
            if (ab == Abastecimento.Vida)
            {
                vida += valor;
                // Definir valor limite de vida
                if( vida > 100) vida = 100;
            }
            // Se tipo de abastecimento for Escudo
            if (ab == Abastecimento.Escudo)
            {
                escudo += valor;
                // Definir valor limite de escudo
                if (escudo > 100) escudo = 100;
            }
        }
    }
}