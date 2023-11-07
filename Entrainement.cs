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
        public string TypePartie { get; private set; }
        public Partie Partie { get; private set; }

        public Entrainement(string label, string typePartie)
        {
            InitializeComponent();
            TypePartie = typePartie;
            Partie = new Partie(TypePartie);
            this.Text = $"Suites {label}: Rechercher...";
            // Debug
            string txt = "";
            foreach (var ex in Partie.Exercices)
            {
                txt += $"- {ex.ToString()} : Raison -> {ex.SuiteExo.Raison}, Premier terme -> {ex.SuiteExo.PremierTerme}\n";
            }
            MessageBox.Show(txt);
        }
    }
}
