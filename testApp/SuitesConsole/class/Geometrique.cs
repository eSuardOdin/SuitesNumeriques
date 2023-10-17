public class Geometrique : Suite
{
    public Geometrique(int raison, int premierTerme) : base(raison, premierTerme) {}


    public override int GetValueAt(int rank) => PremierTerme * Convert.ToInt32(Math.Pow(Raison, rank));

    public override long GetSum(int firstN) // Peut on return un decimal ?
    {
        return Raison == 1 ? firstN : Convert.ToInt32((1 - Math.Pow(Raison, firstN)) / (1 - Raison));
    } 
    
}