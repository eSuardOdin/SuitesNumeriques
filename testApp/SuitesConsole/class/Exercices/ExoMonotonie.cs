public class ExoMonotonie : Exercice
{
    public ExoMonotonie(string typeSuite)
    {
        //base.
        GetNewSuite(typeSuite);
        SetEnonce(typeSuite);
    }


    public override void SetEnonce(string typeSuite)
    {
        if (typeSuite == "arithmétique")
        {
            if (SuiteExo.Raison == 0)       Reponse = "Monotone constante";
            else if (SuiteExo.Raison < 0)   Reponse = "Monotone décroissante";
            else                            Reponse = "Monotone croissante";
        }
        else
        {
            if (SuiteExo.Raison < 0)        Reponse = "Non monotone";
            else if (SuiteExo.Raison == 1)  Reponse = "Monotone constante";
            else if (SuiteExo.Raison < 1)   Reponse = "Monotone décroissante";
            else                            Reponse = "Monotone croissante";
        }
        Enonce = $"Soit la suite {typeSuite} (Un) de premier terme U0 et de raison r:\n\n\tU0: {SuiteExo.PremierTerme}\n\n\tr: {SuiteExo.Raison}\n\n\n\n\n";
        Enonce += $"Quelle est la monotonie de la suite?";
    }
}