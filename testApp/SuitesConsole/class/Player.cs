public class Player
{
    public string Pseudo { get; private set; }
    public int Score { get; private set; }
    public Player(string pseudo)
    {
        Pseudo = pseudo;
        Score = 0;
    }

    public void Repondre(Exercice exo, string reponse)
    {
        if (reponse == exo.Reponse) Score++;
    }
}