using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Humanizer;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace PackageHumaizer
{
    internal class TesterConsole
    {
        public TesterConsole()
        {
            AppellerLesFonction();
        }

        public void AppellerLesFonction()
        {
            string monString = "P O O";
            string monstring2 = "PROGRAMMATION";
            TransformerText(monString);
            FormatterTextConsole();
            FormaterAvecGradient();
            TransformerText(monstring2);
        }
        public void TransformerText(string monstring)
        {
            int rouge = 24, vert = 10, bleu = 224;
            Colorful.Console.WriteAscii(monstring, Color.FromArgb(rouge, vert, bleu));
        }
        public void FormatterTextConsole()
        {
            string[] composantsOrdinateur = new string[] { "Processeur", "carte graphique", "Memoire vive", "Carte mere", "Disque dur", "...." };
            string monString = "Un ordinateur est composé d'un {0} et d'une {1} et 2 {2} et  d'une {3} et d'un {4}";
            Console.WriteLineFormatted(monString, Color.OrangeRed, Color.White, composantsOrdinateur);
        }
        public void FormaterAvecGradient()
        {
            string monString = "Processeur carte graphique Memoire vive Carte mere Disque dur";
            Console.WriteWithGradient(monString, Color.Yellow, Color.BlueViolet, 14);
            System.Console.WriteLine();
        }
    }
}
