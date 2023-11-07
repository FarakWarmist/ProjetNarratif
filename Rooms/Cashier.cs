﻿namespace ProjetNarratif.Rooms
{
    internal class Cashier : Room
    {
        internal static bool alreadySeen;
        internal static bool lightsOn;

        internal static bool isWalletCollected;
        internal static bool isCoinCollected;

        internal static string toDo;
        internal static string toGo;

        internal override string CreateDescription() =>
@"
Vous arrivez à la zone des caisses, et il y a effectivement 3 caisses semblable à
ceux qu'on retrouve dans les magazins aujourd'hui.
Il semble avoir une [PERSONNE] derrière la caisse du milieu.
Tout au fond, vous pouvez voir dans le coin une immense [PORTE].
La première [CAISSE] attire aussi votre attention.

Vous pouvez [REGARDER] les alentours ou vous diriger vers un autre endroit avec
votre [CARTE].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "personne":
                    if (!alreadySeen) 
                    {
                        Console.WriteLine(
@"Vous vous rapprochez de la personne.
Plus vous vous rapprochez, plus vous réalisez que la personne devant vous est un
une personne semble avoir complètement désidraté.
Vous remarquez qu'il porte un tablier écrit « Welcom to Olga's Meat Store.
");
                        Console.WriteLine(
@"Vous vouillez ces poches de pantalon. Peut-être a-t-il quelque chose d'utile sur
lui. Peut -être qu'avec de la chance il aura l'un de ces téléphone portalbe.
Vous ne trouvez cependant que son [PORTEFEUILLE].");
                        isWalletCollected = true;
                        alreadySeen = true;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas vraiment l'envie de revoir ce corps désèché.");
                    }
                    break;

                case "porte":
                    if (!lightsOn)
                    {
                        Console.WriteLine(
@"Vous marcher jusqu'à la porte.
La porte ressemble à l'une de ses porte coulissante automatique qu'on retrouve à
l'entrez de certain magazin. Mais celle-ci n'est fait que de métal rouilloué avec
aucune fenêtre pour voir ce qu'il y a de l'autre côté.

Vous décider de revenir proche des caisse.");
                    }
                    else
                    {
                        Console.WriteLine(
@"Vous marcher jusqu'à la porte.
La porte ressemble à l'une de ses porte coulissante automatique qu'on retrouve à
l'entrez de certain magazin. Mais celle-ci n'est fait que de métal rouilloué avec
aucune fenêtre pour voir ce qu'il y a de l'autre côté.

Vous essayez de faire réagir la porte.
Après tout cette chose à pus la passer, mais rien n'y fait. Il va faloir trouvez un
autre moyen pour sortir d'ici.");
                    }
                    break;

                case "caisse":
                    if (!lightsOn)
                    {
                        Console.WriteLine(
@"Vous trouvez à la caisse une pièce de monnaie.

Voulez vous la prendre?
[OUI] ou [NON]");
                        toDo = Console.ReadLine().ToLower();
                        if (toDo == "oui") 
                        {
                            Game.Transition<MamaOlgaIsHere>();
                            isCoinCollected = true;
                            lightsOn = true;
                        }
                        else
                        {
                            Console.WriteLine(
@"Vous n'ête pas interessez et laissez la pièce là où elle est.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(
@"");
                    }
                    break;

                case "regarder":
                    if (!lightsOn)
                    {
                        Console.WriteLine(
@"");
                    }
                    else
                    {
                        Console.WriteLine(
@"");
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

                
            }
        }
    }
}
