namespace SuitesNumeriques
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void arithmétiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(arithmétiquesToolStripMenuItem.Text, arithmétiquesToolStripMenuItem.Tag.ToString());
            training.Show();
        }

        private void géométriquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(géométriquesToolStripMenuItem.Text, géométriquesToolStripMenuItem.Tag.ToString());
            training.Show();
        }

        private void sansContrainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On instancie et montre le formulaire de création de partie
            InitJoueurs init = new(this, false); // LE THIS EST NOUVEAU ET CORRESPOND AU MAINMENU
            init.Show();

            // On cache le formulaire principal
            this.Hide();
        }

        private void avecContrainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On instancie et montre le formulaire de création de partie
            InitJoueurs init = new(this, true); // LE THIS EST NOUVEAU ET CORRESPOND AU MAINMENU
            init.Show();

            // On cache le formulaire principal
            this.Hide();
        }

        private void arithmétiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores hs = new(this, "arithmétique");
            hs.Show();

            this.Hide();
        }

        private void géométriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores hs = new(this, "géométrique");
            hs.Show();

            this.Hide();
        }
    }
}