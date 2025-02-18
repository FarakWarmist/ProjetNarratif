﻿namespace ProjetNarratif.Rooms
{
    internal class Cashier : Room
    {
        internal static bool alreadySeen;
        internal static bool lightsOn;

        internal static bool isCoinCollected;

        internal static string ? toDo;

        internal override string CreateDescription() =>
@"
Vous arrivez à la zone des caisses, et il y a effectivement 3 caisses semblable à
ceux qu'on retrouve dans les magazins d'aujourd'hui.
Il semble avoir une [PERSONNE] derrière la caisse du milieu.
Tout au fond, vous pouvez voir dans le coin une immense [PORTE].
La première [CAISSE] attire aussi votre attention.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger vers
un autre endroit avec votre [CARTE].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "personne":
                    if (!alreadySeen) 
                    {
                        Console.WriteLine(
@"Vous vous approchez la personne.
Plus vous vous rapprochez, plus vous réalisez que la personne devant vous est un corps
dont la mort semble être une sévère déshydratation.

Vous remarquez qu'il porte un tablier écrit « Welcom to Olga's Meat Store ».

Vous fouillez ces poches de pantalon. Peut-être a-t-il quelque chose d'utile sur lui.
Peut-être qu'avec de la chance, il aura l'un de ces téléphones portalbes. 

Vous ne trouvez rien malheureusement.");
                        alreadySeen = true;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas vraiment l'envie de revoir ce corps désèché.");
                    }
                    break;

                case "porte":

                    Console.WriteLine(
@"Vous marchez jusqu'à la porte.

La porte ressemble à l'une de ces portes coulissantes automatiques qu'on retrouve à
l'entrée de certains magasins. Mais celles-ci ne sont fait que de métal rouillé avec
aucune fenêtre pour voir ce qu'il y a de l'autre côté.");

                    if (!lightsOn)
                    {
                        Console.WriteLine(
@"
Vous décidez de revenir proche des caisses.");
                    }
                    else
                    {
                        Console.WriteLine(
@"
Vous essayez de faire réagir la porte, mais rien n'y fait. Il va falloir trouver un
autre moyen pour sortir.");
                    }
                    break;

                case "caisse":
                    if (!lightsOn)
                    {
                        Console.WriteLine(
@"Vous arrivez à ouvrir une des caisses. À l'intérieur, se trouve une seule pièce de
monnaie.

___________________________
Voulez-vous prendre la [PIÈCE]?
[OUI] ou [NON]
");
                        toDo = Console.ReadLine().ToLower();
                        if (toDo == "oui") 
                        {
                            Console.Clear();
                            Game.Transition<MamaOlgaIsHere>();
                        }
                        else
                        {
                            Console.WriteLine(
@"Vous n'êtes pas interessez et laissez la pièce dans la caisse.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(
@"Une pièce de monnaie égratignée et très usée");
                    }
                    break;

                case "regarder":

                    Console.WriteLine(
@"Vous observez les alentours.

Quelque chose vous dérange dans la manière dont sont faites les caisses. Elles ressemblent
aux caisses modernes, et pourtant, elles sont complètement rouillées et abandonnées depuis
sûrement plusieurs années ! Et la façon dont ils sont construits, on dirait que se sont que
des répliques");
                    break;

                case "journal":
                    Game.Journal();
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
