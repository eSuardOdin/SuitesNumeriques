public abstract class Exercice
{
    protected byte TypeExo {get; set;}
    public string? Enonce {get; protected set;}
    public string? Reponse {get; protected set;}
    public Suite? SuiteExo {get; protected set;}

    // public Exercice(byte typeExo)
    // {
    //     TypeExo = typeExo;
    //     GetNewSuite();
    // }

    public abstract void SetEnonce(string typeSuite);



    /// <summary>
    /// Sert à (re)génèrer l'exercice
    /// </summary>
    /// <param name="typeSuite"></param>
    protected void GetNewSuite(string typeSuite)
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
            // ---------- 
            // Tentative de random decimal
            double dec = rand.NextDouble();
            dec = Math.Round(dec,1);
            double raison = rand.Next(-15, 15) + dec;
            // ----------
            SuiteExo = new Arithmethique(
                raison,
                rand.Next(-1000, 1000)
            );
        }
        // Quelconque
        else 
        {
            this.SuiteExo = new Suite(1,1);
        }
    }
}