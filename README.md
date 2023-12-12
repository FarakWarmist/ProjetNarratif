ProjetNarratif - Par William Sylvestre

Le jeu que vous vous apprêtez à jouer est une version résumée d'un vieux projet interactif que j'ai tenté de faire sur Instagram. J'ai ensuite eu l'intention de le refaire en 3D, mais par manque de connaissances en matière de création de jeu 3D, j'ai mis le projet en pause. Ce projet de jeu fait partie de plusieurs autres qui sont tous liés au même univers (avec certains personnages qu'on revoit ou entend parler dans d'autres jeux).


- Résumé du jeu -

Vous revivez les souvenirs d'Hugo Weston, un jeune ado de 14 ans qui se retrouve coincé dans l'épicerie et de terrible et terrifiante de Mama Olga, appeler le Meat Store. Vous devrez fouiller et trouver l'équipement nécessaire pour votre invasion et votre survie.

Durant vos recherches, vous pourrez en apprendre plus sur où vous êtes exactement, qu'est-ce qui vous a amené ici et comment ce monde fonctionne. Il sera à vous de savoir où chercher et utiliser le bon objet au bon endroit.

Le jeu comporte 2 fins principales et un épilogue secret.

--------------------------------------------------------------

- Le rajout d'inventaire, permettant de collecter et voir ce que le joueur a collecté.
Game.cs
Ligne 181 à 222

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
____________

- Une petite cinématique d'introduction.
Introduction.cs
Ligne 49 à 107

        internal override void ReceiveChoice(string choice)
        {
            Console.Clear();
            Console.Write(
@"Bienvenu sur -/ MEMOR-IA /- 

Source : ");
            Thread.Sleep(1500);
            Console.Write("t");
            Thread.Sleep(0300);
            Console.Write("a");
            Thread.Sleep(0300);
            Console.Write("r");
            Thread.Sleep(0300);
            Console.Write("o");
            Thread.Sleep(0300);
            Console.Write("-");
            Thread.Sleep(0300);
            Console.Write("0");
            Thread.Sleep(0300);
            Console.Write("3");

            Console.Write(
@"
Recherche");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".\n");
            Thread.Sleep(1000);

            Console.WriteLine(
@"
(1/3) programme(s) prêt(s).
¯¯");
            Thread.Sleep(1000);
            Console.WriteLine(
@"programme 1 = Maria MIRANES (INCOMPLET)");
            Thread.Sleep(1000);
            Console.WriteLine(
@"programme 2 = Hugo WESTON (COMPLET)");
            Thread.Sleep(1000);
            Console.WriteLine(
@"programme 3 = ERROR_03C_16
");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".\n");
            Thread.Sleep(1000);

            Game.Transition<Memor_IAOn>();
        }
    }
}
____________

- Le système de dialogue lors de la discussion au téléphone.
Phone.cs
Ligne 41 à 419

                case "téléphone":

                    Console.WriteLine(
@"Le téléphone est relié par un vieux câble dont certains fils ressortent.
Le câble est rattaché à une boîte de métal, elle-même fixée à un poteau de
métal planté au sol. La boîte semble très âgée, avec le métal qui a rouillé
et la peinture jaune qui n'ait presque plus visible.

À gauche du  téléphone se trouve un espace pour insérer une pièce de monnaie
et un pavé numérique dont la moitié des boutons sont absents.");

                    if (Cashier.isCoinCollected == true)
                    {
                        if (!alreadyTalk)
                        {
                            Console.WriteLine(
    @"
Vous y insérez la pièce et prenez le combiné...

- « Allo ?! »

La voix d'une vieille femme se fait entendre de l'autre côté du téléphone.
Vous sentez monter en vous un mélange de soulagement et de peur.

- « Est-ce qu'il y a quelqu'un ? Allo ?! »

-------------------------------------------
RÉPONSES :

1- Oui!... Oui je suis là.

2- Qui êtes-vous ?

3- ...");
                            choseQuestionAnswer = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            switch (choseQuestionAnswer)
                            {
                                case 1:
                                    Console.WriteLine(
@"- « Bonjour petit, je suis BudZ ! J'imagine que tu as beaucoup de questions,
  mais ne t'inquiètes pas, je suis ici pour t'aider. »");
                                    break;

                                case 2:
                                    Console.WriteLine(
@"- « Enfin quelqu'un répond ! 
  Je n'ai pas vraiment de nom, mais on m'appelle BudZ et je suis ici pour
  aider les gens comme toi qui finissent par se retrouver coincés dans ce
  genre d'endroit. »");
                                    break;

                                default:
                                    Console.WriteLine(
@"- « J'imagine que tu dois avoir peur. Je comprends parfaitement. Cet
  endroit doit être assez disturbant de ton point de vue.

  Je sais aussi que d'entendre une voix à travers un téléphone qui ne devrait
  même plus marcher est tout aussi dérangeant. Mais ne t'en fais pas !

  Je suis Budz, et je suis là pour te sortir d'ici. »");
                                    break;
                            }

                            Console.WriteLine(
    @"
-------------------------------------------
RÉPONSES :

1- Moi c'est Hugo... Hugo Weston.

2- Où suis-je ?

3- ...");
                            choseQuestionAnswer = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            switch (choseQuestionAnswer)
                            {
                                case 1:
                                    Console.WriteLine(
@"- « Enchanté Hugo ! 

  J'imagine que tu dois te demander où tu es. Malheureusement, tu n'es
  pas au meilleur endroit. 

  Tu te trouves chez Mama Olga, ou plus précisément dans son magasin.

  La bonne nouvelle, c'est qu'elle est moins à l'affût lorsqu'elle est
  dans son magasin. Tu as donc une chance de t'en sortir... J'en ai déjà
  trop vu mourir, tu ne finiras pas comme eux. »");
                                    break;

                                case 2:
                                    Console.WriteLine(
@"- « Tu es malheureusement chez l'une des plus dangereuses habitantes des 
  Limbes : Mama Olga.

  Mais ne t'en fais pas petit ! Si tu suis mes conseils, tu t'en sortiras
  vivant... J'en ai déjà trop vu mourir. »");
                                    break;

                                default:
                                    Console.WriteLine(
@"- « Je comprends, difficile de faire confiance dans un endroit pareil. Mais
  sans mon aide, Mama Olga te transformera en nourriture comme les produits que
  tu peux voir autour de toi !

  Alors s'il te plaît, écoute ce que j'ai à te dire... J'en ai déjà trop vu mourir,
  je ne veux pas que tu finisses comme eux. »");
                                    break;
                            }

                            do
                            {
                                Console.WriteLine(
    @"
-------------------------------------------
QUESTIONS :

1- Que dois-je faire ?

2- Qui est cette « Mama Olga » ?

3- Que veux-tu dire par « J'en ai déjà trop vu mourir » ?

4- Comment je suis arrivé ici ?

5- À qui appartient ce journal ?

6- J'y vais !");
                                choseQuestionAnswer = Convert.ToInt32(Console.ReadLine());

                                Console.Clear();
                                switch (choseQuestionAnswer)
                                {
                                    case 1:
                                        Console.WriteLine(
@"- « Pour te sortir d'ici, il faut que tu te rendes dans l'entrepôt du magasin.
  Tu pourras y accéder en passant par le congélateur. Mais il te faudra avant tout
  la clé pour le cadenas qui maintient la porte de l'entrepôt scellé. Elle devrait
  se trouver sur le trousseau de clés dans la boucherie.

  Une fois arrivé en arrière, il devrait avoir une trappe qui sert à délivrer les
  charges. Je vais envoyer Hame - une bonne amie à moi -, pour venir te recueillir
  et t'amener en lieu sûr.

  J'ai failli oublier ! Mama Olga a ses propres chiens de garde. Il faudra que tu
  trouves un moyen de les occuper s'ils venaient à te barrer la route.

  As-tu d'autres questions ? »");
                                        break;

                                    case 2:
                                        Console.WriteLine(
@"- « Je ne la connais pas vraiment personnellement, mais je sais qu'elle est une des
  plus dangereuses personnes de tous les Limbes. Elle était humaine avant, mais
  j'ignore ce qui a bien pu lui arriver pour qu'elle finisse ainsi. Cet endroit peut
  faire ressortir ce qu'il a de plus mauvais en nous... et parfois le meilleur.
  
  Et ne te fit pas trop aux apparences ! Elle a peut-être l'air d'un gros zombie qui
  grogne, mais elle est loin d'être bête. Sa rapidité, sa force, sa résistante et son
  intelligence dépassent de loin ce que tu peux t'imaginer.

  Elle est une des principales sources de problèmes sur les terres du IIIe TARO.
  Mais elle est si dangereuse qu'on essaie d'éviter de se la mettre à dos.

  ... J'ai l'impression que je viens de te donner un gros coup de stress sans le
  vouloir ...

  As-tu d'autres questions ? »");
                                        break;

                                    case 3:
                                        Console.WriteLine(
@"- « Je suis ici depuis bien plus longtemps que tu pourrais le croire. Tu n'es pas
  le premier à arriver ici, et il y a d'autres qui sont dans des situations bien pire
  que la tienne. Parfois, il est possible de les sauver, mais la majeure partie du
  temps, je ne peux que les accompagner dans leur dernier instant... Ça fait mal.

  Mais toi, tu as une chance de t'en sortir ! Et je ferais tout en mon pouvoir pour
  que tu t'en sortes vivant !

  As-tu d'autres questions ? »");
                                        break;

                                    case 4:
                                        Console.WriteLine(
@"- « Ça arrive de temps en temps que des humains ou des animaux finissent par arriver
  dans les  Limbes, surtout depuis le Grand Buffet - crois-moi, tu ne veux pas que je
  te raconte cette histoire.

  Beaucoup d'habitants des Limbes utilisent des situations et des conditions clés pour
  quitter les Limbes ou pour y amener une entité. Un ami disait qu'il fallait voir ça
  comme une porte et ses clés.

  Si tu as la porte, mais pas les clés pour l'ouvrir, ou l'inverse, rien ne se produit.
  Mais une fois réunis, un passage entre les Limbes et un monde peut se créer
  temporairement.

  Tu as dû activer toutes les conditions pour activer une entrée chez Mama Olga. Mais
  lesquelles ? Ça, je n'en sais rien.

  As-tu d'autres questions ? »");
                                        break;

                                    case 5:
                                        Console.WriteLine(
@"- « Un journal ?... Ho ! Le journal ! Si c'est bien ce que je pense, garde-le
  précieusement, il t'aidera !

  Il appartenait à un ami. Il l'avait volontairement laissé au cas où quelqu'un
  finirait par tomber ici... Il a finalement eu raison de le faire.

  As-tu d'autres questions ? »");
                                        break;

                                    default:
                                        break;
                                }
                            } while (choseQuestionAnswer <= 5);
                            Console.WriteLine(
@"- « Très bien ! Si tu as besoin de moi, utilise ce téléphone et je te répondrais
  aussitôt !

  Fais attention à toi ! »

Le sou ressort de la machine et vous la récupérez.");
                            specialEvent++;
                            alreadyTalk = true;
                        }
                        else
                        {
                            string newVoice = voice[rdm.Next(voice.Length)];
                            Console.WriteLine(
@"
Vous déposez la pièce dans la fente et décrochez le téléphone.

- « Bon retour ! Tu t'en sors toujours ? »

La façon de parler est la même, mais tout le reste est différent de la dernière fois. La voix que
vous entendez sonne comme celle " + newVoice + @".

- « Avais-tu d'autre questions ? »");


                            do
                            {
                                Console.WriteLine(
@"
-------------------------------------------
QUESTIONS :

1- BudZ ? C'est bien toi ? 

2- Que dois-je faire ?

3- Qui est cette « Mama Olga » ?

4- Que veux-tu dire par « J'en ai déjà trop vu mourir » ?

5- Comment je suis arrivez ici ?

6- À qui appartient ce journal ?

7- J'y vais !");
                                choseQuestionAnswer = Convert.ToInt32(Console.ReadLine());

                                Console.Clear();
                                switch (choseQuestionAnswer)
                                {
                                    case 1:
                                        Console.WriteLine(
@"- « J'imagine que tu fais référence à ma voix, mais oui, c'est bien moi.

  Pour une raison que j'ignore, lorsque quelqu'un démarre une nouvelle conversation
  avec moi, il aura l'impression de parler à une toute nouvelle personne. Ce qui
  est étrange puisque je suis persuadé  d'avoir la même voix que d'habitude...
  Tu vas t'y faire.

  As-tu d'autres questions ? »");
                                        break;

                                    case 2:
                                        Console.WriteLine(
@"- « Pour te sortir d'ici, il faut que tu te rendes dans l'entrepôt du magasin.
  Tu pourras y accéder en passant par le congélateur. Mais il te faudra avant tout
  la clé pour le cadenas qui maintient la porte de l'entrepôt scellé. Elle devrait
  se trouver sur le trousseau de clés dans la boucherie.

  Une fois arrivé en arrière, il devrait avoir une trappe qui sert à délivrer les
  charges. Je vais envoyer Hame - une bonne amie à moi -, pour venir te recueillir
  et t'amener en lieu sûr.

  J'ai failli oublier ! Mama Olga a ses propres chiens de garde. Il faudra que tu
  trouves un moyen de les occuper s'ils venaient à te barrer la route.

  As-tu d'autres questions ? »");
                                        break;

                                    case 3:
                                        Console.WriteLine(
@"- « Je ne la connais pas vraiment personnellement, mais je sais qu'elle est une des
  plus dangereuses personnes de tous les Limbes. Elle était humaine avant, mais
  j'ignore ce qui a bien pu lui arriver pour qu'elle finisse ainsi. Cet endroit peut
  faire ressortir ce qu'il a de plus mauvais en nous... et parfois le meilleur.
  
  Et ne te fit pas trop aux apparences ! Elle a peut-être l'air d'un gros zombie qui
  grogne, mais elle est loin d'être bête. Sa rapidité, sa force, sa résistante et son
  intelligence dépassent de loin ce que tu peux t'imaginer.

  Elle est une des principales sources de problèmes sur les terres du IIIe TARO.
  Mais elle est si dangereuse qu'on essaie d'éviter de se la mettre à dos.

  ... J'ai l'impression que je viens de te donner un gros coup de stress sans le
  vouloir ...

  As-tu d'autres questions ? »");
                                        break;

                                    case 4:
                                        Console.WriteLine(
@"- « Je suis ici depuis bien plus longtemps que tu pourrais le croire. Tu n'es pas
  le premier à arriver ici, et il y a d'autres qui sont dans des situations bien pire
  que la tienne. Parfois, il est possible de les sauver, mais la majeure partie du
  temps, je ne peux que les accompagner dans leur dernier instant... Ça fait mal.

  Mais toi, tu as une chance de t'en sortir ! Et je ferais tout en mon pouvoir pour
  que tu t'en sortes vivant !

  As-tu d'autres questions ? »");
                                        break;

                                    case 5:
                                        Console.WriteLine(
@"- « Ça arrive de temps en temps que des humains ou des animaux finissent par arriver
  dans les  Limbes, surtout depuis le Grand Buffet - crois-moi, tu ne veux pas que je
  te raconte cette histoire.

  Beaucoup d'habitants des Limbes utilisent des situations et des conditions clés pour
  quitter les Limbes ou pour y amener une entité. Un ami disait qu'il fallait voir ça
  comme une porte et ses clés.

  Si tu as la porte, mais pas les clés pour l'ouvrir, ou l'inverse, rien ne se produit.
  Mais une fois réunis, un passage entre les Limbes et un monde peut se créer
  temporairement.

  Tu as dû activer toutes les conditions pour activer une entrée chez Mama Olga. Mais
  lesquelles ? Ça, je n'en sais rien.

  As-tu d'autres questions ? »");
                                        break;

                                    case 6:
                                        Console.WriteLine(
@"- « Un journal ?... Ho ! Le journal ! Si c'est bien ce que je pense, garde-le
  précieusement, il t'aidera !

  Il appartenait à un ami. Il l'avait volontairement laissé au cas où quelqu'un
  finirait par tomber ici... Il a finalement eu raison de le faire.

  As-tu d'autres questions ? »");
                                        break;

                                    default:
                                        break;
                                }
                            } while (choseQuestionAnswer <= 6);
                            Console.WriteLine(
@"- « Très bien ! Reste sur tes gardes et fais attention à toi ! »

La pièce ressort de la machine et vous la récupérez.");
                            specialEvent++;
                            alreadyTalk = true;
                        }
                        
                    }
                    break;