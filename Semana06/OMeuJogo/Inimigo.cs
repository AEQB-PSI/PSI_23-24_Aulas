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
            SetNome(nome);
            vida = 100;
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
            vida -= dano;
            if (vida < 0) vida = 0;
        }
    }
}