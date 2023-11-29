namespace SuitesNumeriques
{
    /// <summary>
    /// Classe gérant le menu principal
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// Ouverture du formulaire d'entrainement aux suites arithmétiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arithmétiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(arithmétiquesToolStripMenuItem.Text, arithmétiquesToolStripMenuItem.Tag.ToString(), this);
            training.Show();
            this.Hide();
        }

        /// <summary>
        /// Ouverture du formulaire d'entrainement aux suites géométriques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void géométriquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(géométriquesToolStripMenuItem.Text, géométriquesToolStripMenuItem.Tag.ToString(), this);
            training.Show();
            this.Hide();
        }

        /// <summary>
        /// Ouverture d'un formulaire de création du jeu sans contrainte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sansContrainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On instancie et montre le formulaire de création de partie
            InitJoueurs init = new(this, false);
            init.Show();

            // On cache le formulaire principal
            this.Hide();
        }

        /// <summary>
        /// Ouverture d'un formulaire de création du jeu avec contrainte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avecContrainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On instancie et montre le formulaire de création de partie
            InitJoueurs init = new(this, true);
            init.Show();

            // On cache le formulaire principal
            this.Hide();
        }

        /// <summary>
        /// Ouverture du formulaire de scores arithmétiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arithmétiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores hs = new(this, "arithmétique");
            hs.Show();

            this.Hide();
        }

        /// <summary>
        /// Ouverture du formulaire de scores géométriques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void géométriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores hs = new(this, "géométrique");
            hs.Show();

            this.Hide();
        }

        /// <summary>
        /// Entrainement aux suites quelconques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quelconquesEnProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité en projet", "En construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}