namespace ProjetNarratif.Rooms
{
    internal class Backstore : Room
    {
        internal static string? petTheDogs;
        internal static bool comeBackForYou;

        internal override string CreateDescription() =>
@"
Les [CHIENS] maintenant calmés et rasasiés, analyser mieux le lieu dans le quelle vous
êtes. Vous voyez un grand couloir allant de gauche à droite. Les mur sont remplie de tuyaux
et autre méchanisme. Maintenant que vous y prêtez attention, vous ressentez des secouse et
un gros bruit lointaint à chaque 30 secondes. Ce qui n'était pas le cas quand vous étiez à
l'intérieur du magasin.

Vous remarquez à [GAUCHE] quelque chose qui attire votre attention.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger vers un autre
endroit avec votre [CARTE].""
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "chiens":
                    Console.Clear();
                    Console.WriteLine(
@"Vous approchez les chiens avec prudence.

Lorsque il vous remarque, ils ne montrent aucun signe d'agressivité. Ils semble même
heureux que vous soyez encore là.

Il n'y a qu'une chose que vous voulez faire...

...


Voulez-vous flatter les chien?
[OUI] | [NON]");

                    petTheDogs = Console.ReadLine().ToLower();
                    if (petTheDogs !="non")
                    {
                        Console.WriteLine(
@"Vous vous agenouillez à coté des deux chiens et leur caressez le cou. Il vous lèche la
main et la joue en remerciment.

Vous appercevez qu'ils ont rattaché à leur nuque une plaque de métale lié à une chaine
accrocher au mur. Pas étonant qu'ils se montrent si agressifs, ce monstre les tortures et
les affame.

« Je dois partir, mais je promets de revenir vous cherchez dès que possible. »

En vous éloigant, ils laissent s'échapper ce qui ressemble à des petits jappements de
tristesse. Ce qui vous brise le cœur, mais vous n'avez pas le choix, vous devez
partir.");          
                        comeBackForYou = true;
                    }
                    else
                    {
                        Console.WriteLine(
@"Non, vous n'avez pas le temps pour ça. Vous devez sortir d'ici.");
                    }
                    break;

                case "gauche":
                    Console.WriteLine(
@"Vous allez dans le couloir de gauche et remarquer ce qui sera surement votre porte de sorti.

Sur le sol se trouve une énorme [TRAPPE] méchaniqe qui est ouvrable avec le tableau au mur.");
                    break;

                case "trappe":
                    Console.Clear();
                    Console.WriteLine(
@"Vous activez la boutton de sur le tableau.

La gigantesque trappe souvre crant un gros son grave. Mais vous n'y prêter pas attention, car
vous êtes tétanisé par ce que vous voyez à l'extérieur.

De où vous êtes, vous arrivez à voir une énorme jambe méchanique, maintenant la maison à 300
mètres, si ce n'est plus, au-dessus du sol. Et dehors... Vous n'avez jamais vus ça, même dans
vos pire cauchemerd.

On dirait une forait fait d'os et de chaire avec une légère brume rouge sang.


Vous reprenez vos esprit lorsque vous réalisez que les 2 chiens jappe depuis un moment. En
vous retournant, vous êtes face à la créature qui habite ce lieu. Alors qu'elle vous assene
un coup, vous avez le réflex de reculer. Vous faisant ainsi perdre équilibre et chuter.

Le temps semble s'être ralentit durant votre chute. Plusieurs chose vous passe par la tête:
Si vous ne seriez pas chicanné avec votre mère ce soir là, vous lui diriez que vous êtes
désolé et que vous l'aimez... Qu'est-il arrivez à vos amis ? Kim. Joseph. Jesse. Vous les
avez convaincu cette nuit là d'allez dans le vieux magasin abandonné...

Tout semble si paisible maintenant...");

                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("...");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("Vous avez... mal?");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("Vous êtes... vivant?");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine(
@"Probablement du à la matière du sol, vous avez réussit à survivre à cette chute qui
aurait du vous tuer à coup sûr. Même si « survivre » n'est pas la meilleur description 
pour décrire votre état.

Vous avez la tête qui tourne. Vous avez l'impression qu'on a brisez presque tout les os.
Vous ne sentez plus vos jambe. Vos oreilles sifllent et vous entendez à peine.Seul Vous ne
voyez plus rien de votre œil droit et votre œil gauche voie floue. Votre bras gauche est
complètement écrasé. Mais votre bras drois est encore utilisable, même s'il est dans un
térrible état.

Vous entendez un faible son. Vous levez difficilement la tête pour voir... Non !
Elle ne pouvait pas simplement vous laissez mourir, cette sorcière voulait finir le
travail de ses mains.

Vous commencez à ramper à l'aide de d'un bras et du peu de force que vous avez en réserve.
Mais elle vous rattrape, et ce sans même essayer.

Avec la douleur et vos côtes qui transperce vos poumons, vous tombez rapidement à court de
force. Et la créature se tient maintenant face à vous.

À ce moment, la première chose qui vous vient à l'esprit est votre mère.
Elle qui a déjà perdu son amant vas maintenant perdre son fils.
Alors, dans un dernier souffle, une dernière larme, vous chuchottez au vent...

« Je suis désolé... »");

                    Console.ReadKey();

                    if (!Phone.alreadyTalk)
                    {
                        Console.Clear();
                        Console.WriteLine(
@"

    MAUVAISE FIN - BIENVENUE DANS LA FAMILLE
");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(
@"Vous remarquez le son rapide de pas qui approche à votre droite, et vous ne semblez pas
le seul. Mama Olga se retourne lentement en direction du son quand quelque chose lui porta
un coup soudant la propulsant vers la gauche.

La perte de sang vous fait tranquillement perdre connaissance. Avant que vous le réalisez,
vous êtes transporter par quelqu'un. Votre regard est complètement floue, vous n'arrivez
à voir qui s'est.

- « Accroche-toi ! On est presque arrivé ! Tiens le coup encore un peu ! »

Cette voix douce et forte est si rassurante. Après avoir été pris en enfer, voilà qu'un ange
est venu vous chercher. Quel soulagement.

« Ma... mère... d... dites-l...lui... que... je.... ss...ui... ...»

- « Non. Non non non non non. Reste éveillé ! Reste avec m... »

le son s'évapore, jusqu'à ce qu'il reste plus rien....");

                        Console.Clear();
                        Console.WriteLine("...");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("...");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine(
@"































H   u  N    t  E    r");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine(
@"

    VRAI FIN - PASSER UN CONTRACT
");

                        if (comeBackForYou == true)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.ReadKey();

                            Console.Clear();
                            Console.WriteLine(
@"Combien de temps ça fait déjà?

Ça remonte à si loin, et pourtant aussi frais dans votre tête comme si c'était hier");

                            Console.Clear();
                            Console.WriteLine("...");
                            Console.ReadKey();

                            Console.WriteLine(
@"Ces portes semble maintent moins grandes, mais s'il reste assez massive");
                            Console.ReadKey();
                            Console.WriteLine(
@"Vous enfossez vos griffes dans la fente entre les deux portes et l'ouvrez assez pour passer.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(
@"Après tout ce temps, cette endroit n'a pas changer.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(
@"Vous vous raprochez de la première caisses, ouvrez le tiroir et y déposé un trentaine de pièce.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous remarquez le cadavre désècher qui se tient encore debout à la caisse voisine. Vous prenez
une des pièces dans la caisse et vous vous dirigez vers lui.

Vous lui déposez la pièce dans son tablier avant de lui donner une petite tape sur l'épaule et
d'aller vers le placard.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(
@"En ouvrant la porte, l'odeur vous ramène à votre première arrivez ici... Une vrai horreur.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous sortez de votre manteau le journal et le déposer par terre avec un petit mot disant :

« Votre meilleir guide ! »");

                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(
@"Il est maintenant temps d'aller chercher ce qui vous amène ici.");

                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(
@"Vous ouvrez la chambre froide et vous dirigez vers la porte du fond.

Le cadenas à été renforcé, mais vous arriver à l'arracher sans trop de mal.");

                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(
@"En ouvrant la porte, les 2 pauvres bêtes n'ont même pas la force de faire quoi que ce soit.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(
@"En ouvrant la porte, les 2 pauvres bêtes n'ont même pas la force de faire quoi que ce soit.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous accourrez vers eux et sortez de gros morceaux de viande que vous leur donnez. Vous leur
flattez la tête pendant qu'ils mangent.

« Comment peut-elle vous traiter ansin ?... » ");

                            Console.ReadKey();
                            Console.WriteLine(
@"
Après avoir mangés, ils ont repris en force et on l'énergie de remercier leur sauveur.

« Je suis content de vous revoir aussi ! Je n'allais pas vous laissez là. »");

                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous brisez les chaines qui les maintenait ici.

« Allez ! Il est temps d'y aller. »");

                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(
@"Vous revenez jusqu'à la caisse accompagné de vos deux nouveau compagnon.");

                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous ouvrez la porte et entendez un cri difforme provenant de plus loin dans le magasin...

Vous hésitez.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
L'un des chiens attire votre attention en frottant son museau sur votre main.

Vous pouvez le voir. Ils veulent partir d'ici.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
« Vous avez raison. Ne tardons pas ici plus longtemps... On y vas");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    Console.WriteLine(
@"

    MERCI D'AVOIR JOUÉ
");

                    break;

                case "regarder":
                    Console.WriteLine(
@"");
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
