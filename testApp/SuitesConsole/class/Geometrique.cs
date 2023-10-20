public class Geometrique : Suite
{
    public Geometrique(double raison, double premierTerme) : base(raison, premierTerme) {}


    public override double GetValueAt(int rank) => PremierTerme * Convert.ToDouble(Math.Pow(Raison, rank));


    // à revoir
    public override double GetSum(int firstN)
    {
        return Raison == 1 ? firstN /* Plutot U0 + 1 ? */: Convert.ToDouble((1 - Math.Pow(Raison, firstN)) / (1 - Raison));
    }

    public override bool IsMonotone()
    {
        if (Raison >= 0) return true;
        return false;
    }


    /// <summary>
    /// Retourne la croissance de la suite géométrique<br/>
    /// (Attention, ce résultat n'est vrai que si on check avant sa monotonie)
    /// </summary>
    /// <returns>La croissance de la suite</returns>
    public override string GetCroissance()
    {
        if (Raison == 1)                    return "Constante";
        else if (Raison > 0 && Raison < 1)  return "Décroissante";
        else                                return "Constante";
    }
    
}