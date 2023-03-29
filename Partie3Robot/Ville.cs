using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class Ville
    {
        string nomVille;
        string addresseLine;
        Batiments[] batiments;

        public Ville()
        {
            nomVille = "";
            addresseLine = "";
            batiments = new Batiments[5];
        }
        public Ville(string nomVille, string addresseLine)
        {
            this.nomVille = nomVille;
            this.addresseLine = addresseLine;
            batiments = new Batiments[5];
        }

        public void AfficherInfoBatiment()
        {
            Console.WriteLine("------------------------------------------------------------------------- ");
            Console.WriteLine("DETAILS SUR L'ETAT DES BATIMENTS");
            Console.WriteLine("------------------------------------------------------------------------- \n");
            foreach (Batiments batiment in batiments)
            {
                Console.WriteLine($"Numero du Batiment {batiment.NumeroBatiment} \nEtat du batiement : {batiment.StatutBatiment} \nRessources : {batiment.QuantiteRessources} \n");
            }
        }
        public Batiments[] AjouterBatiment()
        {
            batiments[0] = new Batiments()
            {
                StatutBatiment = "Parfait",
                QuantiteRessources = 12
            };
            batiments[1] = new Batiments()
            {
                StatutBatiment = "démoli",
                QuantiteRessources = 100
            };
            batiments[2] = new Batiments()
            {
                StatutBatiment = "reparation",
                QuantiteRessources = 70
            };
            batiments[3] = new Batiments()
            {
                StatutBatiment = "Parfait",
                QuantiteRessources = 22
            };
            batiments[4] = new Batiments()
            {
                StatutBatiment = "démoli",
                QuantiteRessources = 145
            };
            return batiments;
        }
    }
}
