/// <summary>
/// Permet de gérer une partie entre deux joueurs sur n'importe quel type de suite
/// </summary>
public class UntimedVersus : Partie
{
    private IOScoreManager ScoreManager;
    public List<Player> Players = new();
    public UntimedVersus(string typePartie, Player p1, Player p2) : base(typePartie)
    {
        ScoreManager = new("scores", typePartie);
        ScoreManager.TryCreateScoreFile();
        Console.WriteLine(ScoreManager.GetRank(1200));
        Players.Add(p1);
        Players.Add(p2);
        Play();
    }



    /// <summary>
    /// Permet de jouer une partie joueur contre joueur avec contrainte de temps
    /// </summary>
    protected override void Play()
    {

        bool isFirstPlayer = true;
        foreach (var ex in Exercices)
        {
            foreach (var player in Players)
            {
                // Si on est sur le deuxième joueur, on change de suite
                if (!isFirstPlayer)
                {
                    ex.GetNewSuite(TypeSuite);  
                }
                isFirstPlayer = !isFirstPlayer;
                
                string res = "";
                // à chaque nouvelle suite on affiche la question
                do
                {
                    PrintQuestion(ex, player);
                    Console.WriteLine($"La réponse est : {ex.Reponse}"); // Débug
                    
                    res = Console.ReadLine();
                    // Si reset de la question
                    if (res == "r")
                    {
                        player.AddReset();
                        ex.GetNewSuite(TypeSuite);
                    }
                } while (res == "r");
               
                player.Repondre(ex, res, 0);
                
                /* DEBUG
                if (res == ex.Reponse) 
                {
                    Console.WriteLine("Bonne réponse ! ");  
                }
                else Console.WriteLine($"Faux, la réponse est : {ex.Reponse}");*/
            }    
        }
        // On calcule les scores des joueurs et on met à jour les meilleurs scores
        foreach (var player in Players)
        {
            player.ComputeScore();
            int rank = ScoreManager.GetRank(player.Score);
            if (rank != -1)
            {
                ScoreManager.WriteNewScore(rank, player);
            }
            Console.WriteLine($"{player.Pseudo}: {player.Score}, reset : {player.Reset}");
        }
    }


    /// <summary>
    /// Print la question sur la console (à refaire pour la GUI)
    /// </summary>
    /// <param name="ex">Exercice à print</param>
    /// <param name="p">Joueur répondant à la question</param>
    private void PrintQuestion(Exercice ex, Player p)
    {
        Console.WriteLine($"\n\n\n------------------\nC'est votre tour {p.Pseudo}\n------------------");
        Console.WriteLine("\n\n");
        Console.WriteLine(ex.Enonce);
    }
}