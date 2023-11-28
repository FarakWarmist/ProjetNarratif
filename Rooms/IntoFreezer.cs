using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class IntoFreezer : Room
    {
        int getFrozen;
        string ? warning;

        internal static bool freezingDoorUnlock;
        internal static bool isLeadBulletsCollected;
        internal static bool isMessageCollected;
        internal static string ? toDo;

        internal override string CreateDescription() =>
@"
Vous pouvez voir des tables en métal dont une avec un [CORPS] dessus. Des
morceaux de partie humaine, et d'autres non-humains, sont suspendus au
plafond par des crochets.Au fond de la pièce, vous apercevez une [PORTE GELÉE]
avec un gros [CADENAS] qui le maintient fermée.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger
vers un autre endroit avec votre [CARTE].

Vous savez que rester dans cette chambre froide quelques minutes suffira à vous
paralyser de froid.
";

        internal override void ReceiveChoice(string choice)
        {
            if (getFrozen >= 0 && getFrozen < 3)
            {
                warning = "";
            }
            else if (getFrozen >= 3 && getFrozen < 5)
            {
                warning =
@"

Il commence à faire vraiment froid, il vaudrait mieux sortir avant qu'il soit trop
tard.";
            }
            else
            {
                Console.Clear();
                Console.WriteLine(
@"Vous ne sentez plus vos mains.
Vos jambes refusent de bouger.
Vous pouvez voir vos yeux se cristalliser.

Le froid a eu le dessus sur vous.


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]
");
                toDo = Console.ReadLine().ToLower();
                if (toDo != "non")
                {
                    Game.Transition<Freezer>();
                    freezingDoorUnlock = false;
                    isLeadBulletsCollected = false;
                    isMessageCollected = false;
                    getFrozen = 0;
                }
                else
                { 
                    Game.Finish();
                }
                
            }

            switch (choice)
            {
                case "corps":
                    getFrozen++;
                    Console.WriteLine(
@"Vous allez vers le corps.

Le cadavre est étendu dos à la table et n'est vêtu que d'un linge qui couvre
le bas de son corps.

Son torse a été soigneusement ouvert et est totalement creux. Une épaisse fente
sépare presque en deux sa tête de haut en bas. Un de ses bras semble en mauvais
état, ressemblant à un crayon qu'on aurait trop mâchouillé.");

                    if (!isLeadBulletsCollected)
                    {
                        Console.WriteLine(
@"
Dans l'autre main, il semble tenir quelque chose fermement.

Voulez-vous voir ce que c'est ?
[OUI] | [NON]
");
                        toDo = Console.ReadLine().ToLower();
                        if (toDo == "oui")
                        {
                            Console.WriteLine(
@"Vous entrouvrez sa main pour voir un sac avec à l'intérieur des
[BALLES EN PLOMB] ressemblant à des billes en métal." + warning);
                        }
                        else
                        {
                            Console.WriteLine(
@"Vous ne vous sentez pas super bien de toucher un mort. Vous laissez tomber et
vous vous éloignez du corps." + warning);
                        }
                    }

                    break;

                case "balles en plomb":
                    getFrozen++;
                    if (!isLeadBulletsCollected)
                    {
                        Console.WriteLine(
@"Vous prenez le sac que tenait le cadavre et le mettez dans votre poche.

[BALLES EN PLOMB] rajoutées à votre inventaire." + warning);
                    }
                    else
                    {
                        Console.WriteLine(
@"Un petit sac remplie de balles en plomb.");
                    }

                    break;

                case "porte gelée":
                    if (!Butchery.isBunchOfKeysCollected)
                    {
                        getFrozen++;
                        Console.WriteLine(
@"Vous insérez l'une des clés du trousseau dans le cadenas et arrivez à le
débarrer.

La [PORTE GELÉE] est maintenant déverouillée." + warning);
                        freezingDoorUnlock = true;
                    }

                    if (!freezingDoorUnlock)
                    {
                        getFrozen++;
                        Console.WriteLine(
@"La porte complètement gelée est vérouillé par un gros cadenas. Un hublot se
trouve sur le haut de la porte, hors de votre portée. Vous pourrier prendre une
[CAISSE] à votre portée pour voir ce qu'il y a de l'autre côté." + warning);
                        
                    }
                    else
                    {
                        if (!BackstoreWithDogs.friendlyDogs)
                        {
                            Game.Transition<BackstoreWithDogs>();
                        }
                        else
                        {
                            Game.Transition<Backstore>();
                        }
                    }
                    break;

                case "caisse":
                    getFrozen++;
                    Console.WriteLine(
@"Vous rapprochez une caisse près de la porte et regarder à travers du hublot.

Malgré le givre qui recouvre la vitre, vous pouvez voir un couloir qui va de gauche
à droite dont les murs sont recouverts de tuyaux et de mécanismes.

En regardant plus bas, vous voyez ce que vous pensez être 2 chiens qui se reposent
et gardent l'entrée.

Ils seront certainement un problème lorsque vous ouvrirez la porte.");
                    break;

                case "porte":
                    Console.WriteLine(
@"Vous ressortez de la chambre froide.
La chaleur du magasin vous fait un bien fou après avoir été dans ce froid mortel.");
                    Game.Transition<Freezer>();
                    getFrozen = 0;
                    break;

                case "regarder":
                    getFrozen++;
                    Console.WriteLine(
@"En regardant ce que contient la chambre froide, vous pouvez voir au pied de la
table où est couché le [CADAVRE] des [VÊTEMENTS] qui semble hors du commun.");
                    break;

                case "vêtements":
                    getFrozen++;
                    Console.WriteLine(
@"Vous vous rapprochez du linge et remarquer qu'il ressemble à une tenue que vous
avez vue dans vos cours d'histoire. Ces vêtements sont exactement comme les uniformes
que portaient les soldats britanniques lors du 18e siècle.

Comment est-ce arrivé ici ?

En soulevant la tunique, un morceau de papier tombe d'une des poches. Un [MESSAGE]
semble être écrit dessus.");
                    break;

                case "message":
                    getFrozen++;
                    Console.WriteLine(
@"Le message est difficile à lire, mais vous arrivez à lire une partie :

¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
« Que Dieu me pardonne pour cette pensée, mais le champ boueux et le sifflement des
balles de la guerre commencent à me manquer. Le son silencieux de moteur et les corps
terrifiés sont pires que l'enfer.

J'ai vu la chose qui vit ici. Elle est pire que toutes les horreurs décrites dans la
Bible. Elle se promène avec ces créatures, des chiens difformes et démoniaques. Ils
semblent la craindre toute autant que moi. Ils semblent affamer ces pauvres bêtes.

Qu'est-ce que je raconte ? Me voilà à prendre en pitié ces démons.

Je ne sais pas depuis combien de temps je suis ici, ni combien de temps ça va durer.
J'ai dû me nourrir de ce qu'offrait ce magasin pour survivre, et je brûlerai sûrement
en enfer pour ce que j'ai mangé.

Parfois, je t'entends m'appeler maman. Je pense que cet endroit me rend fou. Ou est-ce
la Mort qui m'appelle ?

Tu me manques maman, j'aurais voulu m'excuser avant de partir pour la bataille.
J'aimerais te dire que je suis déso... »
_____________________________________________________________________________________

Le reste du texte est taché par le sang.");
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
