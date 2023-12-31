﻿using System;
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
    /// Classe gérant le formulaire d'affichage des meilleurs scores
    /// </summary>
    public partial class HighScores : Form
    {
        /// <summary>
        /// Score manager pour aller lire les fichiers et remplir la ListView
        /// </summary>
        private IOScoreManager? ScoreManager { get; set; }

        /// <summary>
        /// "arithmétique" ou "géométrique"
        /// </summary>
        private string TypeSuite { get; set; }

        /// <summary>
        /// Réference vers le formulaire principal
        /// </summary>
        private MainForm MyMainForm { get; set; }

        /// <summary>
        /// Constructeur, affiche les informations de la fenêtre et appelle la méthode du ScoreManager pour remplir la ListView
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="typeSuite"></param>
        public HighScores(MainForm mainForm, string typeSuite)
        {
            InitializeComponent();
            MyMainForm = mainForm;
            TypeSuite = typeSuite;
            this.Text += $": Suite {TypeSuite}";
            ScoreManager = new(TypeSuite);
            ScoreManager.PopulateList(scoresList);
        }


        //------------------
        //  EVENTS
        //------------------


        /// <summary>
        /// Fermeture de la fenêtre et affichage du menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
            this.Dispose();
        }

        /// <summary>
        /// Fermeture de la fenêtre et affichage du menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBtn_Click(object sender, EventArgs e)
        {

            if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
            this.Dispose();
        }

        /// <summary>
        /// Empêche de resize les colonnes du tableau de scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scoresList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = scoresList.Columns[e.ColumnIndex].Width;
        }
    }
}
