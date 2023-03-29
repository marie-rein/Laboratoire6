using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class Constructeur : Pieces
    {
        public Constructeur() : base() { }
        public Constructeur( string nomPiece, string modelPiece) : base(nomPiece, modelPiece)
        {
            
        }
        public override string ToString()
        {
            string info = base.ToString();
            info += $"Je suis un robot constructeur ";
            return info;
        }
    }
}
