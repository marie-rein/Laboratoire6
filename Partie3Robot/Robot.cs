using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    enum TypeRobot
    {
        constructeur,
        destructeur,
        transporteur
    }
    internal class Robot
    {
        Pieces [] mesPieces = new Pieces[3];
        TypeRobot type;
     
        public Robot()
        {
            mesPieces[0] = new Destruction();
            mesPieces[1] = new Constructeur();
            mesPieces[2] = new Transport();

        }

        public Robot(Pieces[] pieces)
        {
            this.mesPieces = pieces;
        }

        public TypeRobot GetPieces()
        {
            return type;
        }

    }
}
