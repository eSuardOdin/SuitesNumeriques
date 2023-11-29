namespace SuitesNumeriques
{
    /// <summary>
    /// Classe g�rant le menu principal
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// Ouverture du formulaire d'entrainement aux suites arithm�tiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arithm�tiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(arithm�tiquesToolStripMenuItem.Text, arithm�tiquesToolStripMenuItem.Tag.ToString(), this);
            training.Show();
            this.Hide();
        }

        /// <summary>
        /// Ouverture du formulaire d'entrainement aux suites g�om�triques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void g�om�triquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(g�om�triquesToolStripMenuItem.Text, g�om�triquesToolStripMenuItem.Tag.ToString(), this);
            training.Show();
            this.Hide();
        }

        /// <summary>
        /// Ouverture d'un formulaire de cr�ation du jeu sans contrainte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sansContrainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On instancie et montre le formulaire de cr�ation de partie
            InitJoueurs init = new(this, false);
            init.Show();

            // On cache le formulaire principal
            this.Hide();
        }

        /// <summary>
        /// Ouverture d'un formulaire de cr�ation du jeu avec contrainte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avecContrainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On instancie et montre le formulaire de cr�ation de partie
            InitJoueurs init = new(this, true);
            init.Show();

            // On cache le formulaire principal
            this.Hide();
        }

        /// <summary>
        /// Ouverture du formulaire de scores arithm�tiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arithm�tiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores hs = new(this, "arithm�tique");
            hs.Show();

            this.Hide();
        }

        /// <summary>
        /// Ouverture du formulaire de scores g�om�triques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void g�om�triqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores hs = new(this, "g�om�trique");
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
            MessageBox.Show("Fonctionnalit� en projet", "En construction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}