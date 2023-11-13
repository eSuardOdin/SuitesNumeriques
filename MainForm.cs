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
            InitJoueurs init = new(this); // LE THIS EST NOUVEAU ET CORRESPOND AU MAINMENU
            init.Show();
            // On s'abonne � son event de lancement
            //init.FormClosed += InitJoueurs_FormClosed;
            // On instancie le formulaire de partie sans le montrer (pour s'abonner � son event de fermeture)

            // On cache le formulaire principal
            this.Hide();
        }
    }
}