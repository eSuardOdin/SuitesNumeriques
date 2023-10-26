public class Versus : Partie
{
    public TimeManager? TimeLeft {get; private set;}
    public List<Player> Players = new();
    public Versus(string typePartie, Player p1, Player p2) : base(typePartie)
    {
        Players.Add(p1);
        Players.Add(p2);
        Play();
    }




    protected override void Play()
    {
        bool isFirstPlayer = true;
        //Debug
        int counter = 1;
        Console.WriteLine($"Exercice n°{counter}, la partie a {Exercices.Count} exercices");
        foreach (var ex in Exercices)
        {
            foreach (var player in Players)
            {
                // Reset time
                TimeLeft = new(30);
                if (!isFirstPlayer)
                {
                    ex.GetNewSuite(TypeSuite);  
                }
                isFirstPlayer = !isFirstPlayer;
                // Console.WriteLine($"\n\n\n------------------\nC'est votre tour {player.Pseudo}\n------------------");
                // Console.WriteLine("\n\n");
                // Console.WriteLine(ex.Enonce);
                /* DEBUG
                Console.WriteLine($"La réponse est : {ex.Reponse}");*/
                string res = "";
                do
                {
                    PrintQuestion(ex, player);
                    res = Console.ReadLine();

                    // Si reset de la question
                    if (res == "r")
                    {
                        player.AddReset();
                        ex.GetNewSuite(TypeSuite);
                    }
                } while (res == "r");
               
                player.Repondre(ex, res, TimeLeft.SecondsLeft);
                
                /* DEBUG
                if (res == ex.Reponse) 
                {
                    Console.WriteLine("Bonne réponse ! ");  
                }
                else Console.WriteLine($"Faux, la réponse est : {ex.Reponse}");*/
            }          
        }
        foreach (var player in Players) Console.WriteLine($"{player.Pseudo}: {player.Score}, time : {player.Time} sec");
    }


    private void PrintQuestion(Exercice ex, Player p)
    {
        Console.WriteLine($"\n\n\n------------------\nC'est votre tour {p.Pseudo}\n------------------");
        Console.WriteLine("\n\n");
        Console.WriteLine(ex.Enonce);
    }
}