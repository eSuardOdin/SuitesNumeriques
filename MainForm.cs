namespace SuitesNumeriques
{
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

        private void g�om�triquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(g�om�triquesToolStripMenuItem.Text, g�om�triquesToolStripMenuItem.Tag.ToString(), this);
            training.Show();
            this.Hide();
        }

        private void sansContrainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On instancie et montre le formulaire de cr�ation de partie
            InitJoueurs init = new(this, false); // LE THIS EST NOUVEAU ET CORRESPOND AU MAINMENU
            init.Show();

            // On cache le formulaire principal
            this.Hide();
        }

        private void avecContrainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On instancie et montre le formulaire de cr�ation de partie
            InitJoueurs init = new(this, true); // LE THIS EST NOUVEAU ET CORRESPOND AU MAINMENU
            init.Show();

            // On cache le formulaire principal
            this.Hide();
        }

        private void arithm�tiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores hs = new(this, "arithm�tique");
            hs.Show();

            this.Hide();
        }

        private void g�om�triqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores hs = new(this, "g�om�trique");
            hs.Show();

            this.Hide();
        }
    }
}