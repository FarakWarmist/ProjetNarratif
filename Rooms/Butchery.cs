namespace ProjetNarratif.Rooms
{
    internal class Butchery : Room
    {
        internal static bool isBunchOfKeysCollected;
        internal static bool noMoreBuchery;
        internal static string ? toDo;

        internal override string CreateDescription() =>

@"
Vous marchez un moment jusqu'à la boucherie. Durant se temps vous avez entendu les bruits de
chaines s'entrechoquer résonner dans tout le bâtiment.

Vous approchez une entrée dont une forte odeur de fer et une lumière jaune et rouge s'en échappe.
En regardant à l'intérieur, vous êtes pétrifier par la scène:
La pièce comporte plusieurs table de travail, dont une au cente, des étagères et un comptoir avec
lavabo. Des organes et morceau de corps sont étalé sur les différent comptoire et la totalité de
l'endroit est maculé de sang.

Lorsque vous êtes pour partir loin de cette endroit maccabre, vous entendez de lourd pas se
rapprocher de votre position. Elle arrive et vous pouvez entendre qu'elle traine quelque chose.
Vous n'avez pas le choix de vite trouvez un endroit où vous cacher.

Où voulez-vous vous cacher ? Derrière l'[ILOT], la [POUBELLE], le [LAVABO], l'[ÉTAGÈRE] à outils
ou le [PLACARD]?
";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "ilot":
                    Game.hideEvent++;
                    switch (Game.hideEvent)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(
@"Vous faite dos à l'ilot. Vous pouvez l'entendre se rapprochez et s'arrêter tout prêt.

Vous êtes tout à coup renversez par un tas de boyaux qui vient de vous tomber dessus. Le sang
sur vos yeux vous empêche de bien voir.

Vous entendez d'une voix distordue « VIANDE ! » avant de sentir votre tête s'envoler.


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]");

                            toDo = Console.ReadLine().ToLower();
                            if(toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                            }

                            break;

                        default:
                            Game.HideAndSeekGame(Game.hideEvent);
                            break;
                    }
                    break;

                case "étagère":
                    Game.hideEvent++;
                    switch (Game.hideEvent)
                    {
                        case 2:
                            Console.Clear();
                            Console.WriteLine(
@"Vous vous cachez derrière l'étagère... Là où le monstre se rendait.

En réalisant votre erreur, vous tentez de vous sauvez !

Alors que vous penssiez avoir une chance, vous sentez une résistance et une douleur vive
en-dessous de votre machoir ainsi que goût métalique dans votre boucher. Vous remarquez
un crochet vient de vous traverser la machoire inférieur.

Vous n'avez pas le temps de réaliser la situation que vous s'entez le crochet rapidement
remonter... Et plus rien.


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                            }
                            break;

                        default:
                            Game.HideAndSeekGame(Game.hideEvent);
                            break;
                    }
                    break;

                case "poubelle":
                    Game.hideEvent++;
                    switch (Game.hideEvent)
                    {
                        case 3:
                            Console.Clear();
                            Console.WriteLine(
@"Vous pensez être à l'habrit derière la poubelle, jusqu'à ce que vous réalisez qu'il
y a quelque chose de grand qui vous fait de l'ombre. À peine vous avez le temps de vous
retournez que vous êtes immédiatement attraper par la créature.

D'une seuls main, elle vous raproche de son visage pour mieux vous observez. Vous pouvez
voir entre les fentes de son masque ses dans et un œil qui semble aveugle. Elle lève le
pousse et le pause lentement sur le haut de votre torse. Vous essayez de vous débattre
mais rien n'y fait. Les dernières choses dont vous vous souvenez sont le craquement de
votre dos et une voix difforme dire « Mne zhal' ».


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                            }
                            break;

                        default:
                            Game.HideAndSeekGame(Game.hideEvent);
                            break;
                    }
                    break;

                case "lavabo":
                    Game.hideEvent++;
                    switch (Game.hideEvent)
                    {
                        case 4:
                            Console.Clear();
                            Console.WriteLine(
@"Vous vous cachez en-dessus du lavabo à temps mais pas dans une bonne position. Au moment
où vous comptiez vous replacer, deux massive botte se tient devant vous. Vous entendez
l'eau couler au dessus, et la créature se met à chanter une berceuse dans une langue que
que vous ne connaissez pas. Sa voix est devenu douce et rassurante.

La position dans laquelle vous vous êtes placer vous donne du mal à respirer. Et elle
semble l'avoir remarque. Elle a cesser de chanter et l'eau, de couler. Vous tentez de
contrôler votre respiration de votre mieux. Le silence à remplie la pièce.

Soudainement, vous sentez un pieux de métal transpercer le fond du lavabo pour se planter
directement dans votre cœur. Le sang remplie rapidement vos poumons et vous mourrez le
cœur percé.


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                            }
                            break;

                        default:
                            Game.HideAndSeekGame(Game.hideEvent);
                            break;
                    }
                    break;

                case "placard":
                    Game.hideEvent++;
                    switch (Game.hideEvent)
                    {
                        case 3:
                            Console.Clear();
                            Console.WriteLine(
@"Vous aller rapidement derrière le placard. Mais vous réaliser que les pas se dirige ici
et vous êtes instantanément repéré. Dans la panique vous glissez sur le sang par terre et
tombez sur le sol. La créature se rapproche de vous. Vous êtes dos au mur, il n'y a nul
part où aller ! Elle s'agenouille. Vous fermez les yeux.

Vous sentez son doigt essuyer les larmes sur vos joue. Vous avez le courage d'ouvrir un
œil. Elle vous observe, comme une mère regarderait son enfant en peine. Elle vous
serre avec douceur dans ses bras. Pourquoi est-elle si soudainement rassurante.

« ... Hu... go... »

Cette voix ! Vous la connaissez ! C'est celle de votre mère.

« ... Mon... pauvre... petit... ange... »

Maman... Elle vous manque... Vous ne vouliez pas partir comme ça. Vous auriez voulu lui
dire que vous l'aimiez et que vous saviez que ce n'est pas de ça faute... C'était de la
faute à personne.

Vous vous sentez fatigué et rassuré... Vous êtes... en... sécurité...


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                            }
                            break;

                        default:
                            Game.HideAndSeekGame(Game.hideEvent);
                            break;
                    }
                    break;

                case "trousseau de clés":
                    if (Game.hideEvent !> 5)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Console.WriteLine(
@"Un trousseau dont les clés sont presque aussi long que la distance entre vos deux épaules.");

                        if (!isBunchOfKeysCollected)
                        {
                            Console.WriteLine(
@"
[TROUSSEAU DE CLÉS] rajouté à votre inventaire.");
                            isBunchOfKeysCollected = true;
                        }
                    }
                        break;

                case "regarder":
                    if (Game.hideEvent !> 5)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Console.WriteLine(
@"Vous regarder autour. Vous êtes surpris de remarquez que la pièce est plus propre après
cette boucherie qu'elle l'était avant.");
                        if (!isBunchOfKeysCollected)
                        {
                            Console.WriteLine(
@"
Vous remarquez aussi le [TROUSSEAU DE CLÉS] dans le placard.");
                            isBunchOfKeysCollected = true;
                        }
                    }
                    break;

                case "journal":
                    if (Game.hideEvent! > 5)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Game.Journal();
                    }
                    break;

                case "carte":
                    if (Game.hideEvent !> 5)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        if (!isBunchOfKeysCollected)
                        {
                            Console.WriteLine(
@"Vous sentez qu'il vous manque quelque chose avant de partir.

Vous préférez être sur de partir avec tout ce que cette endroit a à offrir, vous ne
souhaitez pas revenir ici.");
                        }
                        else 
                        { 
                            Game.MapDestination();
                            noMoreBuchery = true;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
