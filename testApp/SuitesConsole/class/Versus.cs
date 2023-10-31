public class Versus : Partie
{
    private IOScoreManager ScoreManager;
    public TimeManager? TimeLeft {get; private set;}
    public List<Player> Players = new();
    public Versus(string typePartie, Player p1, Player p2) : base(typePartie)
    {
        ScoreManager = new("scores", typePartie);
        ScoreManager.TryCreateScoreFile();
        Console.WriteLine(ScoreManager.GetRank(1200));
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
                //DEBUG
                
                string res = "";
                do
                {
                    PrintQuestion(ex, player);
                    Console.WriteLine($"La réponse est : {ex.Reponse}");
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
        foreach (var player in Players)
        {
            player.ComputeScore();
            int rank = ScoreManager.GetRank(player.Score);
            if (rank != -1)
            {
                ScoreManager.WriteNewScore(rank, player);
            }
            Console.WriteLine($"{player.Pseudo}: {player.Score}, time : {player.Time} sec, reset : {player.Reset}");
        }
    }


    private void PrintQuestion(Exercice ex, Player p)
    {
        Console.WriteLine($"\n\n\n------------------\nC'est votre tour {p.Pseudo}\n------------------");
        Console.WriteLine("\n\n");
        Console.WriteLine(ex.Enonce);
    }
}