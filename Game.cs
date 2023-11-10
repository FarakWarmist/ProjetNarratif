﻿using ProjetNarratif.Rooms;

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
                Console.WriteLine("- [TUYAU]");
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
