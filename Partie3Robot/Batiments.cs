using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class Batiments
    {
        public static int IdBatiment = 1;

        public int NumeroBatiment { get; set; }
        public string StatutBatiment { get; set; }
        public int QuantiteRessources { get; set; }
        public int Priorite { get; set; }


        public Batiments()
        {
            QuantiteRessources = 0;
            StatutBatiment = "";
            NumeroBatiment = IdBatiment;
            IdBatiment++;
            Priorite = 0;
        }
        public Batiments(string statutBatiment, int quantiteRessources)
        {
            StatutBatiment = statutBatiment;
            QuantiteRessources = quantiteRessources;
            NumeroBatiment = IdBatiment;
            IdBatiment++;
            Priorite = 0;
        }

       
    }
}
