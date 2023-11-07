namespace ProjetNarratif.Rooms
{
    internal class Closet : Room
    {
        internal static bool isKeyCollected;
        internal static bool isLogbookCollected;
        internal static bool isFlashlightCollected;
        internal static bool isMapCollected;
        internal static bool isDoorUnlocked;
        internal static string toDo;

        internal override string CreateDescription() =>
@"
L'odeur de fer et de moisie ajouté avec l'humidité dans la pièce vous donne mal au cœur.
La pièce est petite et remplie de tuyaux qui fuite. Le silence est remplie par un bruit de
moteur étouffé et par la seule ampoule qui clignote sans cesse acrochez au plafond.
Un gros [TAS DE LINGE] mouillés se trouve au fond de la pièce, une boîte de [DISJONCTEUR] et
une [PORTE].

Vous pouvez [REGARDER] les alentours.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "tas de linge":
                    Console.WriteLine(
@"Vous vous raprochez le tas de linges et remarquez que l'odeur de moisie devient plus fort.
Voulez-vous fouillez dans le tas de linge?
");
                    toDo = Console.ReadLine().ToLower();
                    Console.Clear();

                    switch (toDo)
                    {
                        case "oui":
                            Console.WriteLine(
@"En dépit de l'odeur, vous prenez sur vous et vous plongez plein bras dans le tas de linges.
Après un moment à chercher, vous trouvez une clé en bronze.

[CLÉ DU PLACARD] rajouté à votre inventaire.");
                            isKeyCollected = true;
                            break;

                        case "non":
                            Console.WriteLine("Vous vous éloignez du tas de linge.");
                            break;

                        default:
                            Console.WriteLine("Commande invalide.");
                            break;
                    }
                    break;

                case "disjoncteur":
                    Console.WriteLine(
@"Vous ouvez la boîte de disjoncteurs et réalisez avec horreur que la boîte est remplie de
chaire pulsante.
Vous refermez immédiatement la boîte et essayez d'oublier ce que vous venez de voir.");
                    break;

                case "porte":
                    if (!isKeyCollected)
                    {
                        Console.WriteLine(
@"Vous lisez « ! ATTENTION ! » sur la porte.
Vous essayez de l'ouvrir, mais elle est vérouillé.
Peut-être y a-t-il une clé cachée dans le coin.");
                    }
                    else
                    {
                        if (!isDoorUnlocked)
                        {
                            Console.Clear();
                            Console.WriteLine(
@"Vous rentrer la clé dans la serrure de la porte et tourner la clé et la déverrouillez.

La [PORTE] est maintenant déverrouillez.");
                            Console.WriteLine(
@"Voulez-vous passer la porte?

[OUI] ou [NON]?
");
                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "oui")
                            {
                                if (!isFlashlightCollected == true || !isMapCollected == true)
                                {
                                    Console.Clear();
                                    Game.Transition<OutClosetLackOfEquip>();
                                }
                                else
                                {
                                    Console.Clear();
                                    Game.Transition<OutCloset>();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Vous décidez de rester encore un peu.");
                            }

                            isDoorUnlocked = true;
                        }
                        else
                        {
                            if (!isFlashlightCollected == true || !isMapCollected == true)
                            {
                                Game.Transition<OutClosetLackOfEquip>();
                            }
                            else
                            {
                                Game.Transition<OutCloset>();
                            }
                        }
                    }
                    break;

                case "regarder":
                    if (!isFlashlightCollected && !isLogbookCollected)
                    {
                        Console.WriteLine("En observant les alentours, vous trouvez par terre un [JOURNAL] et une [LAMPE DE POCHE].");
                    }
                    else if (!isFlashlightCollected && isLogbookCollected)
                    {
                        Console.WriteLine("En observant les alentours, vous trouvez par terre une [LAMPE DE POCHE].");
                    }
                    else if (isFlashlightCollected && !isLogbookCollected)
                    {
                        Console.WriteLine("En observant les alentours, vous trouvez par terre un [JOURNAL].");
                    }
                    else
                    {
                        Console.WriteLine("En observant les alentours, vous ne trouvez plus rien d'interessant.");
                    }
                    break;

                case "journal":
                    if (!isLogbookCollected)
                    {
                        Console.WriteLine(
@"En ouvrant le journal, vous trouvez une [CARTE] avec des notes et des dessin

[JOURNAL] rajouté à votre inventaire.
[CARTE] rajouté à votre inventaire.");
                        isLogbookCollected = true;
                        isMapCollected = true;
                    }
                    else
                    {
                        Console.WriteLine(
@"");
                    }
                    break;

                case "lampe de poche":
                    Console.WriteLine(
@"Une vieille lampe de poche usé, mais surprenament encore en état de marcher.");
                    if (!isFlashlightCollected)
                    {
                        Console.WriteLine(
@"
[LAMPE DE POCHE] rajouté à votre inventaire.");
                    }
                    isFlashlightCollected = true;
                    break;

                case "carte":
                    if (!isMapCollected == true)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Console.WriteLine("Vous observez la carte. Certaines zones sembles avoir été encerclés et notés.");
                    }
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
