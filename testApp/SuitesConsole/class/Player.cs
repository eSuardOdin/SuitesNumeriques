public class Player
{
    public string Pseudo { get; private set; }
    public int Score { get; private set; }
    public int Time {get; private set; }
    public Player(string pseudo)
    {
        Pseudo = pseudo;
        Score = 0;
        Time = 0;
    }

    public void Repondre(Exercice exo, string reponse, int time)
    {
        if (reponse == exo.Reponse) Score++;
        Time += time;
    }
}