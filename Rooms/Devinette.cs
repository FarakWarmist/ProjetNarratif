namespace ProjetNarratif.Rooms
{
    internal class Devinette : Room
    {
        int wrongAnswer ;
        internal override string CreateDescription()
        {
            switch (Game.wrongAnswer)
            {
                case 0:
                    return
@"
Je suis connu de presque tous et on sait à quoi je ressemble, mais personne ne ma jamais vue.
J'observe tout le monde pour qu'à un moment précis je décides s'ils sont bon au mauvais.
Je vous ressemble, mais je n'ai rien d'humain.
Qui suis-je ?
";

                case 1:
                    return
@"
Je suis connu de presque tous et on sait à quoi je ressemble, mais personne ne ma jamais vue.
J'observe tout le monde pour qu'à un moment précis je décides s'ils sont bon au mauvais.
Je vous ressemble, mais je n'ai rien d'humain.
Qui suis-je ?

Indice !
- Vous me laissez souvant de quoi boir et manger avant mon arrivez, comportant souvent des biscuits
  un verre de lait.
";

                case 2:
                    return
@"
Je suis connu de presque tous et on sait à quoi je ressemble, mais personne ne ma jamais vue.
J'observe tout le monde pour qu'à un moment précis je décides s'ils sont bon au mauvais.
Je vous ressemble, mais je n'ai rien d'humain.
Qui suis-je ?

Indice !
- Vous me laissez souvant de quoi boir et manger avant mon arrivez, comportant souvent des biscuits
  un verre de lait.
- Je m'incruste la nuit dans votre maison une fois par année, mais vous êtes content car au matin
  vous êtes récompencé par votre bon comportement.
";

                case 3:
                    return
@"
Je suis connu de presque tous et on sait à quoi je ressemble, mais personne ne ma jamais vue.
J'observe tout le monde pour qu'à un moment précis je décides s'ils sont bon au mauvais.
Je vous ressemble, mais je n'ai rien d'humain.
Qui suis-je ?

Indice !
- Vous me laissez souvant de quoi boir et manger avant mon arrivez, comportant souvent des biscuits
  un verre de lait.
- Je m'incruste la nuit dans votre maison une fois par année, mais vous êtes content car au matin
  vous êtes récompencé par votre bon comportement.
- Lors de ma fête, je suis celui qui vous offre les cadeaux.
";
                default:
                    return
                        @"";
            }
        }

        internal override void ReceiveChoice(string choice)
        {

            switch (choice)
            {
                case "père noël":
                    Console.WriteLine(
@"HO HO HO ! Vous m'avez reconnue !

Joyeux Noël !
");
                    Game.specialChristmas = false;
                    Game.Transition<Closet>();
                    break;

                default:
                    if (Game.wrongAnswer == 3)
                    {
                        Console.WriteLine(
@"Vous n'avez pas réussit à devinez qui était l'homme devant vous.
");
                        Game.Finish();
                    }
                    else
                    {
                        Console.WriteLine(
@"MAUVAISE RÉPONSE !
");
                        Game.wrongAnswer++;
                    }
                    break;
            }
        }
    }
}
