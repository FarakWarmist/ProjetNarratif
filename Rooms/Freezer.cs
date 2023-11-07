namespace ProjetNarratif.Rooms
{
    internal class Freezer : Room
    {
        string toGo;

        internal override string CreateDescription() =>
@"";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":

                    if (!Cashier.lightsOn)
                    {
                        Console.WriteLine(
@"");
                    }
                    else
                    {
                        Game.Transition<IntoFreezer>();
                    }
                    break;

                case "carte":
                    Console.Clear();
                    Console.WriteLine(
@"Où voulez-vous allez?

Vous pouvez allez au [TÉLÉPHONE], à l'[ENTREPOT], à la [BOUCHERIE], dans le [CONGÉLATEUR],
au [PLACARD] ou rester à la [CAISSE].");
                    toGo = Console.ReadLine();

                    switch (toGo)
                    {
                        case "caisse":
                            Game.Transition<Cashier>();
                            break;

                        case "téléphone":
                            Game.Transition<Phone>();
                            break;

                        case "entrepot":
                            Game.Transition<Backstore>();
                            break;

                        case "boucherie":
                            Game.Transition<Butchery>();
                            break;

                        case "congélateur":
                            Game.Transition<Freezer>();
                            break;

                        case "placard":
                            Game.Transition<Closet>();
                            break;

                        default:
                            Console.WriteLine("Commande invalide.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }

        }
    }
}
