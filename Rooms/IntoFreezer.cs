using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class IntoFreezer : Room
    {
        int getFrozen;
        string ? warning;

        internal static bool isLeadBulletsCollected;

        internal override string CreateDescription() =>
@"";

        internal override void ReceiveChoice(string choice)
        {
            if (getFrozen >= 0 && getFrozen < 3)
            {
                warning = "";
            }
            else if (getFrozen >= 3 && getFrozen < 5)
            {
                warning =
@"
Il commence à faire vraiment froid, il vaudrait mieux sortir avant qu'il soit trop tard.";
            }
            else
            {
                Console.Clear();
                Console.WriteLine(
@"");
                Game.Finish();
            }

            switch (choice)
            {
                case "cadavre":
                    Console.WriteLine(
@"" + warning);
                    getFrozen++;
                    break;

                case "sac de munition":
                    Console.WriteLine(
@"" + warning);
                    getFrozen++;
                    break;

                case "porte gelée":
                    Console.WriteLine(
@"" + warning);
                    getFrozen++;
                    break;

                case "porte":
                    Game.Transition<Freezer>();
                    getFrozen = 0;
                    break;
                
                case "inventaire":
                    Game.Inventory();
                    break;

                case "carte":
                    Game.MapDestination();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
