using ChienNameSpace;
using ChatNameSpace;

namespace AmitieNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Chien monChien1 = new Chien()
            {
                Name = "Dog",
                Etat = "attristé"

            };
            Chien monChien2 = new Chien()
            {
                Name = "Doggy",
                Etat = "heureux"

            };

            Chien monChat = new Chat()
            {
                Name = "Cat",
                Etat = "mauvaise humeur"

            };

            if (monChat.Etat == "mauvaise humeur")
            {
                monChien1.MeilleurAmie = monChat.Name;
                Console.WriteLine(monChat.Name + " est de ''mauvaise humeur''");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(monChien1.MeilleurAmie + " est l'ami de " + monChien1.Name);
                Console.WriteLine(monChien1.Name+ " est l'ami de " + monChien1.MeilleurAmie);
            }
            if (monChien1.Etat == "attristé")
            {
                monChien1.MeilleurAmie = monChien2.Name;
                Console.WriteLine("\n" + monChat.Name + " ''est attristé''");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(monChien1.Name + " est l'ami de " + monChien2.Name);
            }
          
            Console.WriteLine($"Cat est tout seul sans ami donc il est --''malheureux''--");
            Console.WriteLine("Doggy est --''heureux-- car lui enfin a trouver un ami qui est Dog");
            
        }
    }
}