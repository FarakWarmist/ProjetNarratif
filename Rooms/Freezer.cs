namespace ProjetNarratif.Rooms
{
    internal class Freezer : Room
    {
        internal static bool isMeatCollected;

        internal override string CreateDescription() =>
@"
L'air est plus frais ici. Plusieurs congélateurs vitrée son placer pour présenter
divers produit que vous ne pouvez pas voir d'ici.
Au mur se trouve une grande [PORTE] coullissante dont de l'air froid s'en échape, créamt
une brûme toute autour.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger vers un autre
endroit avec votre [CARTE].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":

                    if (!Cashier.lightsOn)
                    {
                        Console.WriteLine(
@"Vous essayer de poussez la porte, mais elle semble coincée. En obscervant bien, vous
remarquer que la porte est lié à un méchanisme dont des cable y sont rattachés.

Peut-être que la porte ne souvre pas sans électricité. Vous devez trouvez un moyen de
ramenez le courant.");
                    }
                    else
                    {
                        Game.Transition<IntoFreezer>();
                    }
                    break;

                case "regarder":
                    Console.WriteLine(
@"Vous vous rapprochez pour observer de plus prêt ce qu'il y a dans ces congélateurs.
Après avoir frotté la bué sur une des vitre, vous le regrettez instantanément.
Vous pouvez voir un homme gelé affichant une expression de peur. La surprise vous fait
tomber par terre. 

Vous vous relevez et aller voir dans un des plus petit congélateur. Des morceaux de
[VIANDE] humaines découper en différente parties sont empiler dedans. 

Dans quel genre d'endroit êtes-vous tombé?");
                    break;

                case "viande":
                    Console.WriteLine(
@"Vous décidez d'ouvrir un des congélateur et de prendre un de viande au hazard. Vous
resortez un avant bras, ce qui vous lève le cœur, mais vous prenez sur vous. Peut-être
que ça vous sera utile.

[VIANDE] rajoutée à votre inventaire.");
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
