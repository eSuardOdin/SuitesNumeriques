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
        private MainForm MyMainForm { get; set; }
        private Player J1 { get; set; }
        private Player J2 { get; set; }
        private string TypePartie { get; set; }
        private bool IsNewPartie { get; set; } = false; // Permettra de choisir si on remontre le MainForm au Close
        public FinPartie(Player j1, Player j2, string typePartie, MainForm mainForm)
        {
            InitializeComponent();
            J1 = j1;
            J2 = j2;
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
            InitJoueurs init = new(MyMainForm);
            // Pré remplissage des champs
            foreach (Control ctrl in init.Controls)
            {
                if (ctrl is RadioButton radioButton)
                {
                    if (radioButton.Tag.ToString() == TypePartie) radioButton.Checked = true; // Ne marche pas encore
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
            this.Dispose();
            if (!IsNewPartie)
            {
                if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            FinPartie_FormClosed(sender, (FormClosedEventArgs)e);
        }
    }
}
