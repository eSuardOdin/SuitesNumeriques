public class Suite
{
    public double Raison {get; private set;}
    public double PremierTerme {get; private set;} 

    public Suite(double raison, double premierTerme)
    {
        Raison = raison;
        PremierTerme = premierTerme;
    }

    public virtual double GetValueAt(int rank)
    {

        return 0;
    }

    public virtual double GetSum(int firstN)
    {

        return 0;
    }

    public virtual bool IsMonotone()
    {

        return true;
    }

    public virtual string GetCroissance()
    {
        return "";
    }
}