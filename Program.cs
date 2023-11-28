using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();

game.Add(new Introduction());
    game.Add(new Memor_IAOn());
game.Add(new Closet());
    game.Add(new OutCloset());
game.Add(new Cashier());
    game.Add(new MamaOlgaIsHere());
game.Add(new Freezer());
    game.Add(new IntoFreezer());
game.Add(new Phone());
game.Add(new Backstore());
    game.Add(new BackstoreWithDogs());
game.Add(new Butchery());
    game.Add(new HideAndSeek());


while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadLine();