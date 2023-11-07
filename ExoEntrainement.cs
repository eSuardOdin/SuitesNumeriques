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
        public ExoEntrainement()
        {
            InitializeComponent();
            //GetExoType(index, typeSuite);
            //GetExoLabels();
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

    }
}
