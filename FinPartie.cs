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
    public partial class FinPartie : Form
    {
        private IOScoreManager? MyScoreManager { get; set; }
        
        private bool IsTimed { get; set; }
        private MainForm MyMainForm { get; set; }
        private Player J1 { get; set; }
        private Player J2 { get; set; }
        private string TypePartie { get; set; }
        private bool IsNewPartie { get; set; } = false; // Permettra de choisir si on remontre le MainForm au Close
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
                    // Check du radio btn
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


        private void FinPartie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsNewPartie)
            {
                if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
            }
            this.Dispose();
        }

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
