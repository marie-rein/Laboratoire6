using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class Vitesse : Pieces
    {
        int vitesse;

        public Vitesse() : base() { }
        public Vitesse(int vitesse)
        {
            this.vitesse = vitesse;
        }
        public override string ToString()
        {
            string info = base.ToString();
            info += $" Je suis un robot de vitesse : {vitesse}";
            return info;
        }
    }
}
