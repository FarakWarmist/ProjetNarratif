namespace ProjetNarratif.Rooms
{
    internal class Introduction : Room
    {
        internal override string CreateDescription() =>
@"Un étrange épouventail se tient au loin devant un vieux arbre mort noir comme le charbon,
au millieu d'un champ de pierre tombale qui sétant jusqu'à l'horizon.
derrière l'arbre, une énorme éclipse solaire dans un ciel rouge ourangé vous donne
le sentiment d'un œil qui vous observe jusqu'au tréfond de votre âme.

L'épouventail lève lentement la tête pour vous regarder. Malgrés la distance qui vous séparre,
vous pouvez l'entendre vous chuchotter...

« Réveille... toi... »

Et vous reprenez connaissance.
";

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
