public class Player
{
    public string Pseudo { get; private set; }
    public int Score { get; private set; }
    public int Time { get; private set; }
    public int Reset { get; private set; }
    public Player(string pseudo)
    {
        Pseudo = pseudo;
        Score = 0;
        Time = 0;
        Reset = 0;
    }

    /// <summary>
    /// Traiter la réponse d'un joueur par rapport à la question et modifier ou non le Score et bonus de Temps d'un joueur
    /// </summary>
    /// <param name="exo">Exercice auquel le joueur répond</param>
    /// <param name="reponse">Réponse du joueur</param>
    public bool Repondre(Exercice exo, string reponse)
    {
        if (reponse == exo.Reponse)
        {
            return true;
        }
        return false;
    }

    public void AddTime(int time) => Time += time;
    public void AddScore() => Score += 150;
    public void AddTimedScore(int time) => Score += time * 5;
    public void AddReset() 
    {
        Reset++; // Pour les stats
        Score -= 50;
    }
    
    /// <summary>
    /// Gérer le score final d'un joueur avec temps
    /// </summary>
    public void ComputeTimedScore()
    {
        Score += Time * 5;
        Score -= Reset * 50;
    }


    public void ComputeScore()
    {
        Score -= Reset * 50;
    }
}