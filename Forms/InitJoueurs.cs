using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuitesNumeriques
{
    /// <summary>
    /// Classe gérant le formulaire d'initialisation d'une partie et de ses joueurs
    /// </summary>
    public partial class InitJoueurs : Form
    {
        /// <summary>
        /// Pour lancer une partie avec ou sans contrainte de temps
        /// </summary>
        private bool IsTimed {  get; set; }

        /// <summary>
        /// Le jeu à initialiser
        /// </summary>
        private Jeu? MyJeu { get; set; } = null;

        /// <summary>
        /// Reference vers le menu principal
        /// </summary>
        MainForm mainForm;

        /// <summary>
        /// Constructeur, affecte les arguments aux attributs de l'objet
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="isTimed"></param>
        public InitJoueurs(MainForm mainForm, bool isTimed)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            IsTimed = isTimed;
        }


        /// <summary>
        /// Validation du formulaire de création de partie
        /// </summary>
        /// <returns>Une string d'erreurs ou une string vide si ok</returns>
        private string InputValidation()
        {
            string err = "";
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            if (j1TxtBox.Text == "") err += "J1: Le champ de saisie ne doit pas être vide.\n";
            else if (!regex.IsMatch(j1TxtBox.Text)) err += "J1: Le nom du joueur ne doit contenir que des caractères alphanumériques.\n";
            else if (j1TxtBox.Text.Length > 20) err += "J1: Le nom du joueur ne doit pas contenir plus de 20 caractères.\n";
            if (j2TxtBox.Text == "") err += "J2: Le champ de saisie ne doit pas être vide.\n";
            else if (!regex.IsMatch(j2TxtBox.Text)) err += "J2: Le nom du joueur ne doit contenir que des caractères alphanumériques.\n";
            else if (j2TxtBox.Text.Length > 20) err += "J2: Le nom du joueur ne doit pas contenir plus de 20 caractères.\n";

            if (j1TxtBox.Text == j2TxtBox.Text && err == "") err += "Les deux joueurs ne peuvent avoir le même nom";
            return err;
        }


        //------------------
        //  EVENTS
        //------------------


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
            // Vérification de l'input et lancement du jeu si ok
            string err = InputValidation();
            if (err == "")
            {
                if (!IsTimed)
                {
                    MyJeu = new Jeu(j1, j2, typePartie, mainForm);
                }
                else
                {
                    MyJeu = new JeuTimer(j1, j2,typePartie, mainForm, new TimeManager(120));
                }
                MyJeu.Show();
                this.Close();
            }
            // Message si erreurs
            else MessageBox.Show(err, "Erreur création de partie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /// <summary>
        /// Fermeture du formulaire et ouverture du menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitJoueurs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            // Si la partie n'est pas lancée, on fait réapparaitre le mainForm
            if (mainForm != null && !mainForm.Visible && MyJeu == null) mainForm.Show();
        }

        
    }
}
