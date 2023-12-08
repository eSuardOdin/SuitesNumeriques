/// <summary>
/// Classe gérant les joueurs
/// </summary>
public class Player
{
    public string Pseudo { get; private set; }
    public int Score { get; private set; }
    public int Time { get; private set; }
    public Player(string pseudo)
    {
        Pseudo = pseudo;
        Score = 0;
    }


    /// <summary>
    /// Traiter la réponse d'un joueur par rapport à la question
    /// </summary>
    /// <param name="exo">Exercice auquel le joueur répond</param>
    /// <param name="reponse">Réponse du joueur</param>
    /// <returns>True si la réponse du joueur correspond à celle de l'exercice</returns>
    public bool Repondre(Exercice exo, string reponse)
    {
        if (reponse == exo.Reponse)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Ajoute les points de réponse à une question
    /// </summary>
    public void AddScore() => Score += 150;

    /// <summary>
    /// Ajoute des points par rapport au temps de réponse
    /// </summary>
    /// <param name="time">Temps à ajouter</param>
    public void AddTimedScore(int time) => Score += time * 5;
}