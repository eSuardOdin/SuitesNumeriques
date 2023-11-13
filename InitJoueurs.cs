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
    public partial class InitJoueurs : Form
    {
        MainForm mainForm;
        public InitJoueurs(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            Player j1 = new(j1TxtBox.Text);
            Player j2 = new(j2TxtBox.Text);
            string typePartie = "";
            foreach(RadioButton btn in suiteBox.Controls)
            {
                if (btn is RadioButton)
                {
                    if (btn.Checked == true) typePartie = btn.Tag.ToString();
                }
            }
            Jeu jeu = new Jeu(j1, j2, typePartie, mainForm);
            jeu.Show();
            this.Close();
        }


        /*private void InitJoueurs_FormClosed(object sender, FormClosedEventArgs e) 
        {
            if (FormClosed != null) FormClosed(this, e);
        }*/
    }
}
