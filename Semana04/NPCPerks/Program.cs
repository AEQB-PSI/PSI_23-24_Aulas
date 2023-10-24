using System;

namespace NPCPerks
{
    class Program
    {
        /// <summary>
        /// Método para definir número de NPCs, definir características
        /// de cada um, e por fim, imprimir essas características.
        /// </summary>
        private static void Main()
        {
            // Variável para guardar número de NPCs
            int numNPCs;
            
            // Variáveis para guardar características de cada NPC
            Classes[] npcClasses;
            Perks[] npcPerks;
            
            // Pedir número de NPCs
            Console.Write("Indica o número de NPCs: ");
            numNPCs = int.Parse(Console.ReadLine());
            
            // Inicializar array de NPCs
            npcClasses = new Classes[numNPCs];
            npcPerks = new Perks[numNPCs];

            Console.WriteLine();
            
            // Ciclo FOR para pedir características de cada NPC
            for (int i = 0; i < numNPCs; i++)
            {
                // Ciclo FOR para percorrer as classes não especiais
                for (int j = 0; j < Enum.GetNames(typeof(Classes)).Length - 2; j++)
                {   
                    // Definir classe de NPC atual
                    npcClasses[i] = LerClasse((Classes) j, i);
                    
                    // Verificar se já foi definida classe
                    if (npcClasses[i] != (Classes)(-1))
                    { 
                        // Definir características do NPC e passar ao NPC seguinte
                        // ou terminar ciclo
                        npcPerks[i] = DeterminarPerk(npcClasses[i]);
                        break;
                    }
                }
                Console.WriteLine();
            }
            
            // Ciclo FOR para categorizar cada NPC
            for (int i = 0; i < numNPCs; i++)
            {
                Console.WriteLine($"NPC {i + 1}");
            
                // Mostrar classe de NPC atual no ecrã
                Console.WriteLine($"\t Classe: {npcClasses[i]}");

                // Mostrar características de NPC atual no ecrã
                Console.WriteLine($"\t Características: {npcPerks[i]}");

                // Verificar se NPC tem classe especial
                if (npcClasses[i] == Classes.Lord)
                {
                    // Imprimir mensagem especial
                    Console.WriteLine("\t Irás vencer todas as batalhas!");
                }
                    
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Método para definir classe de um NPC.
        /// </summary>
        /// <param name="classe"> A classe atualmente em seleção </param>
        /// <param name="i"> Índice correspondente ao NPC atual </param>
        /// <returns> A classe selecionada </returns>
        private static Classes LerClasse(Classes classe, int i)
        { 
            // Variável que irá guardar input do utilizador
            string input;

            // Variável que irá guardar classe selecionada
            Classes classeSel = (Classes)(-1);

            // Perguntar se NPC tem classe atualmente selecionada
            Console.Write($"NPC {i + 1} tem classe {(Classes) classe}? (s/n): ");
            input = Console.ReadLine();

            // Verificar se utilizador confirmou classe
            if (input == "s")
            {
                // Definir classe
                classeSel = classe;
            }
            // Verificar se utilizador pediu classe especial
            else if (input == "ESPECIAL")
            {
                // Definir classe especial
                classeSel = Classes.Lord;
            }

            // Devolver classe selecionada
            return classeSel;
        }

        /// <summary>
        /// Método para determinar características de um NPC.
        /// </summary>
        /// <param name="classe"> A classe do NPC atual </param>
        /// <returns> 
        /// As características correspondentes à classe do NPC atual.
        /// </returns>
        private static Perks DeterminarPerk(Classes classe)
        {
            // Variável para guardar conjunto de perks especiais
            Perks especial = Perks.Combat | Perks.Luck | Perks.Intelligence;

            // Variável que irá guardar características selecionadas
            Perks perkSel = 0;

            // Ciclo para percorrer classes e determinar características
            switch ((Classes) classe)
            {
                case (Classes) 0:
                    perkSel = Perks.Combat | Perks.Luck;
                    break;
                case (Classes) 1:
                    perkSel = Perks.Lockpick | Perks.Combat;
                    break;
                case (Classes) 2:
                    perkSel |= Perks.Intelligence;
                    break;
                case (Classes) 3:
                    perkSel |= Perks.Combat;
                    break;
                case (Classes) 4:
                    perkSel |= Perks.Lockpick;
                    break;
                case (Classes) 5:
                    perkSel |= Perks.Luck;
                    break;
                case (Classes) 6:
                    perkSel |= Perks.None;
                    break;
                case (Classes) 7:
                    perkSel |= Perks.Stealth;
                    break;
                case (Classes) 8:
                    perkSel = Perks.Luck | Perks.Intelligence;
                    break;
                case (Classes) 9:
                    perkSel = Perks.Stealth | Perks.Combat;
                    break;
                case (Classes) 10:
                    perkSel |= especial;
                    break;
            }

            // Devolver características correspondentes à classe do NPC atual
            return perkSel;
        }
    }
}