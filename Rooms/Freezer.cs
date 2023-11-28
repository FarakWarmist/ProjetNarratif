namespace ProjetNarratif.Rooms
{
    internal class Freezer : Room
    {
        internal static bool isMeatCollected;

        internal override string CreateDescription() =>
@"
L'air est plus frais par ici. Plusieurs congélateurs vitrés sont placés pour présenter
divers produits que vous n'arrivez pas à voir d'ici.

Au mur, se trouve une grande [PORTE] coulissante dont de l'air froid s'en échappe,
créant une épaisse brume toute autour.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger vers
un autre endroit avec votre [CARTE].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":

                    if (!Cashier.lightsOn)
                    {
                        Console.WriteLine(
@"Vous essayez de pousser la porte, mais elle semble coincée. En observant bien, vous
remarquez que la porte est liée à un mécanisme dont des câbles y sont rattachés.

Peut-être que la porte ne s'ouvre pas sans électricité. Vous devez trouver un moyen de
ramener le courant.");
                    }
                    else
                    {
                        Console.WriteLine(
@"Vous ouvrez la grande porte coulissante et êtes accueilli par un terible vent glacé.
");
                        Game.Transition<IntoFreezer>();
                    }
                    break;

                case "regarder":
                    Console.WriteLine(
@"Vous vous rapprochez pour observer de plus près ce qu'il y a dans ces congélateurs.
Après avoir frotté la buer sur une des vitres, vous le regrettez instantanément.
Vous pouvez voir un homme gelé affichant une expression de peur. La surprise vous fait
tomber par terre. 

Vous vous relevez et allez voir dans un des plus petits congélateurs. Des morceaux de
[VIANDE] humains découpés en différentes parties sont empilés à l'intérieur. 

Dans quel genre d'endroit êtes-vous tombé ?");
                    break;

                case "viande":
                    if (!isMeatCollected == true)
                    {
                        Console.WriteLine(
@"Vous décidez d'ouvrir un des congélateurs et de prendre un des morceaux de viande au
hasard. Vous ressortez un sac écrit « Quarts d'Avant-Bras », ce qui vous lève le coeur,
mais vous prenez sur vous. Peut-être que ça vous sera utile.

[VIANDE] rajoutée à votre inventaire.");
                        isMeatCollected = true;
                    }
                    else
                    {
                        Console.WriteLine(
@"Vous avez déjà collectée la viande.");
                    }
                    break;

                case "journal":
                    Game.Journal();
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
