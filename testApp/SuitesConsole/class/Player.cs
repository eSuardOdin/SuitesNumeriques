public class Player
{
    public string Pseudo { get; private set; }
    public int Score { get; private set; }
    public int Time {get; private set; }
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
    /// <param name="time">Temps mis à répondre</param>
    public void Repondre(Exercice exo, string reponse, int time)
    {
        // Si la réponse est juste on rajoute le temps pour y répondre
        if (reponse == exo.Reponse)
        {
            Score+=150;
            AddTime(time);
        }
    }

    public void AddTime(int time) => Time += time;
    public void AddReset() => Reset++;
    
    /// <summary>
    /// Gérer le score final d'un joueur
    /// </summary>
    public void ComputeScore()
    {
        Score += Time * 5;
        Score -= Reset * 50;
    }
}