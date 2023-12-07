public abstract class Exercice
{
    public string? Enonce {get; protected set;}
    public string? Reponse {get; protected set;}
    public Suite? SuiteExo {get; protected set;}
    public abstract void SetEnonce(string typeSuite);
    /// <summary>
    /// Sert à (re)génèrer l'exercice
    /// </summary>
    /// <param name="typeSuite">Géométrique ou arithmétique</param>
    public void GetNewSuite(string typeSuite)
    {
        Random rand = new();
        // Géométrique
        if(typeSuite == "géométrique")
        {
            double raison = rand.Next(-5, 5);
            SuiteExo = new Geometrique(
                raison,
                rand.Next(-10, 10)  
            );
        }
        // Arithmétique
        else if (typeSuite == "arithmétique")
        {
            
            double raison = rand.Next(-15, 15);
            SuiteExo = new Arithmethique(
                raison,
                rand.Next(-100, 100)
            );
        }

        // Quelconque
        else 
        {
            //this.SuiteExo = new Quelquoncque(1,1);
        }
        
        SetEnonce(typeSuite);
    }
}