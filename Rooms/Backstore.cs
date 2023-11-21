namespace ProjetNarratif.Rooms
{
    internal class Backstore : Room
    {
        internal static string? petTheDogs;
        internal static bool comeBackForYou;

        internal override string CreateDescription() =>
@"
Les [CHIENS] maintenant calmés et rassasiés, vous analysez mieux le lieu dans lequel
vous êtes. Vous voyez un grand couloir allant de gauche à droite. Les murs sont remplis
de tuyaux et autres mécanismes.

Maintenant que vous y prêtez attention, vous ressentez des secousses et un gros bruit
lointain à chaque 30 secondes. Ce qui n'était pas le cas quand vous étiez à l'intérieur
du magasin.

Vous remarquez à [GAUCHE] quelque chose qui attire votre attention.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger
vers un autre endroit avec votre [CARTE].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "chiens":
                    Console.Clear();
                    Console.WriteLine(
@"Vous approchez les chiens avec prudence.

Lorsqu' ils vous remarquent, ils ne montrent aucun signe d'agressivité. Ils semblent 
même heureux que vous soyez encore là.

Il n'y a qu'une chose que vous voulez faire...

...");
                    Console.ReadKey();
                    Console.WriteLine(
@"

Voulez-vous flatter les chiens ?
[OUI] | [NON]
");

                    petTheDogs = Console.ReadLine().ToLower();
                    if (petTheDogs !="non")
                    {
                        Console.WriteLine(
@"Vous vous agenouillez à côté des deux chiens et leur caressez le cou. Il vous lèche
la main et la joue en remerciement.

Vous apercevez qu'ils ont, rattachés à leur nuque, une plaque de métal lié à une chaîne
accrochée au mur.

Pas étonnant qu'ils se montrent si agressifs. Ce monstre les torture et les affame.

« Je dois partir, mais je promets de revenir vous chercher dès que possible. »

En vous éloignant, ils laissent échapper ce qui ressemble à de petits jappements de
tristesse. Ce qui vous brise le coeur, mais vous n'avez pas le choix, vous devez
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
@"Vous allez dans le couloir de gauche et remarquer ce qui sera sûrement votre porte de
sortie.

Sur le sol, se trouve une énorme [TRAPPE] mécaniqe qui est ouvrable avec le tableau au
mur.");
                    break;

                case "trappe":
                    Console.Clear();
                    Console.WriteLine(
@"Vous activez la bouton de sur le tableau.

La gigantesque trappe s'ouvre, créant un gros son grave. Mais vous n'y prêter pas attention,
car vous êtes tétanisé par ce que vous voyez à l'extérieur.");

                    Console.ReadKey();
                    Console.WriteLine(
@"D'où vous êtes, vous arrivez à voir une énorme jambe mécanique, maintenant le magasin
à 300 mètres, si ce n'est plus, au-dessus du sol.

Et dehors... Vous n'avez jamais vu ça, même dans vos pires cauchemars. On dirait une plaine
fait d'os et de chair avec une légère brume rouge sang.");

                    Console.Clear();
                    Console.ReadKey();
                    Console.WriteLine(
@"Vous reprenez vos esprits lorsque vous réalisez que les 2 chiens jappent depuis un
moment.

En vous retournant, vous êtes face à la géante qui habite ces lieux. Alors qu'elle vous
assène un coup, vous avez le réflexe de reculer. Vous faisant ainsi perdre équilibre et
chuter.");

                    Console.Clear();
                    Console.ReadKey();
                    Console.WriteLine(
@"Le temps semble s'être ralenti durant votre chute. Pendant que vous observez l'horizon,
plusieurs choses vous passent par la tête.

Si vous ne vous étiez pas chicané avec votre mère ce soir-là. Vous voulez lui diriez que
vous êtes désolé et que vous l'aimez...

Qu'est-il arrivé à vos amis ?

Kim. Joseph. Jesse.

Vous les avez convaincus cette nuit-là d'aller dans le vieux magasin abandonné... Tout ça
pour quoi ?

Mais peu importe maintenant. La fin est proche.

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
@"Probablement dû à la matière du sol, vous avez réussi à survivre à cette chute qui
aurait dû vous tuer à coup sûr. Même si « survivre » n'est pas la meilleure description 
pour décrire votre état.

Vous avez la tête qui tourne et l'impression qu'on vous a brisé presque tous les os.
Vous ne sentez plus vos jambes. Vos oreilles sifflent et entendez à peine. Vous ne voyez
plus rien de votre oeil droit et votre oeil gauche voit flou. Votre bras gauche est
complètement écrasé. Mais votre bras droit est encore utilisable, même s'il est dans un
terrible état.");

                    Console.ReadKey();
                    Console.WriteLine(
@"
Vous entendez un faible son. Vous levez difficilement la tête pour voir... 

Non !

Elle ne pouvait pas simplement vous laisser mourir, cette sorcière voulait finir le
travail de ses mains.");

                    Console.ReadKey();
                    Console.WriteLine(
@"

Vous commencez à ramper à l'aide de votre bras et du peu de force que vous avez en réserve.
Mais elle vous rattrape, et ce, sans même essayer.

Avec la douleur et vos côtes qui transpercent vos poumons, vous tombez rapidement à court
de force. La créature se tient maintenant face à vous.

À ce moment, la première chose qui vous vient à l'esprit est votre mère.
Elle qui a déjà perdu son mari, elle va maintenant perdre son fils.

Alors, dans un dernier souffle, une dernière larme, vous chuchotez au vent...

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
@"Vous entendez faiblement le son rapide de pas qui s'approche rapidement à votre droite,
et vous ne semblez pas le seul. Mama Olga se retourne lentement en direction du son, quand
quelque chose lui porta un coup soudain, la propulsant vers la gauche.

La perte de sang vous fait tranquillement perdre connaissance. Avant que vous le réalisez,
vous êtes transporter par quelqu'un. Votre regard est complètement floue, vous n'arrivez
à voir qui s'est.

- « Accroche-toi ! On est presque arrivé ! Tiens le coup encore un peu ! »

Cette voix douce et forte est si rassurante. Après avoir été pris en enfer, voilà qu'un
ange est venu vous chercher. Quel soulagement.

« Ma... mère... d... dites-l...lui... je.... ss...ui... ...»

- « Non. Non non non non non. Reste éveillé ! Reste avec m... »

Le son s'évapore, jusqu'à ce qu'il reste plus rien...");

                        Console.Clear();
                        Console.WriteLine("...");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("...");
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine(
@"






























    a     a    
B      H      L");
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
@"Combien de temps ça fait déjà ?

Ça remonte à si loin, et pourtant aussi frais dans votre tête comme si c'était hier.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Ces portes semblent maintenant moins grandes, mais s'il reste encore assez massif.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous enfoncez vos griffes dans la fente entre les deux portes et l'ouvrez assez pour
passer.");
                            Console.ReadKey();
                            
                            Console.Clear();
                            Console.WriteLine(
@"Après tout ce temps, cet endroit n'a pas changé.");
                            Console.ReadKey();
                            Console.WriteLine(
@"

Vous vous rapprochez de la première caisse, ouvrez le tiroir et y déposez une trentaine
de pièces.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous remarquez le cadavre desséché qui se tient encore debout à la caisse voisine.

Vous prenez une des pièces dans la caisse et vous vous dirigez vers lui.

Vous lui déposez la pièce dans son tablier avant de lui donner une petite tape sur l'épaule
et d'aller vers le placard.");
                            Console.ReadKey();
                            
                            Console.Clear();
                            Console.WriteLine(
@"En ouvrant la porte, l'odeur vous ramène à votre première arrivée ici... Une vraie
horreur.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous sortez de votre manteau le journal et le déposer par terre avec un petit mot disant :

« Votre meilleur guide ! »");

                            Console.ReadKey();
                            Console.WriteLine(
@"Il est maintenant temps d'aller chercher ce qui vous a ramené ici.");
                            Console.ReadKey();
                            
                            Console.Clear();
                            Console.WriteLine(
@"Vous ouvrez la chambre froide et vous dirigez vers la porte du fond.
                            
Le cadenas a été renforcé, mais vous arrivez à l'arracher sans trop de mal.");
                            Console.ReadKey();
                            
                            Console.Clear();
                            Console.WriteLine(
@"
En ouvrant la porte, les 2 pauvres bêtes n'ont même pas la force de faire quoi que de
vous accueillir.");
                            Console.ReadKey();   
                            Console.WriteLine(
@"
Vous accourrez vers eux et sortez de gros morceaux de viande que vous leur donnez. Vous
leur flattez la tête pendant qu'ils mangent, les rassurant que tout va bien aller.

« Comment peut-elle vous traiter ainsi ?... » ");
                            Console.ReadKey();

                            Console.Clear();
                            Console.WriteLine(
@"Après avoir mangé et repris des forces, ils ont enfin l'énergie de vous remercier et
de montrer leur joie de vous revoir.

« Je suis content de vous revoir aussi ! Je n'allais pas vous laisser ici. »");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous brisez les chaînes qui les maintenaient ici et vous vous relevez.

« Allez, il est temps d'y aller. »");

                            Console.ReadKey();

                            Console.Clear();
                            Console.WriteLine(
@"Vous ressortez de la chambre froide en direction de la zone des caisses, accompagné de
vos deux nouveaux compagnons.");

                            Console.ReadKey();
                            Console.WriteLine(
@"
Une fois devant la porte par laquelle vous êtes venue, vous vous apprêtez à partir.
Soudainement, vous entendez un cri difforme provenant de plus loin dans le magasin...");
                            Console.ReadKey();
                            Console.WriteLine(
@"
Vous hésitez.");
                            Console.ReadKey();
                            Console.WriteLine(
@"
L'un des deux chiens attire votre attention en frottant son museau sur votre main. Comme s'il
savait que quelque chose vous tracassait.

Vous pouvez le voir. Ils veulent partir d'ici.

Cet endroit n'a pas dû être une vraie partie de plaisir pour eux aussi...");
                            Console.ReadKey();
                            Console.WriteLine(
@"
 ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    Console.WriteLine(
@"

    MERCI D'AVOIR JOUÉ !
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
