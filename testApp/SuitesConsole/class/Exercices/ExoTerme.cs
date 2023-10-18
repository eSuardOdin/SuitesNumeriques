public class ExoTerme : Exercice
{
    public ExoTerme(string typeSuite)
    {
        GetNewSuite(typeSuite);
        SetEnonce(typeSuite);
    }
    public override void GetNewSuite(string typeSuite)
    {
        Random rand = new();
        // Géométrique
        if(typeSuite == "géométrique")
        {
            //Overflow
            SuiteExo = new Geometrique(
                rand.Next(-15, 15),
                rand.Next(-1000, 1000)
            );
        }
        // Arithmétique
        else if (typeSuite == "arithmétique")
        {
            SuiteExo = new Arithmethique(
                rand.Next(-15, 15),
                rand.Next(-1000, 1000)
            );
        }
        // Quelconque
        else 
        {
            this.SuiteExo = new Suite(1,1);
        }
    }



    public override void SetEnonce(string typeSuite)
    {
        Random rand = new();
        int rang = rand.Next(1, 15);
        Reponse = SuiteExo.GetValueAt(rang).ToString();
        Enonce = $"Soit la suite {typeSuite} (Un) de premier terme U0 et de raison r:\n\n\tU0: {SuiteExo.PremierTerme}\n\n\tr: {SuiteExo.Raison}\n\n\n\n\n";
        Enonce += $"Quelle est la valeur du terme de rang {rang}?";
    }
}