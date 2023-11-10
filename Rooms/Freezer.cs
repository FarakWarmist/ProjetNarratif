namespace ProjetNarratif.Rooms
{
    internal class Freezer : Room
    {

        internal override string CreateDescription() =>
@"";
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
@"");
                    }
                    else
                    {
                        Game.Transition<IntoFreezer>();
                    }
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
