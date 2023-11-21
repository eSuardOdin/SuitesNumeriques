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
    public partial class Rules : Form
    {
        private Jeu ParentForm { get; set; }
        public Rules(Jeu parentForm)
        {
            InitializeComponent();

            ParentForm = parentForm;

            rulesBox.Text += "- Le jeu se joue à 2 joueurs à tour de rôle avec 6 questions par parties.\n\n\n";
            rulesBox.Text += "- À chaque tour, un calcul de même nature sur les suites est demandé.\n\n\n";
            rulesBox.Text += "- Un joueur peut valider sa réponse ou passer la question.\n\n\n";
            rulesBox.Text += "- La partie peut être chronométrée ou non.\n\n\n";
            rulesBox.Text += "- Si le joueur valide une bonne réponse, il gagne 150 points. Dans une partie chronométrée, il gagne de plus le nombre de secondes restantes multipliées par 5.\n\n\n";
            rulesBox.Text += "- Passer ou répondre faux à une question ne modifie pas les points.";

            rulesBox.Font = new Font(rulesBox.Font, FontStyle.Bold);
            rulesBox.ReadOnly = true;

            ParentForm.Enabled = false;

            if (ParentForm is JeuTimer jeuParent)
            {
                label1.Visible = true;
                label2.Visible = true;
            }
        }


        private void Rules_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Enabled = true;

            // On relance le timer si jeu avec contrainte
            if (ParentForm is JeuTimer jeuParent)
            {
                jeuParent.EnableTimer();
            }
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            ParentForm.Enabled = true;

            // On relance le timer si jeu avec contrainte
            if (ParentForm is JeuTimer jeuParent)
            {
                jeuParent.EnableTimer();
            }
            this.Dispose();
        }

        private void Rules_Load(object sender, EventArgs e)
        {

        }
    }
}
