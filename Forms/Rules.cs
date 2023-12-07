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
    /// Classe gérant le formulaire de règles
    /// </summary>
    public partial class Rules : Form
    {
        /// <summary>
        /// Le formulaire parent (ici, le jeu avec/sans contrainte)
        /// </summary>
        private Jeu ParentForm { get; set; }
       
        /// <summary>
        /// Constructeur de Rules
        /// </summary>
        /// <param name="parentForm"></param>
        public Rules(Jeu parentForm)
        {
            InitializeComponent();

            ParentForm = parentForm;

            // Mise à jour du texte et police des règles
            rulesBox.Text += "- Le jeu se joue à 2 joueurs à tour de rôle avec 6 questions par parties.\n\n\n";
            rulesBox.Text += "- À chaque tour, un calcul de même nature sur les suites est demandé.\n\n\n";
            rulesBox.Text += "- Un joueur peut valider sa réponse ou passer la question.\n\n\n";
            rulesBox.Text += "- La partie peut être chronométrée ou non.\n\n\n";
            rulesBox.Text += "- Si le joueur valide une bonne réponse, il gagne 150 points. Dans une partie chronométrée, il gagne de plus le nombre de secondes restantes multipliées par 5.\n\n\n";
            rulesBox.Text += "- Passer ou répondre faux à une question ne modifie pas les points.";

            rulesBox.Font = new Font(rulesBox.Font, FontStyle.Bold);
            rulesBox.ReadOnly = true;

            // Désactivation du jeu
            ParentForm.Enabled = false;

            // Si jeu avec contrainte, on affiche un message supplémentaire
            if (ParentForm is JeuTimer)
            {
                label1.Visible = true;
                label2.Visible = true;
            }
        }


        /// <summary>
        /// Gestion de la fermeture des règles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rules_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Réactivation du jeu
            ParentForm.Enabled = true;
            // On relance le timer si jeu avec contrainte
            if (ParentForm is JeuTimer jeuParent)
            {
                jeuParent.EnableTimer();
            }
            this.Dispose();
        }

        /// <summary>
        /// Retour au jeu par bouton "OK"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            // Réactivation du jeu
            ParentForm.Enabled = true;
            // On relance le timer si jeu avec contrainte
            if (ParentForm is JeuTimer jeuParent)
            {
                jeuParent.EnableTimer();
            }
            this.Dispose();
        }
    }
}
