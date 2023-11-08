public class ExoPremierTerme : Exercice
{
    public ExoPremierTerme(string typeSuite)
    {
        GetNewSuite(typeSuite);
        SetEnonce(typeSuite);
    }

    public override void SetEnonce(string typeSuite)
    {
        Random rand = new();
        int rang = rand.Next(1, 15);
        Reponse = Math.Round(SuiteExo.PremierTerme,1).ToString();
        Enonce = $"Soit la suite {typeSuite} (Un) définie par le terme U{rang} et la raison r:\n\n\tU{rang}: {SuiteExo.GetValueAt(rang)}\n\n\tr: {SuiteExo.Raison}\n\n\n";
        Enonce += $"Quelle est la valeur du premier terme U0?"; // Toujours U0?
    }
}