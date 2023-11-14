namespace ProjetNarratif.Rooms
{
    internal class Introduction : Room
    {
        internal override string CreateDescription() =>
@"
Vous vous réveillez dans une étrange endroit....";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice) 
            {
                default:
                    Game.Transition<Closet>();
                    break;
            }
        }
    }
}
