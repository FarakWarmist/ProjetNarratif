namespace ProjetNarratif.Rooms
{
    internal class OutCloset : Room
    {
        internal override string CreateDescription()
        {
            if (!Closet.isFlashlightCollected == true || !Closet.isMapCollected == true)
            {
                return
                @"
Vous sortez et vous vous retrouvez dans un endroit plongé dans l'ombre illuminé
que part la lumière bleuté des congélateurs plus loin.
Vous pouvez percevoir quelques étagères semblables à celles qu'on pourrait retrouver
dans une épicerie, mais elles montent beaucoup plus haut que celles que vous connaissez.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger vers un autre
endroit avec votre [CARTE].
";
            }
            else
            {
                return
@"
Vous sortez et vous vous retrouvez dans un endroit plongé dans l'ombre illuminé
que part la lumière bleuté de congélateur.
Vous pouvez percevoir quelque étagère semblable à celle qu'on pourrait retrouver
dans une épicerie, mais elles montent beaucoup plus haut que celles que vous connaissez.

Il semble vous manquer quelque chose. Peut-être qu'il serait préférable de continuer à
chercher dans le [PLACARD].
";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "regarder":
                    if (!Closet.isFlashlightCollected)
                    {
                        Console.WriteLine(
@"Vous n'arrivez à voir rien dans cette noirceur.");
                    }
                    else
                    {
                        Console.WriteLine(
@"Vous pouvez percevoir quelques étagères semblables à celles qu'on pourrait retrouver dans une
épicerie, mais elles montent beaucoup plus haut que celles que vous connaissez. Le sol est
carrelé et semble tâché et peu entretenue.

Tout le reste est plonger dans le noir complet même avec votre lampe de poche en main.");
                    }
                    break;

                case "placard":
                    if (!Closet.isFlashlightCollected == true || !Closet.isMapCollected == true)
                    {
                        Game.Transition<Closet>();
                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;

                case "journal":
                    if (!Closet.isLogbookCollected)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Game.Journal();
                    }
                    break;

                case "carte":
                    if (!Closet.isMapCollected == true)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else if (!Closet.isFlashlightCollected == true)
                    {
                        Console.WriteLine(
@"Vous observez la carte. Certaines zones sembles avoir été encerclés et notés, mais il
fait trop sombre pour explorer.
Peut-être il y a quelque chose qui pourrait vous aider dans le [PLACARD].");
                    }
                    else
                    {
                        Game.MapDestination();
                    }
                    break;

                case "inventaire":
                    Game.Inventory();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
