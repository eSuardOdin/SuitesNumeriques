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
            Entrainement ent = new Entrainement();
            ent.Show();
        }
    }
}