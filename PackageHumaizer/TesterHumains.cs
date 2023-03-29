using Humanizer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageHumaizer
{
    internal class TesterHumains
    {
        public TesterHumains()
        {
            AppelerLesFonction();
        }

        public void AppelerLesFonction()
        {
            string monstring = "C'est mon string test, Utiliser humanizer pour tranformer ton texte";
            Console.Write("Chameau : ");
            ChameauCase(monstring);
            Console.Write("UnderScore : ");
            UnderScor(monstring);
            Console.Write("Capitalixzation : ");
            Capitaliser(monstring);
            Console.Write("Truncate : ");
            TruncaterString(monstring);
        }

        public void ChameauCase(string monString)
        {
            Colorful.Console.WriteLine(monString.Camelize());
        }
        public void UnderScor(string monString)
        {
            Colorful.Console.WriteLine(monString.Underscore(), Color.SpringGreen);
        }
        public void Capitaliser(string mosString)
        {
            Colorful.Console.WriteLine(mosString.Humanize(LetterCasing.AllCaps));
        }
        public void TruncaterString(string monString)
        {
            Colorful.Console.WriteLine(monString.Truncate(29, "------"));
        }
    }
}
