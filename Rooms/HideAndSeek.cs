using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class HideAndSeek : Room
    {
        internal static bool isBunchOfKeysCollected;
        internal static bool noMoreBuchery;
        internal static string? toDo;
        internal static bool miniGameFinished;

        internal override string CreateDescription()
        {
            switch (Game.hideEvent)
            {
                case 0:
                    return
@"
Vous marchez un moment jusqu'à la boucherie. Durant le tout le trajet, vous
entendiez les bruits de chaînes s'entrechoquant résonner dans tout le bâtiment.
Vous approchez une entrée dont une forte odeur de fer et une lumière jaune et
rouge s'en échappe.

En regardant à l'intérieur, vous êtes pétrifié par la scène :
La pièce comporte plusieurs tables de travail, dont une au centre, des étagères
et un comptoir avec lavabo. Des organes et morceaux de corps sont étalés sur
les différents comptoirs et la totalité de l'endroit est maculé de sang.

Lorsque vous vous apprêtez à partir loin de cette scène de crime, vous entendez
de lourd pas se rapprocher de votre position. Elle arrive et vous pouvez entendre
qu'elle traîne quelque chose. Vous n'avez pas le choix de vite trouver un endroit
où vous cacher.

Où voulez-vous vous cacher ? Derrière l'[ILOT], la [POUBELLE], le [LAVABO],
l'[ÉTAGÈRE] à outils ou le [PLACARD] ?
";

                case 1:
                    return
@"
Vous arrivez à vous cacher de justest !

Vous observez une femme au corps grand et massif à la peau rosée avec des
marque de brûlures et des blessures brochées. Elle a de longs cheveux
argentés en pointe.

Autour de son cou se trouve trois crânes humains ratachés à une corde et
elle porte un masque de métal encastré sur son visage. Malgré son apparence
humanoïde, vous sentez que cette chose est tout sauf humaine.

D'une simple main, elle dégage les boyaux trainant sur l'ilot, étant une
nappe en jute et pose plusieurs corps dessus.

Elle se déplace. Où voulez-vous vous cacher ? Derrière l'[ILOT], la [POUBELLE],
le [LAVABO], l'[ÉTAGÈRE] à outils ou le [PLACARD] ?
";

                case 2:
                    return
@"
Vous êtes de nouveau à couvert.

La créature ouvre son placard à outils et sélection divers instruments de boucher
et revient à l'ilot. Vous détournez immédiatement le regard lorsqu'elle se met à
découper les corps.

Après un moment, elle pose quelques choses dans un panier et referme la nappe en
jute.

Elle se déplace de nouveau. Où voulez-vous vous cacher ? Derrière l'[ILOT], la
[POUBELLE], le [LAVABO], l'[ÉTAGÈRE] à outils ou le [PLACARD] ?
";

                case 3:
                    return
@"
Vous n'avez toujours pas été repéré.

Vous la voyez mettre la nappe remplie des restes dans la poubelle et revenir à
l'ilot pour prendre ses outils ensanglantés.

Elle se déplace une fois de plus. Où voulez-vous vous cacher ? Derrière l'[ILOT],
la [POUBELLE], le [LAVABO], l'[ÉTAGÈRE] à outils ou le [PLACARD] ?
";

                case 4:
                    return
@"
Toujours cachez, vous regardez la créature ramener ses instruments de bouchers
couverts de sang au lavabo et commencer à les laver. 

Vous êtes surpris à l'entendre soudainement chantonner une berceuse d'une voix
douce et rassurante. Dans la panique, vous n'arrivez pas à comprendre la langue
dans laquelle elle la chante.

Elle vas bientôt bouger. Où voulez-vous vous cacher ? Derrière l'[ILOT], la
[POUBELLE], le [LAVABO], l'[ÉTAGÈRE] à outils ou le [PLACARD] ?
";

                default:
                    return
@"Elle ne vous a pas encore vue.

Vous pouvez la voir marcher lentement jusqu'au placard en métal, l'ouvrir et y
mettre un [TROUSSEAU DE CLÉS] à l'intérieur. Elle prend ensuite le panier et s'en
va de la pièce.

Un moment passe avant que vous ayez enfin le courage de vous relever.

";
            }
        }

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
@"Vous faites dos à l'ilot. Vous pouvez l'entendre se rapprocher et s'arrêter tout
prêt.

Vous êtes tout à coup renversé par un tas de boyaux qui vient de vous tomber dessus.
Le sang sur vos yeux vous empêche de bien voir.

Vous entendez d'une voix distordue « VIANDE ! » avant de sentir votre tête s'envoler.


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]
");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                                Console.Clear();
                            }
                            break;

                        case 5:
                            Console.Clear();
                            miniGameFinished = true;
                            Console.WriteLine(
@"Elle ne vous a pas encore vue.

Vous pouvez la voir marcher lentement jusqu'au placard en métal, l'ouvrir et y
mettre un [TROUSSEAU DE CLÉS] à l'intérieur. Elle prend ensuite le panier et s'en
va de la pièce.

Un moment passe avant que vous ayez enfin le courage de vous relever.

");
                            Game.Transition<Butchery>();
                            break;

                        default:
                            Console.Clear();
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

En réalisant votre erreur, vous tentez de vous sauver !

Alors que vous pensiez avoir une chance, vous sentez une résistance et une vive
douleur en dessous de votre mâchoire ainsi qu'un goût métallique dans votre bouche.

Vous remarquez un crochet vient de vous traverser la mâchoire inférieure.

Vous n'avez pas le temps de réaliser la situation que vous sentez le crochet
rapidement remonter... Et plus rien.


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]
");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                                Console.Clear();
                            }
                            break;

                        case 5:
                            Console.Clear();
                            miniGameFinished = true;
                            Console.WriteLine(
@"Elle ne vous a pas encore vue.

Vous pouvez la voir marcher lentement jusqu'au placard en métal, l'ouvrir et y
mettre un [TROUSSEAU DE CLÉS] à l'intérieur. Elle prend ensuite le panier et s'en
va de la pièce.

Un moment passe avant que vous ayez enfin le courage de vous relever.

");
                            Game.Transition<Butchery>();
                            break;

                        default:
                            Console.Clear();
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
@"Vous pensez être à l'abri derrière la poubelle, jusqu'à ce que vous réalisiez
qu'il y a quelque chose de grand qui vous fait de l'ombre. À peine vous avez le
temps de vous retourner que vous êtes immédiatement attrapé par la créature.

D'une seule main, elle vous rapproche de son visage pour mieux vous observer. Vous
pouvez voir entre les fentes de son masque, ses dents et un oeil qui semble aveugle.
Elle lève le pouce et le pause lentement sur le haut de votre torse. Vous essayez
de vous débattre, mais rien n'y fait. Les dernières choses dont vous vous souvenez
sont une voix difforme dire « Mne zhal' » et le craquement de votre dos.


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]
");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                                Console.Clear();
                            }
                            break;

                        case 5:
                            Console.Clear();
                            miniGameFinished = true;
                            Console.WriteLine(
@"Elle ne vous a pas encore vue.

Vous pouvez la voir marcher lentement jusqu'au placard en métal, l'ouvrir et y
mettre un [TROUSSEAU DE CLÉS] à l'intérieur. Elle prend ensuite le panier et s'en
va de la pièce.

Un moment passe avant que vous ayez enfin le courage de vous relever.

");
                            Game.Transition<Butchery>();
                            break;

                        default:
                            Console.Clear();
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
@"Vous vous cachez en dessus du lavabo à temps, mais pas dans une bonne position.

Au moment où vous comptiez vous replacer, deux massives bottes se tiennent devant
vous. Vous entendez l'eau couler au-dessus, et la créature se met à chanter une
berceuse dans une langue que vous ne comprenez pas. Sa voix est devenue douce et
rassurante.

La position dans laquelle vous vous êtes placé vous donne du mal à respirer, et
elle semble l'avoir remarquée. Elle cesse de chanter, et l'eau de couler. Vous
tentez de contrôler votre respiration de votre mieux. Le silence a rempli la
pièce.

Soudainement, vous sentez un pieu de métal transpercer le fond du lavabo pour se
planter directement dans votre coeur. Le sang remplit rapidement vos poumons et
vous mourrez le coeur percé.


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]
");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                                Console.Clear();
                            }
                            break;

                        case 5:
                            Console.Clear();
                            miniGameFinished = true;
                            Console.WriteLine(
@"Elle ne vous a pas encore vue.

Vous pouvez la voir marcher lentement jusqu'au placard en métal, l'ouvrir et y
mettre un [TROUSSEAU DE CLÉS] à l'intérieur. Elle prend ensuite le panier et s'en
va de la pièce.

Un moment passe avant que vous ayez enfin le courage de vous relever.

");
                            Game.Transition<Butchery>();
                            break;

                        default:
                            Console.Clear();
                            break;
                    }
                    break;

                case "placard":
                    Game.hideEvent++;
                    switch (Game.hideEvent)
                    {
                        case 5:
                            Console.Clear();
                            Console.WriteLine(
@"Vous allez rapidement derrière le placard. Mais vous réalisez alors que
les pas se dirigent ici et vous êtes instantanément repéré. Dans la panique,
vous glissez sur le sang par terre et tombez sur le sol.

La créature se rapproche de vous. Vous êtes dos au mur, il n'y a nulle part
où aller ! Elle s'agenouille. Vous fermez les yeux.

Vous sentez son doigt essuyer les larmes sur vos joues. Vous avez le courage
d'ouvrir un oeil. Elle vous observe, comme une mère regarderait son enfant en
peine. Elle vous serre avec douceur dans ses bras. 

Pourquoi est-elle si soudainement rassurante ?

« ... Hu... go... »

Cette voix ! Vous la connaissez ! C'est celle de votre mère.

« ... Mon... pauvre... petit... ange... »

Maman... Elle vous manque... Vous ne vouliez pas partir comme ça. Vous auriez
voulu lui dire que vous l'aimez et que vous saviez que ce n'est pas de ça
faute... C'était de la faute à personne.

Vous vous sentez fatigué et rassuré... Vous êtes... en... sécurité...


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]
");

                            toDo = Console.ReadLine().ToLower();
                            if (toDo == "non")
                            {
                                Game.Finish();
                            }
                            else
                            {
                                Game.hideEvent = 0;
                                Console.Clear();
                            }
                            break;

                        default:
                            Console.Clear();
                            break;
                    }
                    break;

                case "journal":
                    Game.Journal();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
