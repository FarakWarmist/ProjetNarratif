namespace ProjetNarratif.Rooms
{
    internal class OutCloset : Room
    {
        internal override string CreateDescription() =>
@"
Vous sortez et vous vous retrouvez dans un endroit plongé dans l'ombre illuminé
que part la lumière bleuté de congélateur.
Vous pouvez percevoir quelque étagère semblable à celle qu'on pourrait retrouver
dans une épicerie, mais elles montent beaucoup plus haut que celles que vous connaissez.

Vous allumez votre lampe de poche et observez la carte. Certaines zones semble avoir été encercler et noté.
Vous pouvez allez à la [CAISSE], au [TÉLÉPHONE], à l'[ENTREPOT], à la [BOUCHERIE], dans le [CONGÉLATEUR]
ou revenir dans le [PLACARD].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
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
        }
    }
}
