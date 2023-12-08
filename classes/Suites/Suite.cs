/// <summary>
/// La classe mère d'une suite, contient les méthodes à override par les classes enfant
/// </summary>
public abstract class Suite
{
    /// <summary>
    /// Raison de la suite
    /// </summary>
    public double Raison {get; private set;}
    /// <summary>
    /// Premier terme de la suite
    /// </summary>
    public double PremierTerme {get; private set;} 
    /// <summary>
    /// Constructeur d'une suite
    /// </summary>
    /// <param name="raison">La raison de l'objet créé</param>
    /// <param name="premierTerme">Le premier terme de l'objet créé</param>
    public Suite(double raison, double premierTerme)
    {
        Raison = raison;
        PremierTerme = premierTerme;
    }
    
    /// <summary>
    /// Sert à avoir la valeur du rang d'une suite
    /// </summary>
    /// <param name="rank">Le rang voulu</param>
    /// <returns>La valeur du rang</returns>
    public abstract double GetValueAt(int rank);

    /// <summary>
    /// Renvoie la somme de N premiers termes
    /// </summary>
    /// <param name="firstN">Le nombre de termes</param>
    /// <returns>La somme</returns>
    public abstract double GetSum(int firstN);
    
    /// <summary>
    /// Check si une suite est monotone
    /// </summary>
    /// <returns>True si monotone</returns>
    public abstract bool IsMonotone();

    /// <summary>
    /// Renvoie une chaîne de caractères représentant la croissance de la suite
    /// </summary>
    /// <returns>La croissance</returns>
    public abstract string GetCroissance();
}