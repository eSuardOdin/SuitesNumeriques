public class Partie
{
    public string TypeSuite { get; private set; }
    public List<Exercice> Exercices{ get; private set; } = new List<Exercice>();

    public Partie(string typeSuite)
    {
        TypeSuite = typeSuite;
    }
}