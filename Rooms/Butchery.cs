namespace ProjetNarratif.Rooms
{
    internal class Butchery : Room
    {
        internal static bool isBunchOfKeysCollected;
        internal static bool noMoreBuchery;
        internal static string ? toDo;

        internal override string CreateDescription() =>
@"
Vous êtes maintenant seul dans la pièce.

Vous voulez vous dépêcher à partir d'ici, mais il peut y avoir quelque chose d'utile.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger
vers un autre endroit avec votre [CARTE].
";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "trousseau de clés":
                        Console.WriteLine(
@"Un trousseau comportant d'énormes clés.");

                        if (!isBunchOfKeysCollected)
                        {
                            Console.WriteLine(
@"
[TROUSSEAU DE CLÉS] rajouté à votre inventaire.");
                            isBunchOfKeysCollected = true;
                        }
                    //}
                        break;

                case "regarder":
                    if (Game.hideEvent <= 5)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Console.WriteLine(
@"Vous regardez autour de vous.

Vous êtes surpris de remarquer que la pièce est plus propre après cette
boucherie qu'elle l'était avant.");
                        if (!isBunchOfKeysCollected)
                        {
                            Console.WriteLine(
@"
Vous remarquez aussi le [TROUSSEAU DE CLÉS] dans le placard.");
                            isBunchOfKeysCollected = true;
                        }
                    }
                    break;

                case "journal":
                    Game.Journal();
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
