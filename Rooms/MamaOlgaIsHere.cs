using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class MamaOlgaIsHere : Room
    {
        internal static string ? toDo;

        internal override string CreateDescription() =>
@"
Vous prenez la pièce. Mais au même moment, une secousse fait trembler le sol,
la poussière tombe du plafond et le son de moteur s'arrête. De grandes lumières
jaunâtres se mettent à s'allumer, vous aveuglant au même moment.

Vous êtes en panique ! Qu'est-ce qui se passe ?!

Vous tentez de regarder les alentours maintenant que tout est éclairé. Vous
vous rendez maintenant compte de l'ampleur de cet endroit et gigantesque. Les
étagères montent à presque 20 mètres de haut et un autre bon 8 mètres doit les
séparer du plafond.

« C'est quoi cet endroit ?... »

Alors qu'un grand sentiment d'angoisse vous submerge, vous entendez la porte
dans le coin s'ouvrir lentement.

Quelque chose arrive !

Vous n'avez pas beaucoup de temps ! Vous pouvez vous [CACHER] ou [COURIR].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cacher":
                    Console.Clear();
                    Console.WriteLine(
@"Vous décidez de vous cacher sous la caisse.

Vous entendez le mécanisme des portes s'arrêter, suivi par le son
de lourd pas.
");
                    Console.WriteLine(
@"Le bruit se raprpoche de vous. Vous mettez vos mains sur votre
bouche et votre nez pour couvrir votre respiration.
");
                    Console.WriteLine(
@"La chose s'arrête juste devant vous, vous permettant de voir sa
botte avec l'extrémité recouverte d'une plaque de métal comportant
des pointes ensanglantées. Juste un pied suffirait à vous écraser
la moitié du corps.
");
                    Console.WriteLine(
@"Vous pouvez l'entendre faire un grognement étouffé... Puis
continue son chemin. Vous voyez qu'elle traîne avec elle le cadavre
d'une créature humanoïde dont la moitié de la tête lui manque.
Laissant derrière une énorme tracée de sang noir.
");
                    Console.WriteLine(
@"Vous comprenez que cet endroit est dangeureux et que vous devez vite
trouver un moyen de vous échapper.

Vous regardez la pièce dans votre main et décidez de la garder. Elle
vous sera peut-être utile.

[PIÈCE] rajouté à votre inventaire.
");
                    Console.ReadKey();
                    Cashier.isCoinCollected = true;
                    Cashier.lightsOn = true;
                    Console.Clear();
                    Game.Transition<Cashier>();
                    break;

                case "courir":
                    Console.Clear();
                    Console.WriteLine(
@"Dans la panique, vous décidez de courir ! Il ne faut pas beaucoup
de temps à la créature avant de vous remarquer. 

Vous entendez derrière vous un bruit de chaînes qui s'entrechoquent. 

Et alors que vous allez pour faire un virage et semer le monstre, vous
entendez un *CLING !* et tombez au sol avec une grande douleur au niveau
de votre jambe droite.
");
                    Console.WriteLine(
@"Vous regardez lentement, avec hésitation, derrière vous. Vous réalisez
avec terreur qu'une mâchoire de métal, ressemblant à un piège à ours
rouillé, rattachée à une chaîne a pris au piège la totalité de votre
jambe !

Vous êtes alors soudainement tiré !

La douleur est insupportable et vous ne pouvez vous empêcher de crier et
d'appeler à l'aide.
");

                    Console.WriteLine(
@"Lorsque la chaine cesse de vous tirer, vous lever les yeux. Mais la
seule chose que vous voyez est un hachoir s'enfonçant dans votre tête.

VOUS ÊTES MORT

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]
");
                    toDo = Console.ReadLine().ToLower();
                    if (toDo != "non")
                    {
                        Console.Clear();
                        Game.Transition<Cashier>();
                    }
                    else
                    {
                        Game.Finish();
                    }
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}