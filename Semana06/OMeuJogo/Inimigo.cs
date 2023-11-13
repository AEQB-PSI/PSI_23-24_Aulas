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

        // Método que retorna nome da instância
        public string GetNome()
        {
            return nome;
        }

        // Método para danificar instância com valor dado
        public void Danificar(float dano)
        {
            vida -= dano;
            if (vida < 0) vida = 0;
        }
    }
}