using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class Usine
    {
        Robot robot;
        Pieces[] pieces;

        public Usine()
        {
            robot = new Robot();
            pieces = new Pieces[3];
        }

        public Pieces CreerRobot(Pieces[] pieces)
        {
            pieces[1] = new Constructeur("Cons- 1234", "constructeur ");
            Console.WriteLine(pieces[1]);
            return pieces[1];
        }

        public Pieces CreerRobot(Pieces[] pieces, int vitesseTransport = 10)
        {

            pieces[2] = new Transport(vitesseTransport, "Trans-657", "transport ");
            Console.WriteLine(pieces[2]);
            return pieces[2];
        }

        public Pieces CreerRobot()
        {
            pieces[0] = new Destruction("Destruction", "Desctr-456", "desc356 ");
            Console.WriteLine(pieces[0]);
            return pieces[0];
        }


        public int RandomTypeRobot(TypeRobot type)
        {

            int random = 0;
            if (random == 0)
            {
                type = TypeRobot.constructeur;
            }
            else if (random == 1)
            {
                type = TypeRobot.destructeur;
            }
            else if (random == 2)
            {
                type = TypeRobot.transporteur;
            }
            return random;
        }
    }
}
