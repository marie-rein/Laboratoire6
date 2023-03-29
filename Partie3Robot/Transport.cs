using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class Transport : Pieces
    {
        public int VitesseDestruction { get; set; }

        public Transport() : base() { }
        public Transport(int speed,string nomPiece,string modelPiece):base(nomPiece,modelPiece)
        {
            this.VitesseDestruction = speed;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $"Je suis un robot de transport,  Vitesse destruction: {VitesseDestruction}";
            return info;
        }
    }
}
