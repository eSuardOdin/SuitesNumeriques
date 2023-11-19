using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuitesNumeriques
{
    public partial class HighScores : Form
    {
        private IOScoreManager? ScoreManager { get; set; }
        private string TypeSuite { get; set; }
        private MainForm MyMainForm { get; set; }
        public HighScores(MainForm mainForm, string typeSuite)
        {
            InitializeComponent();
            MyMainForm = mainForm;
            TypeSuite = typeSuite;
            // Maj du nom fenêtre
            this.Text += $": Suite {TypeSuite}";
            ScoreManager = new(TypeSuite);
            scoresLbl.Text = ScoreManager.GetHighScores();
        }



        private void HighScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
            this.Dispose();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {

            if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
            this.Dispose();
        }


    }
}
