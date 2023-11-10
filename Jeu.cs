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
        public UntimedVersus Versus { get; private set; } // Pas sûr du tout
        public List<Player> Players { get; private set; } = new();
        private bool IsFirstPlayer { get; set; }
        public Player J1 { get; private set; }
        public Player J2 { get; private set; }
        public Jeu(Player j1, Player j2, string typePartie)
        {
            InitializeComponent();
            //Players.Add(j1);
            //Players.Add(j2);
            //joueurTxtBox.Text = j1.Pseudo;
            J1 = j1;
            J2 = j2;
            Versus = new UntimedVersus(typePartie, j1, j2);
            IsFirstPlayer = true;
        }

        /// <summary>
        /// Doit contenir la logique de jeu d'une partie
        /// </summary>
        private void Play()
        {
            bool isFirstPlayer = true; // Le tour du joueur en cours
            bool submitted = false;
            int currentExercice = 1;
            foreach(Exercice ex in Versus.Exercices)
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
                MessageBox.Show($"{J1.Pseudo} a répondu {testRepBox.Text}");
            }
            else
            {
                MessageBox.Show($"{J2.Pseudo} a répondu {testRepBox.Text}");
            }
            IsFirstPlayer = !IsFirstPlayer;
        }
    }
}
