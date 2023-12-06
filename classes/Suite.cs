/// <summary>
/// La classe m�re d'une suite, contient les m�thodes � override par les classes enfant
/// </summary>
public abstract class Suite
{
    public double Raison {get; private set;}
    public double PremierTerme {get; private set;} 
    
    public Suite(double raison, double premierTerme)
    {
        Raison = raison;
        PremierTerme = premierTerme;
    }

    public abstract double GetValueAt(int rank);
    public abstract double GetSum(int firstN);
    public abstract bool IsMonotone();
    public abstract string GetCroissance();
}