public class Partie
{
    public string TypeSuite { get; private set; }
    public Exercice[] Exercices{ get; private set; } = new Exercice[6];
    public int Score { get; private set; }

    public Partie(string typeSuite)
    {
        TypeSuite = typeSuite;
        Score = 0;
        
        CreatePartie();
        Play();
        
    }

    protected void CreatePartie()
    {
        Exercices[0] = new ExoTerme(TypeSuite);
        Exercices[1] = new ExoPremierTerme(TypeSuite);
        Exercices[2] = new ExoRang(TypeSuite);
        Exercices[3] = new ExoRaison(TypeSuite);
        Exercices[4] = new ExoSomme(TypeSuite);
        Exercices[5] = new ExoMonotonie(TypeSuite);
    }

    protected virtual void Play()
    {
        foreach (var ex in Exercices)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine(ex.Enonce);
            string res = Console.ReadLine();

            if (res == ex.Reponse) 
            {
                Console.WriteLine("Bonne réponse ! ");
                Score++;    
            }
            else Console.WriteLine($"Faux, la réponse est : {ex.Reponse}");
        }
        Console.WriteLine($"Votre score est de {Score}/{Exercices.Length}");
    }
}