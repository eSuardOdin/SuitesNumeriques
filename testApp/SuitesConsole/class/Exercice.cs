public abstract class Exercice
{
    private byte TypeExo {get; set;}
    public string Enonce {get; private set;}
    public string Question {get; private set;}
    public string Reponse {get; private set;}
    private Suite SuiteExo {get; set;}

    public Exercice(byte typeExo)
    {
        TypeExo = typeExo;
        GetNewSuite();
    }

    public virtual void SetEnonce(string typeSuite)
    {
        Random rand = new();
        Enonce = $"Soit la suite {typeSuite} (Un)";

        // Si on a donne le premier terme et la raison
        if(TypeExo == 1 || TypeExo == 3 || TypeExo == 5 || TypeExo == 6)
        {
            Enonce += $"de premier terme U0 et de raison r :\n\n\tU0: {SuiteExo.PremierTerme}\n\n\tr: {SuiteExo.Raison}";
        }
    }



    /// <summary>
    /// Sert à (re)génèrer l'exercice
    /// </summary>
    /// <param name="typeSuite"></param>
    public abstract void GetNewSuite(string typeSuite);

    {/* 
        // Attention, ce n'est pas ici qu'on met à jour les infos
        // de l'exercice mais ce sera handle par la GUI
        Random rand = new();
        // Géométrique
        if(typeSuite == "géométrique")
        {
            SuiteExo = new Geometrique(1,1);
        }
        // Arithmétique
        else if (typeSuite == "arithmétique")
        {
            SuiteExo = new Arithmethique(1,1);
        }
        // Quelconque
        this.SuiteExo = new Suite(1,1);
    } */
}