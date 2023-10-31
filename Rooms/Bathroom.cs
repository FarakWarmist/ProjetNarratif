namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal static bool isHotWaterTrigged;

        internal override string CreateDescription() =>
@"Dans la toilette, le [bain] est rempli d'eau chaude.
Le [miroir] devant toi affiche ton visage déprimé.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bain":
                    Console.WriteLine("Tu te laisses relaxer dans le bain. L'eau chaude remplie la pièce de vapeur... Quelque chose semble être écrit sur le miroir.");
                    isHotWaterTrigged = true;
                    break;
                case "miroir":
                    if (isHotWaterTrigged /*== true*/)
                    {
                        Console.WriteLine("Tu aperçois les chiffres 2314 écrits sur la brume sur le miroir.");
                    }
                    else
                    {
                        Console.WriteLine("Te voir aussi épuisé te donne envie de prendre un bon bain chaud.");
                    }
                    break;
                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
