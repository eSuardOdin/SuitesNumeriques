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

    public partial class Jeu : Form
    {
        private int IndexExercice { get; set; }
        public UntimedVersus Versus { get; private set; } // Pas sûr du tout
        public List<Player> Players { get; private set; } = new();
        private bool IsFirstPlayer { get; set; }
        public Player J1 { get; private set; }
        public Player J2 { get; private set; }
        public Jeu(Player j1, Player j2, string typePartie)
        {
            InitializeComponent();
            J1 = j1;
            J2 = j2;
            Versus = new UntimedVersus(typePartie, j1, j2);
            IsFirstPlayer = true;
            IndexExercice = 0;
            exoContainer.Text = $"Question N°{IndexExercice + 1}/6";
            enonceLbl.Text = Versus.Exercices[IndexExercice].Enonce;
            ResetAffichage(j1, Versus.Exercices[IndexExercice]);
            //ExoEntrainement exo = new ExoEntrainement();
            //exo.GetExoType(IndexExercice, typePartie);
            //exo.GetExoLabels();
            //exoContainer.Controls.Add(exo);
        }

        /// <summary>
        /// Doit contenir la logique de jeu d'une partie
        /// </summary>
        private void Play()
        {
            bool isFirstPlayer = true; // Le tour du joueur en cours
            bool submitted = false;
            int currentExercice = 1;
            foreach (Exercice ex in Versus.Exercices)
            {
                foreach (Player p in Versus.Players)
                {

                }
            }
        }


        /// <summary>
        /// Soummettre la réponse d'un joueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validBtn_Click(object sender, EventArgs e)
        {
            if (IsFirstPlayer)
            {
                if (J1.Repondre(Versus.Exercices.ElementAt(IndexExercice), repTxtBox.Text, 0))
                {
                    MessageBox.Show("Bonne réponse !");
                }
                else
                {
                    MessageBox.Show("Mauvaise réponse !");
                }
                Versus.Exercices[IndexExercice].GetNewSuite(Versus.TypeSuite);
            }
            else
            {
                if (J2.Repondre(Versus.Exercices.ElementAt(IndexExercice), repTxtBox.Text, 0))
                {
                    MessageBox.Show("Bonne réponse !");
                }
                else
                {
                    MessageBox.Show("Mauvaise réponse !");
                }
                IndexExercice++;
            }
            IsFirstPlayer = !IsFirstPlayer;
            if (!IsFirstPlayer && IndexExercice <= 5)
            {
                ResetAffichage(J2, Versus.Exercices[IndexExercice]);
            }
            else
            {
                ResetAffichage(J1, Versus.Exercices[IndexExercice]);
            }
        }


        private void ResetAffichage(Player p, Exercice exo)
        {
            enonceLbl.Text = exo.Enonce;
            exoContainer.Text = $"Question N°{IndexExercice + 1}/6";
            joueurTxt.Text = p.Pseudo;
            joueurLbl.Text = IsFirstPlayer == true ? "Joueur N°1" : "Joueur N°2";
            joueurTxt.ForeColor = IsFirstPlayer == true ? Color.Red : Color.Blue;
            pointsTxt.Text = p.Score.ToString();
            pointsTxt.ForeColor = IsFirstPlayer == true ? Color.Red : Color.Blue;
            repTxtBox.Text = "";
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            Player currentPlayer = IsFirstPlayer ? J1 : J2;
            Versus.Exercices[IndexExercice].GetNewSuite(Versus.TypeSuite);
            currentPlayer.AddReset();
            ResetAffichage(currentPlayer, Versus.Exercices[IndexExercice]);
        }
    }
}
