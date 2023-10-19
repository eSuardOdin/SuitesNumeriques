public class ExoRaison : Exercice
{
    public ExoRaison(string typeSuite)
    {
        //base.
        GetNewSuite(typeSuite);
        SetEnonce(typeSuite);
    }


    public override void SetEnonce(string typeSuite)
    {
        Random rand = new();
        int rang1 = rand.Next(1, 15);
        int rang2;
        do
        {
            rang2 = rand.Next(1, 15);
        } while (rang1 == rang2);
        Reponse = SuiteExo.Raison.ToString() + " " + SuiteExo.PremierTerme.ToString();
        Enonce = $"Soit la suite {typeSuite} (Un) définie par les termes U{rang1} et U{rang2}:\n\n\tU{rang1}: {SuiteExo.GetValueAt(rang1)}\n\n\tU{rang2}: {SuiteExo.GetValueAt(rang2)}\n\n\n\n\n";
        Enonce += $"Quelles les valeurs de la raison r et du premier terme U0?";
    }
}