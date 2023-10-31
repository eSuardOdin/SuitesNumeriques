using System.IO;
public class IOScoreManager
{
    public FileStream? Fs;
    public string Path {get; private set;}

    public IOScoreManager(string path, string typeSuite)
    {
        Path = $"{path}_{typeSuite}.txt";
    }

    public void TryCreateScoreFile()
    {
        try
        {
            Fs = new(Path, FileMode.CreateNew);
        }
        catch {}
    }

    /// <summary>
    /// Vérifier si un score a sa place dans le fichier
    /// </summary>
    /// <returns>Le classement du score, -1 si non top10</returns>
    public int GetRank(int score)
    {
        int rank = -1;
        int compteur = 1;
        using(StreamReader reader = new(Path))
        {
            while(reader.ReadLine() != null && rank == -1)
            {
                string line = reader.ReadLine();
                var values = line.Split(';');
                if (Convert.ToInt32(values[0]) <= score)
                {
                    rank = compteur;
                }
                compteur++;
            }
        }
        return rank;
    }
    // Il faut que je puisse checker si un score est plus élevé qu'un autre
    // Je dois gérer les décalages de ligne
    // On peut copier toute les lignes restantes sauf la dernière


    /*
    Geometrique
    Rank;Pseudo;Score
    Rank;Pseudo;Score
    Rank;Pseudo;Score
    Arithmetique
    Rank;Pseudo;Score
    Rank;Pseudo;Score
    Rank;Pseudo;Score
    
    ou

    <Geometrique>
        <1>
            <pseudo>
                "toto"
            <pseudo/>
            <score>
                1278
            <score/>
        <1/>
    <Geometrique/>
    */
}