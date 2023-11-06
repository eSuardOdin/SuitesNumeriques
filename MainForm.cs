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
            Entrainement training = new Entrainement(arithmétiquesToolStripMenuItem.Text);
            training.Show();
        }
    }
}