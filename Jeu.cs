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
        MainForm mainForm;
        private int IndexExercice { get; set; }
        public UntimedVersus Versus { get; private set; } // Pas sûr du tout
        public List<Player> Players { get; private set; } = new();
        private bool IsFirstPlayer { get; set; }
        public Player J1 { get; private set; }
        public Player J2 { get; private set; }
        public Jeu(Player j1, Player j2, string typePartie, MainForm mainForm)
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
            this.mainForm = mainForm;
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
        private void validBtn_Click(object sender, EventArgs e) //ATTENTION, JE N'AI PAS IMPLEMENTE LA PRISE EN COMPTE DE LA REP EN RADIO BTN
                                                                // Peut faire GetAnswer qui donnerait soit la txtbox soit le radiobtn en fonction de IndexExo
        {
            Player currentPlayer = IsFirstPlayer ? J1 : J2;
            ShowAnswerResult(currentPlayer, Versus.Exercices[IndexExercice], repTxtBox.Text, 0);

            if (IsFirstPlayer) Versus.Exercices[IndexExercice].GetNewSuite(Versus.TypeSuite);

            else IndexExercice++;

            IsFirstPlayer = !IsFirstPlayer;
            if (!IsFirstPlayer && IndexExercice <= 5)
            {
                ResetAffichage(J2, Versus.Exercices[IndexExercice]);
            }
            else if (IndexExercice == 6)
            {
                // Handle end game (On va cacher le form, à implémenter)
                validBtn.Enabled = false;
            }
            else
            {
                ResetAffichage(J1, Versus.Exercices[IndexExercice]);
                if (IndexExercice == 5) SwitchInputType(true);
            }
        }

        /// <summary>
        /// Rafraichit l'affichage du formulaire par rapport au joueur dont c'est le tour
        /// </summary>
        /// <param name="p">Joueur en cours</param>
        /// <param name="exo">Exercice en cours</param>
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

        /// <summary>
        /// Termine une partie, affiche le formulaire de scores.
        /// </summary>
        private void EndVersus()
        {
            // à faire
        }

        /// <summary>
        /// Passer le tour du joueur en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skipBtn_Click(object sender, EventArgs e)
        {
            // Si c'est le 2ème joueur qui skip, on incrémente l'index d'exercice.
            if (!IsFirstPlayer)
            {
                IndexExercice++;
                // On montre les radio btns si dernier exercice
                if (IndexExercice == 5) SwitchInputType(true);
            }
            if (IndexExercice == 6)
            {
                // Handle end game (On va cacher le form, à implémenter)
                validBtn.Enabled = false;
                EndVersus();
            }
            else
            {
                // On change de joueur et de suite
                IsFirstPlayer = !IsFirstPlayer;
                Player currentPlayer = IsFirstPlayer ? J1 : J2;
                Versus.Exercices[IndexExercice].GetNewSuite(Versus.TypeSuite);
                ResetAffichage(currentPlayer, Versus.Exercices[IndexExercice]);
            }
            //ResetAffichage(currentPlayer, Versus.Exercices[IndexExercice]);
        }

        /// <summary>
        /// Affiche le résultat dans une message box (maladroit car n'est qu'un appel d'une méthode de Player)
        /// </summary>
        /// <param name="p">Joueur répondant</param>
        /// <param name="exo">Exercice en cours</param>
        /// <param name="reponse">Réponse du joueur</param>
        /// <param name="t">Temps restant de l'exercice</param>
        private void ShowAnswerResult(Player p, Exercice exo, string reponse, int t)
        {
            if (p.Repondre(exo, reponse, t))
            {
                MessageBox.Show("Réponse correcte.", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Réponse incorrecte.", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Permet de switch entre radio button et textbox
        /// </summary>
        /// <param name="isRadio">Si true, montrer les radio buttons</param>
        private void SwitchInputType(bool isRadio)
        {
            bool isOneChecked = false;
            if (isRadio)
            {
                repTxtBox.Visible = false;
                repTxtBox.Enabled = false;
                foreach (Control btn in repBox.Controls)
                {
                    if (btn is RadioButton)
                    {
                        btn.Visible = true;
                        btn.Enabled = true;
                        if (!isOneChecked)
                        {
                            ((RadioButton)btn).Checked = true;
                            isOneChecked = !isOneChecked;
                        }
                    }
                }
            }
            else
            {
                repTxtBox.Visible = true;
                repTxtBox.Enabled = true;
                foreach (Control btn in repBox.Controls)
                {
                    if (btn is RadioButton)
                    {
                        btn.Visible = false;
                        btn.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{J1.Pseudo}: {J1.Score}\n{J2.Pseudo}: {J2.Score}", "Partie en cours...", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void reglesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implémenter les règles ici");
        }

        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            if (mainForm != null && !mainForm.Visible) mainForm.Show();
        }

        private void Jeu_Load(object sender, EventArgs e)
        {

        }
    }
}
