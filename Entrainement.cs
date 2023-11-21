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
    public partial class Entrainement : Form
    {
        private MainForm MyMainForm { get; set; }
        public string TypePartie { get; private set; }
        public Partie Partie { get; private set; }

        /*
         * Test de ramener les exercices dans le form
         */
        public Exercice[] Exos { get; private set; } = new Exercice[6];

        public Entrainement(string label, string typePartie, MainForm mainForm)
        {
            InitializeComponent();
            MyMainForm = mainForm;
            TypePartie = typePartie;
            Partie = new Partie(TypePartie);
            this.Text = $"Suites {label}: Rechercher...";
            InitExos();
        }


        private void InitExos()
        {
            exo0.Tag = TypePartie;
            exo1.Tag = TypePartie;
            exo2.Tag = TypePartie;
            exo3.Tag = TypePartie;
            exo4.Tag = TypePartie;
            exo5.Tag = TypePartie;
            exo0.GetExoType(Convert.ToInt32(tab0.Tag), TypePartie);
            exo0.GetExoLabels();
            exo1.GetExoType(Convert.ToInt32(tab1.Tag), TypePartie);
            exo1.GetExoLabels();
            exo2.GetExoType(Convert.ToInt32(tab2.Tag), TypePartie);
            exo2.GetExoLabels();
            exo3.GetExoType(Convert.ToInt32(tab3.Tag), TypePartie);
            exo3.GetExoLabels();
            exo4.GetExoType(Convert.ToInt32(tab4.Tag), TypePartie);
            exo4.GetExoLabels();
            exo5.GetExoType(Convert.ToInt32(tab5.Tag), TypePartie);
            exo5.GetExoLabels();
        }

        private void Entrainement_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyMainForm.Show();
            this.Dispose();
        }
    }
}
