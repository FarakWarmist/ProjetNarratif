using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class BackstoreWithDogs : Room
    {
        internal static bool friendlyDogs;
        internal static string? toDo;

        internal override string CreateDescription() =>
@"Vous arrivez face à 2 créature canine. Leurs yeux, ainsi que cetaine partie de leur corps,
sont couvert par des plaques de métal cloué directement à leur chaire. Leur machoir sont plus
long, leurs de dents plus nombreux et leur masse plus imposant que des chiens normaux. Mais
vous pouvez pas vous empêcher de remarquer qu'ils ont l'aire affamé et mal nourrie.

Vous n'avez pas beaucoup de choix maintenant. Vous pouvez essayer des [COURIR] ou de
regardez votre [INVENTAIRE] si quelque chose pourrait vous aidez.";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "courir":
                    Console.Clear();
                    Console.WriteLine(
@"Vous tentez de vous sauvez, mais à la seconde où vous vous appraîtez à vous retourner,
vous sentez vos jambes et bras se déchiqueter par les machoires de ses monstres.

Vous êtes secouez dans tout les senses et vous débattre et complètement futile.

Alors que vous ressentez votre corps disparaître à chaque bouchez que prennent ces
chiens, vous réalisez que vous allez mourir... Si prêt du but...


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
                                Game.Transition<IntoFreezer>();
                            }
                    break;
                
                case "tuyau":
                    if (!Phone.isMetalBarCollected)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(
@"Vous sortez de votre sac le tuyau en métal prit précédement.

Vous vous mettez en garde et instatanément un des chiens vous saute dessus avant que vous
puissiez porter le premier coup. Vous tombez sur le dos, maintenant le tuyau entre vous et
la geule qui essait de vous dévorer. Mais en quelque machouillement, vous êtes surpris de
voir que le chien a réussit à gruger le tuyau en deux.

Mais la surprise ne dur pas longtemps, lorsque vous réalisez que vous êtes à l'intérieu d'un
machoire prêt à croquer.


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
                            Game.Transition<IntoFreezer>();
                        }
                    }
                    break;

                case "viande":
                    if (!Freezer.isMeatCollected)
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    else
                    {
                        Console.WriteLine(
@"Vous sortez lentement, sans mouvement brusque, le sac de viande que vous avez ramassez
précédement.

Les chiens passent d'un état aggressif, à curieux, puis enjoué à fur et à mesure qu'il
réalise ce qu'il y a dans le sac.

Lorsque vous sortez le premier morceau, les deux se sassirent immédiatement, leur queue
montrant leur exitation. Malgrés la situation, vous pouvez vous empêcher de sourir de
joie face à ces deux monstres canidés qui agissent soudainement comme deux chiens
attendant sagement leur gaterie.

Vous lancez les morceaux de viande un a un, avec à chaque fois un des deux monstres qui
finissait par l'attraper en plaine air. Après avoir bien mangée, les deux paraît
rasasier et moins enclin à vous sauter à la gorge.");
                        friendlyDogs = true;
                        Freezer.isMeatCollected = false;
                        Game.Transition<Backstore>();
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
