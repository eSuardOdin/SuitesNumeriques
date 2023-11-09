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
            InitJoueurs init = new();
            init.Show();
        }
    }
}