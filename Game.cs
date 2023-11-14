using ProjetNarratif.Rooms;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Room> rooms = new();
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";

        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            currentRoom.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    break;
                }
            }
        }

        internal static void HideAndSeekGame(int eventStage)
        {
            switch (eventStage)
            {
                case 1:
                    Console.WriteLine(
@"Vous arrivez à vous cacher de justest !

Vous observez une femme au corps grand et massif à la peau rosé avec des marque de brûlures
et des blessures brochées. Elle a de long cheveux argentés en pointe. Autour de son cou se
trouve trois crâne humain ratacher à une corde et porte un masque de métal encastré sur son
visage. Malgré son apparence humanoïde, vous sentez que cette chose est tout sauf humaine.

D'une simple main, elle dégage les boyaux trainant sur l'ilot, étant une nape en jute et 
pose plusieurs corps dessus.

Elle se déplace. Où voulez-vous vous cacher ? Derrière l'[ILOT], la [POUBELLE], le [LAVABO],
l'[ÉTAGÈRE] à outils ou le [PLACARD]?");
                    break;

                case 2:
                    Console.WriteLine(
@"Vous êtes de nouveau à couvert.

La créature ouvre son placard à outils et sélection divers instrument de boucher et revient
à l'îlot. Vous détourner immédiatement le regard lorsqu'elle se met à découper les corps.
Après un moment, elle pose quelques choses dans un panier et referme la nappe de jute.

Elle se déplace de nouveau. Où voulez-vous vous cacher ? Derrière l'[ILOT], la [POUBELLE],
le [LAVABO], l'[ÉTAGÈRE] à outils ou le [PLACARD]?");
                    break;

                case 3:
                    Console.WriteLine(
@"Vous n'avez toujours pas été repéré.

Vous la voyez mettre la nape remplie des restes dans la poubelle et revient à l'ilot pour
prendre ses outils ensanglantés.

Elle se déplace une fois de plus. Où voulez-vous vous cacher ? Derrière l'[ILOT], la
[POUBELLE], le [LAVABO], l'[ÉTAGÈRE] à outils ou le [PLACARD]?");
                    break;

                case 4:
                    Console.WriteLine(
@"Toujours cachez, vous regardez la créature ramener ses instruments de bouchers
couverent de sang au lavabo et commencé à les lavées. Vous êtes surpris à l'entendre 
soudainement chantonner une berceuse d'une voix douce et rassurant. Dans la panique,
vous n'arrivez pas à reconnaître la langue dans laquelle elle la chante.

Elle vas bientôt bouger. Où voulez-vous vous cacher ? Derrière l'[ILOT], la [POUBELLE],
le [LAVABO], l'[ÉTAGÈRE] à outils ou le [PLACARD]?");
                    break;

                case 5:
                    Console.WriteLine(
@"Elle ne vous à pas encore vue.

Vous pouvez la voir marcher l'entement jusqu'au placard en métal, l'ouvrir et y mettre un
[TROUSSEAU DE CLÉS] à l'intérieur. Elle prend ensuite le panier et s'en va de la pièce.
Un moment passe avant que vous ayez le courrage de vous relever.

Vous pouvez [REGARDER] les alentours, regarder votre [INVENTAIRE] ou vous diriger vers un
autre endroit avec votre [CARTE].");
                    hideEvent++;
                    break;
            }
        }

        internal static void Journal()
        {
            Console.WriteLine(
@"Le journal est rempli de notes et de gribouillis.

Un dessin d'un téléphone avec à côté une pièce de monnaie avec une flèche pointant vers
« Caisse n°1 »

Un autre montre deux chiens qui regardent avec des cœurs un gigot qui pointe avec une
flèche « Petit congélateur »

Un plan d'une pièce qui montre cinq dessins d'un petit monstre étiquetés de 1 à 5.
Le premier se tient au milieu de la pièce.
Le deuxième semble avoir des couteaux dans les mains et se tient devant un meuble.
Le troisième tient un sac ensanglanté jusqu'à une poubelle.
Le quatrième montre le monstre laver ses couteaux.
Et le cinquième est le monstre qui pose un trousseau de clé dans un placard.
Le trousseau est encerclé et une flèche pointe un cadenas bleu et blanc.");
        }

        internal static void Inventory()
        {
            Console.WriteLine(
@"Vous avez :");
            if (Closet.isKeyCollected)
            {
                Console.WriteLine("- [CLÉ DU PLACARD]");
            }
            if (Closet.isLogbookCollected)
            {
                Console.WriteLine("- [JOURNAL]");
            }
            if (Closet.isFlashlightCollected)
            {
                Console.WriteLine("- [LAMPE DE POCHE]");
            }
            if (Closet.isMapCollected)
            {
                Console.WriteLine("- [CARTE]");
            }
            if (Cashier.isCoinCollected)
            {
                Console.WriteLine("- [PIÈCE]");
            }
            if (Phone.isMetalBarCollected)
            {
                Console.WriteLine("- [TUYAU]");
            }
            if (Freezer.isMeatCollected)
            {
                Console.WriteLine("- [VIANDE]");
            }
            if (IntoFreezer.isLeadBulletsCollected)
            {
                Console.WriteLine("- [BALLES EN PLOMB]");
            }
            if (Butchery.isBunchOfKeysCollected)
            {
                Console.WriteLine("- [TROUSSEAU DE CLÉS]");
            }

        }

        internal static void MapDestination()
        {
            string ? toGo;
            Console.Clear();
            Console.WriteLine(
@"Où voulez-vous allez?

Vous pouvez aller au [TÉLÉPHONE], à l'[ENTREPÔT], à la [BOUCHERIE], dans le [CONGÉLATEUR],
au [PLACARD] ou rester à la [CAISSE].");
            toGo = Console.ReadLine().ToLower();

            switch (toGo)
            {
                case "caisse":
                    Game.Transition<Cashier>();
                    break;

                case "téléphone":
                    Game.Transition<Phone>();
                    break;

                case "entrepôt":
                    Game.Transition<Backstore>();
                    break;

                case "boucherie":
                    Game.Transition<Butchery>();
                    break;

                case "congélateur":
                    Game.Transition<Freezer>();
                    break;

                case "placard":
                    Game.Transition<Closet>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
