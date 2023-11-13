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
            InitJoueurs init = new(this); // LE THIS EST NOUVEAU ET CORRESPOND AU MAINMENU
            init.Show();
            // On s'abonne à son event de lancement
            //init.FormClosed += InitJoueurs_FormClosed;
            // On instancie le formulaire de partie sans le montrer (pour s'abonner à son event de fermeture)

            // On cache le formulaire principal
            this.Hide();
        }
    }
}