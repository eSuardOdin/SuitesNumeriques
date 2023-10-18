public class Arithmethique : Suite
{
    public Arithmethique(int raison, int premierTerme) : base(raison, premierTerme) {}


    public override int GetValueAt(int rank) => PremierTerme + (rank * Raison);

    public override long GetSum(int firstN) // Peut on return un decimal ?
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