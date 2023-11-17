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
@"Vous arrivez face à 2 créatures canines. 

Leurs yeux, ainsi que certaines parties de leur corps, sont couverts par des
plaques de métal cloué directement à leur chaire. Leur mâchoire est plus longue,
leur nombre de dents plus nombreux et leur masse plus imposante que des chiens
normaux. Mais vous ne pouvez pas vous empêcher de remarquer qu'ils ont l'air
affamés et mal nourris.

Vous n'avez pas beaucoup de choix maintenant. Vous pouvez essayer de [COURIR]
ou de regarder dans votre [INVENTAIRE] si quelque chose pourrait vous aider.";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "courir":
                    Console.Clear();
                    Console.WriteLine(
@"Vous tentez de vous sauver, mais à la seconde où vous vous apprêtez à vous
retourner, vous sentez soudainement vos jambes et bras se déchiqueter par les
mâchoires de ces monstres.

Vous êtes secoué dans tous les sens et vous débattre est complètement futile.

Alors que vous ressentez votre corps disparaître à chaque bouchée prise par les
chiens, vous réalisez que c'est la fin pour vous... 

... Si prêt du but...


VOUS ÊTES MORT !

___________________________
Voulez-vous revenir en arrière ?
[OUI] | [NON]
");

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
@"Vous sortez de votre sac le tuyau en métal prit précédemment.

Vous vous mettez en garde et instantanément un des chiens vous saute dessus
avant que vous puissiez porter le premier coup. Vous tombez sur le dos, maintenant
le tuyau entre vous et la gueule qui essaie de vous dévorer. Mais en quelques
mâchouillements, vous êtes surpris de voir que le chien a réussi à gruger le tuyau
en deux.

Mais la surprise ne dur pas longtemps, lorsque vous réalisez que votre tête est à
l'intérieur d'une mâchoire prête à croquer.


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
@"Vous sortez lentement, sans mouvements brusques, le sac de viande que vous avez
ramassé précédemment.

Les chiens passent d'un état agressif, à curieux, puis enjoué à fur et à mesure
qu'ils réalisent ce qu'il y a dans le sac. Lorsque vous sortez le premier morceau,
les deux s'assirent immédiatement, leur queue montrant leur excitation.

Malgré la situation, vous ne pouvez vous empêcher de sourire à la vue de ces deux
monstres canidés qui agissent soudainement comme deux bons chiens attendant sagement
leur gâterie.

Vous lancez les morceaux de viande un à un, chaque fois attraper en plein air par un
des deux chiens.

Après avoir bien mangé, les deux paraient rassasiés et moins enclins à vous sauter à
la gorge.");
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
