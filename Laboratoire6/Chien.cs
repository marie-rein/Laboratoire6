using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienNameSpace
{
    class Chien
    {
        public string Name { get; set; }
        public string Etat { get; set; }
        public string MeilleurAmie { get; set; }

        public Chien()
        {
            Name = "";
            Etat = "";
            MeilleurAmie = "";
        }
        public Chien(string name, string etat)
        {
            Name = name;
            Etat = etat;
            MeilleurAmie = "";
        }
    }
}
