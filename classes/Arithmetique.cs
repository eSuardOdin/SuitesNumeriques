public class Arithmethique : Suite
{
    public Arithmethique(double raison, double premierTerme) : base(raison, premierTerme) {}


    public override double GetValueAt(int rank) => PremierTerme + (rank * Raison);

    public override double GetSum(int firstN) // Peut on return un decimal ?
    {
        return firstN * ((PremierTerme + GetValueAt(firstN-1)) / 2);
    }

    public override bool IsMonotone()
    {
        return true;
    }

    public override string GetCroissance()
    {
        if (Raison < 0)         return "Décroissante";
        else if (Raison > 0)    return "Croissante";
        else                    return "Constante";
    }

}

