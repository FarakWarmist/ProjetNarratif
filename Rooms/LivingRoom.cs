namespace ProjetNarratif.Rooms
{
    internal class LivingRoom : Room
    {
        internal override string CreateDescription() =>
@"Dans le salon, le [sofa] semble être confortable.
la [tv] illumine faiblement la salle.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "sofa":
                    Console.WriteLine("Vous vous allongez sur le sofa. Vous prenez un petit 5 minutes pour vous reposer.");
                    break;
                case "tv":
                    Console.WriteLine("Vous allumez la télévision. À votre plus grande surprise, vous entendez une voix famillière de l'autre de l'écran. " +
                        "\nEn posant vos mains dessus, vous vous sentez soudainement tiré dans la télévison...");
                    Game.Finish();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
