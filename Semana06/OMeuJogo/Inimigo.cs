using System;

namespace OMeuJogo
{
    public class Inimigo
    {
        // Variáveis de instância
        private string nome;
        private float vida;

        // Construtor com definição do nome da instância
        public Inimigo(string nome)
        {
            this.nome = nome;
            vida = 100;
        }
    }
}