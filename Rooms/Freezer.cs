namespace ProjetNarratif.Rooms
{
    internal class Freezer : Room
    {

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
                    Game.MapDestination();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }

        }
    }
}
