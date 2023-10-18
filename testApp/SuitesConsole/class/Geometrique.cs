public class Geometrique : Suite
{
    public Geometrique(int raison, int premierTerme) : base(raison, premierTerme) {}


    public override int GetValueAt(int rank) => PremierTerme * Convert.ToInt32(Math.Pow(Raison, rank));

    public override long GetSum(int firstN) // Peut on return un decimal ?
    {
        return Raison == 1 ? firstN : Convert.ToInt32((1 - Math.Pow(Raison, firstN)) / (1 - Raison));
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