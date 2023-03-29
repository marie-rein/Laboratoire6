using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3Robot
{
    internal class Pieces
    {
        
        public string NomPiece { get; set; }
        public string ModelPiece { get; set; }

        public Pieces()
        {
            NomPiece = "";
            ModelPiece = "";
        }
        public Pieces(string nom,string numero)
        {     
            NomPiece = nom;
            ModelPiece = numero;
        }
        public void Afficher()
        {
            Console.WriteLine($"Nom du piece: {NomPiece}\nNombre du piece: {ModelPiece}");
        }
        public override string ToString()
        {
            return $"Nom du piece: { NomPiece}\nNombre du piece: { ModelPiece}";
        }
    }
}
