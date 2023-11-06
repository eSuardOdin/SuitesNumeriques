public class Partie
{
    public string TypeSuite { get; private set; }
    public List<Exercice> Exercices{ get; private set; } = new List<Exercice>();
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
        Exercices.Add(new ExoTerme(TypeSuite));
        Exercices.Add(new ExoPremierTerme(TypeSuite));
        Exercices.Add(new ExoRang(TypeSuite));
        Exercices.Add(new ExoRaison(TypeSuite));
        Exercices.Add(new ExoSomme(TypeSuite));
        Exercices.Add(new ExoMonotonie(TypeSuite));
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
        Console.WriteLine($"Votre score est de {Score}/{Exercices.Count}");
    }
}