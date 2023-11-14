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
    public partial class InitJoueurs : Form
    {
        private Jeu? MyJeu { get; set; } = null;
        MainForm mainForm;
        public InitJoueurs(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Lancement de la partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void launchBtn_Click(object sender, EventArgs e)
        {
            Player j1 = new(j1TxtBox.Text);
            Player j2 = new(j2TxtBox.Text);
            string typePartie = "";
            foreach (RadioButton btn in suiteBox.Controls)
            {
                if (btn is RadioButton)
                {
                    if (btn.Checked == true) typePartie = btn.Tag.ToString();
                }
            }
            // Vérification de l'input et lancement du jeu si ok (À IMPLEMENTER)
            if (InputValidation())
            {
                MyJeu = new Jeu(j1, j2, typePartie, mainForm);
                MyJeu.Show();
                this.Close();
            }  
        }


        private void InitJoueurs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            // Si la partie n'est pas lancée, on fait réapparaitre le mainForm
            if (mainForm != null && !mainForm.Visible && MyJeu == null) mainForm.Show();
        }

        /// <summary>
        /// Validation du formulaire de création de partie
        /// </summary>
        /// <returns>La validité du form (ou alors je return un string d'erreurs)</returns>
        private bool InputValidation()
        {

            return true;
        }
    }
}
