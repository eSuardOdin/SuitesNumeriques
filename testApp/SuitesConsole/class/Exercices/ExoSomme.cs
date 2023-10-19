public class ExoSomme : Exercice
{
    public ExoSomme(string typeSuite)
    {
        //base.
        GetNewSuite(typeSuite);
        SetEnonce(typeSuite);
    }


    public override void SetEnonce(string typeSuite)
    {
        Random rand = new();
        int nbTermes = rand.Next(1, 15);
        Reponse = SuiteExo.GetSum(nbTermes).ToString();
        Enonce = $"Soit la suite {typeSuite} (Un) de premier terme U0 et de raison r:\n\n\tU0: {SuiteExo.PremierTerme}\n\n\tr: {SuiteExo.Raison}\n\n\n\n\n";
        Enonce += $"Quelle est la somme des {nbTermes} premiers termes?";
    }
}