using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuitesNumeriques.classes
{
    public partial class ExoEntrainementMonotonie : UserControl
    {
        private Exercice? Exo { get; set; }
        RadioButton? CheckedRadio = null;
        public ExoEntrainementMonotonie()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet d'instancier le type d'exercice de l'onglet actuel
        /// </summary>
        /// <param name="index">L'index de l'onglet actuel</param>
        /// <param name="typeSuite">Le type de suite à gérer</param>
        public void GetExoType(int index, string typeSuite)
        {
            switch (index)
            {
                case 0:
                    Exo = new ExoTerme(typeSuite);
                    break;
                case 1:
                    Exo = new ExoPremierTerme(typeSuite);
                    break;
                case 2:
                    Exo = new ExoRang(typeSuite);
                    break;
                case 3:
                    Exo = new ExoRaison(typeSuite);
                    break;
                case 4:
                    Exo = new ExoSomme(typeSuite);
                    break;
                case 5:
                    Exo = new ExoMonotonie(typeSuite);
                    break;
                default:
                    break;
            }
        }
        public void GetExoLabels()
        {
            enonceLbl.Text = Exo.Enonce;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Exo.GetNewSuite(this.Tag.ToString());
            enonceLbl.Text = Exo.Enonce;
            CheckedRadio.Checked = false;
        }

        private void validBtn_Click(object sender, EventArgs e)
        {
            foreach(RadioButton btn in repBox.Controls)
            {
                if (btn.Checked == true) CheckedRadio = btn;
            }
            if (CheckedRadio != null)
            {
                if (CheckedRadio.Text == Exo.Reponse) MessageBox.Show("Bonne réponse");
                else MessageBox.Show("Mauvaise réponse");
            }
        }
    }
}
