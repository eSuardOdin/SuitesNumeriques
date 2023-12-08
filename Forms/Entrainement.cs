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
    /// <summary>
    /// Classe gérant le formulaire d'entrainement
    /// </summary>
    public partial class Entrainement : Form
    {
        /// <summary>
        /// Reference du formulaire principal
        /// </summary>
        private MainForm MyMainForm { get; set; }
        /// <summary>
        /// Type de la partie "géométrique" ou "arithmétique"
        /// </summary>
        public string TypePartie { get; private set; }
        /// <summary>
        /// Array d'exercices
        /// </summary>
        public Exercice[] Exos { get; private set; } = new Exercice[6];

        /// <summary>
        /// Constructeur du formulaire d'entrainement
        /// </summary>
        /// <param name="label">Type de partie à afficher dans le nom de la fenêtre</param>
        /// <param name="typePartie">Type de la partie</param>
        /// <param name="mainForm">Reference vers le formulaire de menu principal</param>
        public Entrainement(string label, string typePartie, MainForm mainForm)
        {
            InitializeComponent();
            MyMainForm = mainForm;
            TypePartie = typePartie;
            this.Text = $"Suites {label}: Rechercher...";
            InitExos();
        }

        /// <summary>
        /// Instancie les exercices en une classe enfant du type Exercice en fonction du Tag de l'onglet
        /// puis affiche l'énoncé
        /// </summary>
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


        //--------------------------
        // EVENTS
        //--------------------------

        /// <summary>
        /// Fermeture du formulaire et affichage du menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entrainement_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyMainForm.Show();
            this.Dispose();
        }
    }
}
