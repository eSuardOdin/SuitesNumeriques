using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Markup;
using static System.Formats.Asn1.AsnWriter;

/// <summary>
/// Gère l'input/output des scores dans un fichier associé à un type de suite
/// </summary>
public class IOScoreManager
{
    /// <summary>
    /// Chemin du fichier de scores
    /// </summary>
    public string Path {get; private set;} = Directory.GetCurrentDirectory();

    /// <summary>
    /// Constructeur de l'objet, on change le chemin pour correspondre au type de suite et on créé les fichiers de scores
    /// </summary>
    /// <param name="typeSuite">Arithmétique ou géométrique</param>
    public IOScoreManager(string typeSuite)
    {
        Path += $@"\{typeSuite}.txt";
        InitEnv();
    }

    /// <summary>
    /// Initialisation des fichiers de score
    /// </summary>
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
                    // On remplit le fichier de lignes vides
                    string blank = "";
                    for (int i = 0; i < 10; i++)
                    {
                        blank += $"0;;\n";
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
                    string blank = "";
                    for (int i = 0; i <= 10; i++)
                    {
                        blank += $"0;;\n";
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

                // Si score vide et encore dans les 10 premiers, l'utilisateur prend le rang
                if (values[0] == "" && compteur <= 10)
                {
                    rank = compteur;
                }
                // Si score inferieur à celui de l'utilisateur, l'utilisateur prend le rang
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
            while((line = reader.ReadLine()) != null && compteur <= 11)
            {
                DateTime date = DateTime.Now;
                var values = line.Split(';');
                // Si on est sur la ligne du rang on insère la ligne du joueur dans le nouveau fichier de scores
                if(rank == compteur)
                {
                    newScore += $"{p.Score};{p.Pseudo};{date}\n";
                    compteur++;
                }
                if (compteur != 11) newScore += line + "\n";
                compteur++;
            }
        }
        // Ecriture du nouveau texte du score
        using (StreamWriter sw = new StreamWriter(Path))
        {
            sw.WriteLine(newScore);
        }
    }

    /// <summary>
    /// Remplit un formulaire de scores
    /// </summary>
    /// <param name="scoresList">La liste à remplir</param>
    public void PopulateList(ListView scoresList)
    {
        // Ajout des headers
        scoresList.View = View.Details;
        scoresList.Columns.Add("Rang", 50);
        scoresList.Columns.Add("Score", 50);
        scoresList.Columns.Add("Pseudo", 150);
        scoresList.Columns.Add("Date", 150);

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
            // Rajoute une ligne pour chaque score et la remplit (j'aurais pu gérer ça en une seule boucle, changer si assez de tps)
            foreach (var row in data)
            {
                ListViewItem item = new(row);
                scoresList.Items.Add(item);
            }
        }
    }

}