namespace SuitesNumeriques
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void arithm�tiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(arithm�tiquesToolStripMenuItem.Text, arithm�tiquesToolStripMenuItem.Tag.ToString());
            training.Show();
        }

        private void g�om�triquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrainement training = new Entrainement(g�om�triquesToolStripMenuItem.Text, g�om�triquesToolStripMenuItem.Tag.ToString());
            training.Show();
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
    }
}