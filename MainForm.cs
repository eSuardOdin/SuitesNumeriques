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
            Entrainement training = new Entrainement(arithm�tiquesToolStripMenuItem.Text);
            training.Show();
        }
    }
}