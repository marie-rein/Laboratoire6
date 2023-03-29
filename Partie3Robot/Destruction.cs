using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class Destruction : Pieces
    {
        public string EtatBatiment { get; set; }

        public Destruction(): base() { }

        public Destruction(string etatBatiment,string nomPiece, string modelPiece): base(nomPiece,modelPiece)
        {
            this.EtatBatiment = etatBatiment;
        }

        public override string ToString()
        {
            string info = base.ToString();
             info += $"Je suis un robot destructeur , etat du batiment : {EtatBatiment}";
            return info;
        }
    }
}
