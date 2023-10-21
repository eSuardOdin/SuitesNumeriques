public class Versus : Partie
{
    public List<Player> Players = new();
    public Versus(string typePartie, Player p1, Player p2) : base(typePartie)
    {
        Players.Add(p1);
        Players.Add(p2);

        CreatePartie();
        Play();
    }




    protected override void Play()
    {
        bool isFirstPlayer = true;
        foreach (var ex in Exercices)
        {
            foreach (var player in Players)
            {
                if (!isFirstPlayer)
                {
                    ex.GetNewSuite(TypeSuite);
                }
                isFirstPlayer = !isFirstPlayer;
                Console.WriteLine($"\n\n\n------------------\nC'est votre tour {player.Pseudo}\n------------------");
                Console.WriteLine("\n\n");
                Console.WriteLine(ex.Enonce);
                player.Repondre(ex, Console.ReadLine());
            }          
        }
        foreach (var player in Players) Console.WriteLine($"{player.Pseudo}: {player.Score}");
    }
}