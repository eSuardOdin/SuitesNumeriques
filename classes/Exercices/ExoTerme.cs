public class ExoTerme : Exercice
{
    public ExoTerme(string typeSuite)
    {
        GetNewSuite(typeSuite);
        SetEnonce(typeSuite);
    }


    public override void SetEnonce(string typeSuite)
    {
        Random rand = new();
        int rang = typeSuite == "arithmétique" ? rand.Next(1, 15) : rand.Next(1, 8);
        Reponse = Math.Round(SuiteExo.GetValueAt(rang), 1).ToString();
        Enonce = $"Soit la suite {typeSuite} (Un) de premier terme U0 et de raison r:\n\n\tU0: {SuiteExo.PremierTerme}\n\n\tr: {SuiteExo.Raison}\n\n\n";
        Enonce += $"Quelle est la valeur du terme de rang {rang}?";
    }
}