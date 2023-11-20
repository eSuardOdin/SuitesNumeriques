using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

/// <summary>
/// Gère l'input/output des scores dans un fichier associé à un type de suite
/// </summary>
public class IOScoreManager
{
    public FileStream? Fs;
    public string Path {get; private set;} = Directory.GetCurrentDirectory();

    public IOScoreManager(string typeSuite)
    {
        Path += $@"\{typeSuite}.txt";
        InitEnv();
    }

    private void InitEnv()
    {
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
                    for (int i = 0; i <= 10; i++)
                    {
                        blank += $"0;;{date}\n";
                    }
                    Byte[] bytes = Encoding.UTF8.GetBytes(blank);
                    fs.Write(bytes, 0, bytes.Length);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }
        if (!File.Exists(@$"{path}\arithmétique.txt"))
        {
            using (FileStream fs = new FileStream(@$"{path}\arithmétique.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                    
                try
                {
                    DateTime date = DateTime.Now;
                    string blank = "";
                    for (int i = 0; i <= 10; i++)
                    {
                        blank += $"0;;{date}\n";
                    }
                    Byte[] bytes = Encoding.UTF8.GetBytes(blank);
                    fs.Write(bytes, 0, bytes.Length);
                        
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
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
                DateTime date = DateTime.Now;
                var values = line.Split(';');
                if(rank == compteur)
                {
                    newScore += $"{p.Score};{p.Pseudo};{date}\n";
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
    }


    public string GetHighScores()
    {
        string scores = "Rang\t\tScore\t\tPseudo\t\tDate\n\n";
        int compteur = 1;

        using (StreamReader reader = new(Path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(';');
                if(values[0] != "") // Prevent l'erreur de la dernière ligne vide ...
                {
                    if (values[1] != "") // Si pseudo non vide
                    {
                        scores += $". {compteur}\t\t{values[0]}\t\t{values[1]}\t\t{values[2]}\n\n";
                    }
                    else
                    {
                        scores += $". {compteur}\n\n";
                    }
                    compteur++;
                }
            }
        }
        return scores;
    }


    /*public void PopulateHighScores(DataGridView dataGrid)
    {
        // Ajout des headers
        dataGrid.ColumnCount = 4;
        dataGrid.Columns[0].Name = "Rang";
        dataGrid.Columns[1].Name = "Score";
        dataGrid.Columns[2].Name = "Pseudo";
        dataGrid.Columns[3].Name = "Date";

        // Refresh ?


        // Ajout des datas
        int compteur = 1;
        List<string[]> data = new();

        using (StreamReader reader = new(Path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                
                var values = line.Split(';');
                if (values[0] != "") // Prevent l'erreur de la dernière ligne vide ...
                {
                    if (values[1] != "") // Si pseudo non vide
                    {
                        string[] row = { $"{compteur}", $"{values[0]}", $"{values[1]}", $"{values[2]}" };
                        data.Add(row);
                    }
                    else
                    {
                        string[] row = { $"{compteur}", "", "", ""};
                        data.Add(row);
                    }
                    compteur++;
                }
            }
            foreach(var row in data) dataGrid.Rows.Add(row);
        }
    }*/



    public void PopulateList(ListView scoresList)
    {
        // Ajout des headers
        scoresList.View = View.Details;
        scoresList.Columns.Add("Rang", 50);
        scoresList.Columns.Add("Score", 50);
        scoresList.Columns.Add("Pseudo", 150);
        scoresList.Columns.Add("Date", 150);

        // Refresh ?


        // Ajout des datas
        int compteur = 1;
        List<string[]> data = new();

        using (StreamReader reader = new(Path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {

                var values = line.Split(';');
                if (values[0] != "") // Prevent l'erreur de la dernière ligne vide ...
                {
                    if (values[1] != "") // Si pseudo non vide
                    {
                        string[] row = { $"{compteur}", $"{values[0]}", $"{values[1]}", $"{values[2]}" };
                        data.Add(row);
                    }
                    else
                    {
                        string[] row = { $"{compteur}", "", "", "" };
                        data.Add(row);
                    }
                    compteur++;
                }
            }
            foreach (var row in data)
            {
                ListViewItem item = new(row);
                scoresList.Items.Add(item);
            }
        }
    }

}