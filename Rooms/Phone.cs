namespace ProjetNarratif.Rooms
{
    internal class Phone : Room
    {
        int choseQuestionAnswer;
        string toGo;
        int specialEvent = 0;
        bool eventHappen;
        bool isMetalBarCollected;

        internal override string CreateDescription() =>
@"";

        internal override void ReceiveChoice(string choice)
        {


            switch (choice) 
            {
                case "téléphone":
                    if (!Cashier.isCoinCollected)
                    {
                        Console.WriteLine(
@"");
                    }
                    else 
                    {
                        Console.WriteLine(
@"");
                        choseQuestionAnswer = Convert.ToInt32(Console.ReadLine());

                        switch (choseQuestionAnswer) 
                        {
                            case 1:
                                Console.WriteLine(
@"");
                                break;

                            case 2:
                                Console.WriteLine(
@"");
                                break;

                            case 3:
                                Console.WriteLine(
@"");
                                break;
                        }

                        Console.WriteLine(
@"");
                        choseQuestionAnswer = Convert.ToInt32(Console.ReadLine());

                        switch (choseQuestionAnswer)
                        {
                            case 1:
                                Console.WriteLine(
@"");
                                break;

                            case 2:
                                Console.WriteLine(
@"");
                                break;

                            case 3:
                                Console.WriteLine(
@"");
                                break;
                        }

                        Console.WriteLine(
@"");
                        choseQuestionAnswer = Convert.ToInt32(Console.ReadLine());

                        switch (choseQuestionAnswer)
                        {
                            case 1:
                                Console.WriteLine(
@"");
                                break;

                            case 2:
                                Console.WriteLine(
@"");
                                break;

                            case 3:
                                Console.WriteLine(
@"");
                                break;
                        }
                        specialEvent++;
                        Cashier.isCoinCollected = false;
                    }
                    break;

                case "tuyau":
                    Console.WriteLine(
@"");
                    if (!isMetalBarCollected)
                    {
                        Console.WriteLine(
@"");
                    }

                    isMetalBarCollected = true;
                    break;

                case "???":
                    if (eventHappen == true)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Commande invalide.");
                    }
                    break;

                case "carte":
                    Console.Clear();
                    Console.WriteLine(
@"Où voulez-vous allez?

Vous pouvez allez au [TÉLÉPHONE], à l'[ENTREPOT], à la [BOUCHERIE], dans le [CONGÉLATEUR],
au [PLACARD] ou rester à la [CAISSE].");
                    toGo = Console.ReadLine();

                    switch (toGo)
                    {
                        case "caisse":
                            Game.Transition<Cashier>();
                            break;

                        case "téléphone":
                            Game.Transition<Phone>();
                            break;

                        case "entrepot":
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
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
