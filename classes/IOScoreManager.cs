using System.IO;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Gère l'input/output des scores dans un fichier associé à un type de suite
/// </summary>
public class IOScoreManager
{
    public FileStream? Fs;
    public string Path {get; private set;}

    public IOScoreManager(string path, string typeSuite)
    {
        Path = $"{path}_{typeSuite}.txt";
        InitEnv();
    }

    private void InitEnv()
    {

        // Tentative threading
        //Thread writingThread = new Thread(() =>
        //{
            // Get le dossier d'exec
            string path = Directory.GetCurrentDirectory();

            // Créer et remplir les fichiers s'ils n'existent pas
            if (!File.Exists(@$"{path}\géométrique.txt"))
            {
                using (FileStream fs = new FileStream(@$"{path}\géométrique.txt", FileMode.Create, FileAccess.Write, FileShare.None))
                {

                    try
                    {
                        DateTime date = DateTime.Now;
                        string blank = "";
                        //using (StreamWriter sw = new StreamWriter(@$"{path}\arithmétique.txt", false, Encoding.UTF8))
                        //{
                        for (int i = 0; i < 10; i++)
                        {
                            blank += $"{i + 1};0;;{date}\n";
                        }
                        //}
                        Byte[] bytes = Encoding.UTF8.GetBytes(blank);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

            //File.Create(@$"{path}\géométrique.txt");
            //InitFile(@"géométrique.txt");
            }
            if (!File.Exists(@$"{path}\arithmétique.txt"))
            {
                using (FileStream fs = new FileStream(@$"{path}\arithmétique.txt", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    
                    try
                    {
                        DateTime date = DateTime.Now;
                        string blank = "";
                        //using (StreamWriter sw = new StreamWriter(@$"{path}\arithmétique.txt", false, Encoding.UTF8))
                        //{
                        for (int i = 0; i < 10; i++)
                        {
                            blank += $"{i + 1};0;;{date}\n";
                        }
                        //}
                        Byte[] bytes = Encoding.UTF8.GetBytes(blank);
                        fs.Write(bytes, 0, bytes.Length);
                        
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

                //File.Create(@$"{path}\arithmétique.txt");
                //InitFile(@"arithmétique.txt");
            }
        //});

        // Démarrage
        //writingThread.Start();

        // Attente de la fin d'exec
        //writingThread.Join();
    }

    /// <summary>
    /// Créé un fichier de score et l'initialise si non existant
    /// </summary>
    private void InitFile(string path)
    {
        //Thread writingThread = new Thread(() => {
            try
            {
                DateTime date = DateTime.Now;
                string blank;
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        blank = $"{i + 1};0;;{date}";
                        sw.WriteLine(blank);
                    }
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        //});

        //writingThread.Start();

        //writingThread.Join();
        
    }

    /// <summary>
    /// Vérifier si un score a sa place dans le fichier
    /// </summary>
    /// <returns>Le classement du score, -1 si !top10</returns>
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

    /// <summary>
    /// Ecrit les nouveaux meilleurs scores dans le fichier correspondant au type de suite
    /// </summary>
    /// <param name="rank">Rang du score à écrire</param>
    /// <param name="p">Joueur dont on écrit Score et Pseudo</param>
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

}