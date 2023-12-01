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
    public partial class ExoEntrainement : UserControl
    {
        /// <summary>
        /// L'exercice géré par le control
        /// </summary>
        private Exercice? Exo { get; set; }
        //private string TypeSuite { get; set; }
        public ExoEntrainement(/*string typeSuite*/)
        {
            InitializeComponent();
            repStatutLbl.Location = new Point(375, 295);
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
                    repBox.Visible = false;
                    repBox.Enabled = false;
                    reponseLbl.Visible = false;
                    premierTermeLbl.Visible = true;
                    premierTermeTxtBox.Visible = true;
                    premierTermeTxtBox.Enabled = true;
                    raisonLbl.Visible = true;
                    raisonTxtBox.Visible = true;
                    raisonTxtBox.Enabled = true;
                    break;
                case 4:
                    Exo = new ExoSomme(typeSuite);
                    break;
                case 5:
                    Exo = new ExoMonotonie(typeSuite);
                    repBox.Visible = false;
                    repBox.Enabled = false;
                    reponseLbl.Visible = false;
                    groupBox1.Visible = true;
                    radio0.Checked = true;
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
            repBox.Text = "";
            repStatutLbl.Text = "";
            raisonTxtBox.Text = "";
            premierTermeTxtBox.Text = "";
        }

        private void validBtn_Click(object sender, EventArgs e)
        {
            if(Exo is ExoMonotonie)
            {
                foreach (Control btn in groupBox1.Controls)
                {
                    if (btn is System.Windows.Forms.RadioButton radio)
                    {
                        if (radio.Checked == true) repBox.Text = radio.Text;
                    }
                }
            }
            else if (Exo is ExoRaison)
            {
                repBox.Text = $"{raisonTxtBox.Text} {premierTermeTxtBox.Text}";
            }
            System.Diagnostics.Debug.WriteLine(repBox.Text);
            if (repBox.Text == Exo.Reponse)
            {
                repStatutLbl.ForeColor = Color.Blue;
                repStatutLbl.Text = "Bonne réponse !";
            }
            else
            {
                repStatutLbl.ForeColor = Color.Red;
                repStatutLbl.Text = "Mauvaise réponse...";
            }
        }
    }
}
