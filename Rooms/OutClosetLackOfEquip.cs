namespace ProjetNarratif.Rooms
{
    internal class OutClosetLackOfEquip : Room
    {
        internal override string CreateDescription() =>
@"Vous sortez et vous vous retrouvez dans un endroit plongé dans l'ombre illuminé
que part la lumière bleuté de congélateur.
Vous pouvez percevoir quelque étagère semblable à celle qu'on pourrait retrouver
dans une épicerie, mais elles montent beaucoup plus haut que celles que vous connaissez.

Il semble vous manquer quelque chose. Peut-être qu'il serait préférable de continuer à
chercher dans le [PLACARD].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "placard":
                    Game.Transition<Closet>();
                    break;

                case "carte":
                    if (!Closet.isMapCollected == true)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Console.WriteLine("Vous observez la carte. Certaines zones sembles avoir été encerclés et notés." +
                            "\nMais il fait trop sombre pour explorer. Peut-être il y a quelque chose qui pourrait vous" +
                            "\naider dans le [PLACARD].");
                    }
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
