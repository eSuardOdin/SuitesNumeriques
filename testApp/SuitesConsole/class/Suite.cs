public class Suite
{
    public int Raison {get; private set;}
    public int PremierTerme {get; private set;} 

    public Suite(int raison, int premierTerme)
    {
        Raison = raison;
        PremierTerme = premierTerme;
    }

    public virtual int GetValueAt(int rank)
    {

        return 0;
    }

    public virtual long GetSum(int firstN)
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