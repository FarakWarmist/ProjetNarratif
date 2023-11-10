using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class MamaOlgaIsHere : Room
    {
        internal override string CreateDescription() =>
@"
Vous prenez la pièce. Mais au même moment, une secousse fait trambler le sol, la 
poussière tombe du plafond et le son de moteur s'arrête. De grandes lumières jaunâtres
se mettent à s'allumer, vous aveuglant au même moment.

Vous êtes en panique ! Qu'est-ce qui se passe ?!

Vous tenter de regardez les alentours maintenant que toute est éclairer. Et vous
réalisez avec peur que cette endroit et gigatesque. Les étagères montent à presque 
20 mètres de haut et un autre bon 8 mètres doit les séparer du plafond.

« Mais où je suis ?... »

Alors qu'un grand sentiment d'angoisse vous sumerge, vous entendez la porte dans le coin
souvrir l'entement. Quelquechose arrive !

Vous n'avez pas beaucoup de temps ! Vous pouvez vous [CACHER] ou [COURIR].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cacher":
                    Console.Clear();
                    Console.WriteLine(
@"Vous décidez de vous cachez sous la caisse.
Vous entendez le méchanisme des portes s'arrêter, suivit par le son
de lourd pas.
");
                    Console.WriteLine(
@"Le bruit se raproche de vous. Vous mettez vos mains sur votre
bouche et votre nez pour couvrir votre respiration.
");
                    Console.WriteLine(
@"La chose s'arrête juste devant vous, vous permettant de voir
sa botte avec le bout recouvert d'une plaque de métal avec
des pointes ensanglantées. Juste un pied suffirait à vous
nécrasez la moitié du corps.
");
                    Console.WriteLine(
@"Vous pouvez l'entendre faire une grognement étouffé... Puis
continue son chemain. Vous laissant appercevoir le cadavre
d'une créature humanoïde dont la moitier de la tête lu manque.
Laissant derrière une énorme tracé de sang noir.
");
                    Console.WriteLine(
@"Vous comprennez que cette endroit est dangeureux et que
vous devez vite trouvez un moyen de vous échaper.
Vous regardez la pièce dans votre main et décidez de la
garder. Elle vous sera peut-être utile.

[PIÈCE] rajouté à votre inventaire.
");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Transition<Cashier>();
                    break;

                case "courir":
                    Console.Clear();
                    Console.WriteLine(
@"Dans la panique, vous décidez de courir !

Il ne faut pas beaucoup de temps à la créature avant de vous
remarquez. Vous entendez derière vous un bruit de chaines qui
s'entre choque. 

Et alors que vous allez pour faire un virage et semer le
monstre, vous entendez un *CLING!* et tombez au sol avec une
grande douleur au niveau de votre jambe droite.
");
                    Console.WriteLine(
@"Vous regardez lentement, avec hésitation, derière vous. Vous
réaliser avec terreur qu'une machoire de métal, ressemblant à
un piège à ours rouillé, rattachée à une chaine a pris au piège
la totalité de votre jambe.

Vous êtes soudainement tiré !

La douleur est insuportable et vous ne pouvez vous empécher de
crier et appeler à l'aide.
");

                    Console.WriteLine(
@"Lorsque vous la chaine cesse de vous tirer, vous lever les yeux.
La dernière chose que vous voyez, est le hachoire s'enfonçant
dans votre tête.

VOUS ÊTES MORT
");
                    Game.Finish();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
