using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class GestionDeRobotEtBatiments
    {
       
        Usine usines;
        Ville ville;
        Batiments[] batiments;
        Pieces[] pieces;
        public static  int tour = 0;

        public GestionDeRobotEtBatiments()
        {
           
            usines = new Usine();
            pieces = new Pieces[6];
            ville = new Ville("Montreal", "2456 rue berlin");
            batiments = ville.AjouterBatiment();
            ville.AfficherInfoBatiment();
        }

        public Pieces [] EvaluerBesoinBatiment()
        {
            Console.WriteLine("------------------------------------------------------------------------- ");
            Console.WriteLine("EVALUATION DES BATIMENTS");
            Console.WriteLine("------------------------------------------------------------------------- \n");
            foreach (Batiments batiment in batiments)
            {
                if (batiment.StatutBatiment == "démoli")
                {
                    pieces[0] =(usines.CreerRobot());
                    Console.WriteLine("Un robot a été crée pour detruire le batiemnt numero :  " + batiment.NumeroBatiment);              
                    tour++;
                    if (batiment.QuantiteRessources > 100)
                    {
                        Console.WriteLine("Le batiment sera demoli et reconstruit par le robot " + TypeRobot.constructeur.ToString());
                        Console.WriteLine($"Vous avez assez de resources pour le reconstruire /voici votre prioprité : {batiment.Priorite = 2} ");
                        tour++;
                        pieces[1] =(usines.CreerRobot(pieces));
                        Console.WriteLine("Un robot construiteur a été crée \n");
                        batiment.StatutBatiment = "Parfait";
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Nouvel etat et nouvelle priorité");
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Malheureusement Vous n'avez pas assez des resources pour reconstruire le batiment \n");
                    }
                }
                if (batiment.StatutBatiment == "reparation" && batiment.QuantiteRessources < 100)
                {

                    Console.WriteLine("Un robot construiteur a été crée pour reparer le batiment " + batiment.NumeroBatiment);
                    Console.WriteLine($"le batiment va etre reparer avec les ressources disponibles / priorite de reparation : {batiment.Priorite = 1} ");

                    pieces[1]= usines.CreerRobot(pieces);
                    batiment.StatutBatiment = "Parfait";
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("Nouvel etat et nouvelle priorité");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    tour++;
                }
                if (batiment.StatutBatiment == "Parfait")
                {
                    Console.WriteLine($"Le batiment numéro : {batiment.NumeroBatiment} est dans un bon etat / priorité : {batiment.Priorite = 5} ");
                    Console.WriteLine("Il n'y a rien a modifier \n");
                    tour++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Nombre de tours " + tour);
            return pieces;
        }
       


    }
}
