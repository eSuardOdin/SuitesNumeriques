using System.IO;
public class IOScoreManager
{
    public FileStream? Fs;
    public string Path {get; private set;}

    public IOScoreManager(string path, string typeSuite)
    {
        Path = $"{path}_{typeSuite}.txt";
    }

    /// <summary>
    /// Créé un fichier de score et l'initialise si non existant
    /// </summary>
    public void TryCreateScoreFile()
    {
        try
        {
            using (Fs = new(Path, FileMode.CreateNew)) { }
            string blank = "0;undefined";
            using(StreamWriter sw = new StreamWriter(Path))
            {
                for (int i = 0; i < 10; i++) sw.WriteLine(blank);
            }
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
            string line;
            while ((line = reader.ReadLine()) != null && rank == -1)
            {
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


    public void WriteNewScore(int rank, Player p)
    {
        string newScore = "";
        int compteur = 1;
        using (StreamReader reader = new(Path))
        {
            string line;
            while((line = reader.ReadLine()) != null && compteur <= 10)
            {
                var values = line.Split(';');
                if(rank == compteur)
                {
                    newScore += $"{p.Score};{p.Pseudo}\n";
                    compteur++;
                }
                if (compteur != 10) newScore += line + "\n";
                compteur++;
            }
        }
        using (StreamWriter sw = new StreamWriter(Path))
        {
            sw.WriteLine(newScore);
        }
        Console.WriteLine(newScore);
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