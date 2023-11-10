namespace ProjetNarratif.Rooms
{
    internal class OutCloset : Room
    {
        internal override string CreateDescription() =>
@"
Vous sortez et vous vous retrouvez dans un endroit plongé dans l'ombre illuminé
que part la lumière bleuté des congélateurs plus loin.
Vous pouvez percevoir quelques étagères semblables à celles qu'on pourrait retrouver
dans une épicerie, mais elles montent beaucoup plus haut que celles que vous connaissez.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger vers un autre
endroit avec votre [CARTE].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "regarder":
                    Console.WriteLine(
@"Vous pouvez percevoir quelques étagères semblables à celles qu'on pourrait retrouver dans une
épicerie, mais elles montent beaucoup plus haut que celles que vous connaissez. Le sol est
carrelé et semble tâché et peu entretenue.

Tout le reste est plonger dans le noir complet même avec votre lampe de poche en main.");
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
