public class Player
{
    public string Pseudo { get; private set; }
    public int Score { get; private set; }
    public int Time { get; private set; }
    public Player(string pseudo)
    {
        Pseudo = pseudo;
        Score = 0;
        Time = 0;
    }

    /// <summary>
    /// Traiter la réponse d'un joueur par rapport à la question
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
}