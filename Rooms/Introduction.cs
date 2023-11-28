namespace ProjetNarratif.Rooms
{
    internal class Introduction : Room
    {
        internal static bool gameIsStarted;

        internal override string CreateDescription() =>
@"Ouvrir [MEMOR-IA]

 >> CLIQUEZ SUR N'IMPORTE QUELLE TOUCHE POUR COMMENCER À JOUER""";
/*@"
Le jeu que vous vous apprêtez à jouer est une version résumée d'un vieux projet
interactif que j'ai tenté de faire sur Instagram. J'ai ensuite eu l'intention de le
refaire en 3D, mais par manque de connaissances en matière de création de jeu 3D,
j'ai mis le projet en pause. Ce projet de jeu fait partie de plusieurs autres qui
sont tous liés au même univers (avec certains personnages qu'on revoit ou entend
parler dans d'autres jeux).


- Résumé du jeu -

Vous revivez les souvenirs d'Hugo Weston, un jeune ado de 14 ans qui se retrouve
coincé dans l'épicerie et de terrible et terrifiante de Mama Olga, appeler le « Meat
Store ». Vous devrez fouiller et trouver l'équipement nécessaire pour votre invasion
et votre survie.

- Mécaniques de jeu -

Les mots encadrés de [CROCHETS] signifient que vous pouvez interagir avec, y effectuer
une action ou vous y déplacer. Vous n'êtes pas obligé de l'écrire tout en majuscules,
mais pour le reste, n'oubliez pas d'écrire le mot EXACTEMENT comme il est écrit entre
les crochets.

Vous pouvez à tout moment utiliser votre Inventaire pour regarder tout ce que vous
avez collecté jusqu'à maintenant. Tout objet collecté peut être utilisé à n'importe
quel moment, mais ça ne veut pas dire que ça marchera tout le temps.

Une fois collecté, vous pourrez vous référer au Journal pour avoir des indices sur
ce qu'il faut que vous fassiez et comment survivre à certains problèmes que vous
devrez faire face. Vous collecterez aussi une Carte qui vous permettra de vous
déplacer dans les différentes zones du magasin.

Si vous mourez dans le jeu, ne vous inquiétez pas ! Vous aurez la possibilité de
revenir en arrière et d'éviter de faire la même erreur.


 >> CLIQUEZ SUR N'IMPORTE QUELLE TOUCHE POUR COMMENCER À JOUER";*/

        internal override void ReceiveChoice(string choice)
        {
            Console.Clear();
            Console.Write(
@"Bienvenu sur -/ MEMOR-IA /- 

Source : ");
            Thread.Sleep(1500);
            Console.Write("t");
            Thread.Sleep(0300);
            Console.Write("a");
            Thread.Sleep(0300);
            Console.Write("r");
            Thread.Sleep(0300);
            Console.Write("o");
            Thread.Sleep(0300);
            Console.Write("-");
            Thread.Sleep(0300);
            Console.Write("0");
            Thread.Sleep(0300);
            Console.Write("3");

            Console.Write(
@"
Recherche");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".\n");
            Thread.Sleep(1000);

            Console.WriteLine(
@"
(1/3) programme(s) prêt(s).
¯¯");
            Thread.Sleep(1000);
            Console.WriteLine(
@"programme 1 = Maria MIRANES (INCOMPLET)");
            Thread.Sleep(1000);
            Console.WriteLine(
@"programme 2 = Hugo WESTON (COMPLET)");
            Thread.Sleep(1000);
            Console.WriteLine(
@"programme 3 = ERROR_03C_16
");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".\n");
            Thread.Sleep(1000);

            Game.Transition<Memor_IAOn>();
        }
    }
}
