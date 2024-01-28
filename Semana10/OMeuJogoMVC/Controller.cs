using System;

namespace OMeuJogoMVC
{  
    class Controller
    {
        // Referência à vista
        private View view;

        // Referência ao modelo
        private Inimigo[] inimigos;

        // Instância da classe Random
        private Random r = new Random();

        // Construtor
        public Controller(Inimigo[] inimigos)
        {
            this.inimigos = inimigos;
        }

        // Método para iniciar o programa
        public void Iniciar(View view)
        {  
            // Guardar referência à vista
            this.view = view;

            // Inicializar array de inimigos com tamanho retornado pela vista
            inimigos = new Inimigo[view.DefinirNumInimigos()];

            // Ciclo FOR para percorrer cada inimigo
            for (int i = 0; i < inimigos.Length; i++)
            {    
                // Inicializar inimigo atual com nome retornado pela vista
                Inimigo novoInimigo = new Inimigo(view.DefinirNomeInimigo(i));
                
                // Guardar instância de inimigo no array
                inimigos[i] = novoInimigo;

                // Danificar inimigo com valor aleatório
                float dano = r.Next(1, 200);
                inimigos[i].Danificar(dano);

                // Pedir à vista para mostrar dano aplicado ao inimigo atual
                view.MostrarDano(i, dano);
            }

            // Imprimir linha vazia
            view.ImprimirMensagem("");

            // Imprimir mensagem
            view.ImprimirMensagem("Lista de inimigos:");
  
            // Ciclo FOR para cada instância no array
            for (int i = 0; i < inimigos.Length; i++)
            {  
                // Pedir à vista para imprimir nome, vida e escudo do inimigo atual
                view.ListarInimigos(i, inimigos);
            }

            // Ciclo para abastecer vida e escudo de cada inimigo 
            // com valores aleatórios
            for (int i = 0; i < inimigos.Length; i++)
            {
                // Variáveis para guardar valores aleatórios para abastecimento
                // de vida e escudo
                float abVida = r.Next(1, 50), abEscudo = r.Next(1, 50);

                // Abastecer vida e escudo do inimigo atual
                inimigos[i].Abastecer(Abastecimento.Vida, abVida);
                inimigos[i].Abastecer(Abastecimento.Escudo, abEscudo);

                // Pedir à vista para imprimir vida e escudo abastecidos do inimigo atual
                view.MostrarAbastecimento(i, abVida, abEscudo);
            }

            // Imprimir mensagem
            view.ImprimirMensagem("Lista de inimigos:");

            // Ciclo FOR para cada instância no array
            for (int i = 0; i < inimigos.Length; i++)
            {  
                // Imprimir nome, vida e escudo do inimigo atual
                view.ListarInimigos(i, inimigos);
            }

            // Pedir à vista para imprimir número total de abastecimentos no decorrer do programa
            view.ImprimirNumAbastecimentos();
        }
    }
}