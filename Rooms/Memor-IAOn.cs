using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ProjetNarratif.Rooms
{
    internal class Memor_IAOn : Room
    {
        internal static int chosenProgram;
        internal static string ? exit;

        internal override string CreateDescription()
        {
            if (!Introduction.gameIsStarted)
            {
                Introduction.gameIsStarted = true;

                return
@"> [COMMENCER]
> [TUTORIEL]
> [DATA]
> [QUITTER]

¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            }
            else
            {
                return
@"Bienvenu sur -/ MEMOR-IA /-

Source : taro-03
Recherche...

(1/3) programme(s) prêt(s).
¯¯
programme 1 = Maria MIRANES (INCOMPLET)
programme 2 = Hugo WESTON (COMPLET)
programme 3 = ERROR_03C_16

...
--
> [COMMENCER]
> [TUTORIEL]
> [DATA]
> [QUITTER]

¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "commencer":
                    Console.Clear();
                    Console.WriteLine(
@"Choix du sujet:
[1] Maria MIRANES (INCOMPLET)
[2] Hugo WESTON (COMPLET)
[3] INCONNU
");
                    chosenProgram = Convert.ToInt32(Console.ReadLine());
                    switch (chosenProgram)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(
@"Lancement du programme MariaMIRANES");
                            Thread.Sleep(1000);
                            Console.WriteLine(
@"...... 8%");
                            Thread.Sleep(1200);
                            Console.WriteLine(
@"...... 27%");
                            Thread.Sleep(1300);
                            Console.WriteLine(
@"...... 32%");
                            Thread.Sleep(1000);
                            Console.WriteLine(
@"...... 57%");
                            Thread.Sleep(1500);
                            Console.WriteLine(
@"ERROR");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine(
@"Lancement du programme HugoWESTON");
                            Thread.Sleep(1000);
                            Console.WriteLine(
@"...... 15%");
                            Thread.Sleep(1200);
                            Console.WriteLine(
@"...... 47%");
                            Thread.Sleep(1300);
                            Console.WriteLine(
@"...... 83%");
                            Thread.Sleep(1000);
                            Console.WriteLine(
@"...... 99%");
                            Thread.Sleep(1500);
                            Console.WriteLine(
@"PROGRAMME PRÊT !");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Game.Transition<Closet>();
                            break;

                        case 3:

                            break;

                        default:
                            Console.WriteLine("Commande invalide.");
                            break;
                    }
                    break;

                case "tutoriel":
                    Console.Clear();
                    Console.WriteLine(
@"Les mots encadrés de[CROCHETS] signifient que vous pouvez interagir avec, y effectuer
une action ou vous y déplacer.Vous n'êtes pas obligé de l'écrire tout en majuscules,
mais pour le reste, n'oubliez pas d'écrire le mot EXACTEMENT comme il est écrit entre
les crochets.

Vous pouvez à tout moment utiliser votre Inventaire pour regarder tout ce que vous
avez collecté jusqu'à maintenant. Tout objet collecté peut être utilisé à n'importe
quel moment, mais ça ne veut pas dire que ça marchera tout le temps.

Une fois collecté, vous pourrez vous référer au JOURNAL pour avoir des indices sur
ce qu'il faut que vous fassiez et comment survivre à certains problèmes que vous
devrez faire face.Vous collecterez aussi une CARTE qui vous permettra de vous
déplacer dans les différentes zones du magasin.

Si vous mourez dans le jeu, ne vous inquiétez pas! Vous aurez la possibilité de
revenir en arrière et d'éviter de faire la même erreur.

 >> CLIQUEZ SUR N'IMPORTE QUELLE TOUCHE POUR REVENIR AU MENU");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "quitter":
                    Console.Clear();
                    Console.WriteLine(
@"Voulez-vous vraiment quitter?
[OUI] | [NON]
");
                    exit = Console.ReadLine().ToLower();

                    if (exit == "oui")
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
