using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuitesNumeriques
{
    /// <summary>
    /// Classe gérant le formulaire de fin de partie
    /// </summary>
    public partial class FinPartie : Form
    {
        /// <summary>
        /// Le score manager qui écrit les nouveaux scores en fin de partie
        /// <br/>Peut être null si partie sans contrainte de temps
        /// </summary>
        private IOScoreManager? MyScoreManager { get; set; }

        /// <summary>
        /// La partie était elle avec contrainte de temps?
        /// </summary>
        private bool IsTimed { get; set; }

        /// <summary>
        /// Reference du formulaire principal
        /// </summary>
        private MainForm MyMainForm { get; set; }

        /// <summary>
        /// Joueur 1
        /// </summary>
        private Player J1 { get; set; }

        /// <summary>
        /// Joueur 2
        /// </summary>
        private Player J2 { get; set; }

        /// <summary>
        /// Type de la partie "arithmétique" ou "géométrique"
        /// </summary>
        private string TypePartie { get; set; }

        /// <summary>
        /// Est ce qu'on lance une nouvelle partie ?
        /// </summary>
        private bool IsNewPartie { get; set; } = false;

        /// <summary>
        /// Constructeur, affecte les valeurs des arguments aux attributs et affiche les informations sur scores et vainqueur.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <param name="typePartie"></param>
        /// <param name="mainForm"></param>
        /// <param name="isTimed"></param>
        public FinPartie(Player j1, Player j2, string typePartie, MainForm mainForm, bool isTimed)
        {
            InitializeComponent();
            
            J1 = j1;
            J2 = j2;
            IsTimed = isTimed;
            TypePartie = typePartie;
            MyMainForm = mainForm;
            // Scores et pseudos
            j1PseudoLbl.Text = J1.Pseudo;
            j1ScoreLbl.Text = J1.Score.ToString();
            j2PseudoLbl.Text = J2.Pseudo;
            j2ScoreLbl.Text = J2.Score.ToString();
            // Affichage du vainqueur
            if (J1.Score > J2.Score)
            {
                winnerTxt.Text = $"VAINQUEUR: {J1.Pseudo}";
                winnerTxt.ForeColor = Color.Red;
            }
            else if (J2.Score > J1.Score)
            {
                winnerTxt.Text = $"VAINQUEUR: {J2.Pseudo}";
                winnerTxt.ForeColor = Color.Blue;
            }
            else winnerTxt.Text = "MATCH NUL";

            // Si partie avec contrainte, on instancie l'objet pour écrire les meilleurs scores
            if (IsTimed)
            {
                // Instance de l'IO des scores
                MyScoreManager = new(typePartie);

                // Ecriture des meilleurs scores si meilleur score
                MyScoreManager.WriteNewScore(MyScoreManager.GetRank(J1.Score), J1);
                MyScoreManager.WriteNewScore(MyScoreManager.GetRank(J2.Score), J2);
            }
                

        }

        /// <summary>
        /// Gestion du lancement d'une nouvelle partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            IsNewPartie = true;
            // Nouveau formulaire de création de partie
            InitJoueurs init = new(MyMainForm, IsTimed);
            
            // Pré remplissage des champs
            foreach (Control ctrl in init.Controls)
            {
                if (ctrl is GroupBox)
                {
                    // Check du radio btn correspondant au type de partie jouée
                    foreach (RadioButton btn in ctrl.Controls)
                    {
                        if (btn.Tag.ToString().ToLower() == TypePartie) btn.Checked = true;
                    }
                }
                else
                {
                    if (ctrl.Name == "j1TxtBox") ctrl.Text = J1.Pseudo;
                    else if (ctrl.Name == "j2TxtBox") ctrl.Text = J2.Pseudo;
                }
                // On lance le nouveau form et on ferme le present
                init.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Fermeture du formulaire, on affiche le menu principal si on ne part
        /// pas en nouvelle partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinPartie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsNewPartie)
            {
                if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
            }
            this.Dispose();
        }
        /// <summary>
        /// Fermeture du formulaire, on affiche le menu principal si on ne part
        /// pas en nouvelle partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBtn_Click(object sender, EventArgs e)
        {
            if (!IsNewPartie)
            {
                if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
            }
            this.Dispose();
        }
    }
}
