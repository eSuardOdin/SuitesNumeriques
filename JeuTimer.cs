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
    /// Classe gérant le formulaire de jeu avec contrainte
    /// </summary>
    public partial class JeuTimer : Jeu
    {
        /// <summary>
        /// Instance de la classe gérant le timer et ses events
        /// </summary>
        private TimeManager MyTimeManager { get; set; }
        
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="j1">Joueur 1</param>
        /// <param name="j2">Joueur 2</param>
        /// <param name="typePartie">Type de la partie (arithmétique, géométrique ou quelconque si implémentée)</param>
        /// <param name="mainForm">Le formulaire parent</param>
        /// <param name="tm">Le time manager</param>
        public JeuTimer(Player j1, Player j2, string typePartie, MainForm mainForm, TimeManager tm) : base(j1, j2, typePartie, mainForm)
        {
            InitializeComponent();
            
            // Instance du timer
            MyTimeManager = tm;
            MyTimeManager.SecondsLeftChanged += UpdateTimeLabel;
        }

        /// <summary>
        /// Update du label indiquant le temps restant
        /// </summary>
        /// <param name="secondsLeft">Le nombre de secondes restantes à afficher</param>
        private void UpdateTimeLabel(int secondsLeft)
        {
            if (timeLbl.InvokeRequired && this != null)
            {
                timeLbl.Invoke((MethodInvoker)delegate { timeLbl.Text = $"{(secondsLeft / 60).ToString()}min {(secondsLeft % 60).ToString()}sec"; });
                if (secondsLeft / 60 == 0) timeLbl.ForeColor = Color.Red;
                else timeLbl.ForeColor = Color.Green;
            }
            else
            {
                timeLbl.Text = secondsLeft.ToString();
                timeLbl.Text = $"{(secondsLeft/60).ToString()}min {(secondsLeft%60).ToString()}sec";
                if (secondsLeft / 60 == 0) timeLbl.ForeColor = Color.Red;
                else timeLbl.ForeColor = Color.Green;
            }
        }


        /// <summary>
        /// Override base.EndGame() pour que FinPartie écrive les meilleurs scores
        /// </summary>
        protected override void EndGame()
        {
            // Fin de partie timée
            FinPartie fin = new(J1, J2, Versus.TypeSuite, MyMainForm, true);
            fin.Show();
            this.Dispose();
        }


        /// <summary>
        /// Utilisé pour relancer le timer depuis le formulaire de règles
        /// </summary>
        public void EnableTimer() => MyTimeManager.MyTimer.Start();
        

        
        
        //--------------------------
        // EVENTS
        //--------------------------


        /// <summary>
        /// Click du bouton valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void validBtn_Click(object sender, EventArgs e)
        {
            Player currentPlayer = IsFirstPlayer ? J1 : J2;
            
            // Si on est pas dans la dernière question on ne prend pas en compte les radio buttons:
            if(IndexExercice != 5)
            {
                if (currentPlayer.Repondre(Versus.Exercices[IndexExercice], base.getRepTxtBox(false)))
                {
                    currentPlayer.AddTime(MyTimeManager.SecondsLeft);
                    currentPlayer.AddTimedScore(MyTimeManager.SecondsLeft);
                }
            }
            else
            {
                if (currentPlayer.Repondre(Versus.Exercices[IndexExercice], base.getRepTxtBox(true)))
                {
                    currentPlayer.AddTime(MyTimeManager.SecondsLeft);
                    currentPlayer.AddTimedScore(MyTimeManager.SecondsLeft);
                }
            }
            
            // Reset du timer
            MyTimeManager.ResetTimer();
            base.validBtn_Click(sender, e);
        }


        /// <summary>
        /// Mets à jour le timer puis base.Event()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void skipBtn_Click(object sender, EventArgs e)
        {
            UpdateTimeLabel(MyTimeManager.SecondsLeft);
            base.skipBtn_Click(sender, e);
        }

        /// <summary>
        /// Désactive le timer et affiche les règles 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void reglesBtn_Click(object sender, EventArgs e)
        {
            MyTimeManager.MyTimer.Stop();
            base.reglesBtn_Click(sender, e);
        }

        /// <summary>
        /// On ferme le jeu et réactive le menu principal. Attention : Peut provoquer des null ref quand le timer cherche à mettre
        /// à jour le label qui a déjà été dispose. Je n'arrive pas encore à gérer les cas où ça arrive..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Pour eviter la null reference de l'event qui ne peut pas mettre à jour le form
            MyTimeManager.MyTimer.Stop();

            base.Jeu_FormClosed(sender, e);
        }
    }
}
