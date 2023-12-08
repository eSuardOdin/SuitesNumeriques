/// <summary>
/// Classe gérant les suites géométriques
/// </summary>
public class Geometrique : Suite
{
    public Geometrique(double raison, double premierTerme) : base(raison, premierTerme) {}


    public override double GetValueAt(int rank) => PremierTerme * Convert.ToDouble(Math.Pow(Raison, rank));


    public override double GetSum(int firstN)
    {
        return Raison == 1 ? Convert.ToDouble((1 - Math.Pow(Raison, firstN)) / (1 - Raison)) : PremierTerme * Convert.ToDouble((1 - Math.Pow(Raison, firstN)) / (1 - Raison));
    }

    public override bool IsMonotone()
    {
        if (Raison >= 0) return true;
        return false;
    }


    public override string GetCroissance()
    {
        if (Raison == 1)                    return "Constante";
        else if (Raison > 0 && Raison < 1)  return "Décroissante";
        else                                return "Constante";
    }
    
}