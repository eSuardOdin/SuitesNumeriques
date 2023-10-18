public class Exercice
{
    private byte TypeExo {get; set;}
    public string Enonce {get; private set;}
    public string Reponse {get; private set;}
    private Suite SuiteExo {get; set;}

    public Exercice(byte typeExo)
    {
        TypeExo = typeExo;
    }


    /// <summary>
    /// Sert à (re)génèrer l'exercice
    /// </summary>
    /// <param name="typeSuite"></param>
    public void GetNewSuite(string typeSuite)
    {
        // Attention, ce n'est pas ici qu'on met à jour les infos
        // de l'exercice mais ce sera handle par la GUI
        Random rand = new();
        // Géométrique
        if(typeSuite == "geo")
        {
            SuiteExo = new Geometrique(1,1);
        }
        // Arithmétique
        else if (typeSuite == "ari")
        {
            SuiteExo = new Arithmethique(1,1);
        }
        // Quelconque
        this.SuiteExo = new Suite(1,1);
    }
}