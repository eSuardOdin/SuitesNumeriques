using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace SuitesNumeriques
{
    /// <summary>
    /// Classe gérant le formulaire de jeu sans contrainte
    /// </summary>
    public partial class Jeu : Form
    {
        // Reference vers le formulaire de menu principal
        protected MainForm MyMainForm;
        // Permet d'accèder à l'exercice dans Versus.Exercices[]
        protected int IndexExercice { get; set; }
        //Reste d'une classe qui permettait de tester mon app en console -!- À refactoriser -!- 
        //public UntimedVersus Versus { get; private set; }
        protected string TypeSuite { get; set; }
        protected Exercice[] Exercices { get; set; } = new Exercice[6];
        // Bool pour gérer les tours
        protected bool IsFirstPlayer { get; set; }
        public Player J1 { get; private set; }
        public Player J2 { get; private set; }

        /// <summary>
        /// Constructeur sans paramètres, utile uniquement pour pouvoir utiliser le designer de la classe enfant JeuTimer.
        /// </summary>
        public Jeu() { InitializeComponent(); }

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="j1">Joueur 1</param>
        /// <param name="j2">Joueur 2</param>
        /// <param name="typePartie">Type de la partie (arithmétique, géométrique ou quelconque si implémentée)</param>
        /// <param name="mainForm">Le formulaire parent</param>
        public Jeu(Player j1, Player j2, string typePartie, MainForm mainForm)
        {
            InitializeComponent();
            J1 = j1;
            J2 = j2;
            TypeSuite = typePartie;
            GetExercices();
            //Versus = new UntimedVersus(typePartie, j1, j2);
            IsFirstPlayer = true;
            IndexExercice = 0;
            // On affiche le premier exercice
            exoContainer.Text = $"Question N°{IndexExercice + 1}/6";
            enonceLbl.Text = Exercices[IndexExercice].Enonce;
            ResetAffichage(j1, Exercices[IndexExercice]);
            MyMainForm = mainForm;
        }


        /// <summary>
        /// Soummettre la réponse d'un joueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void validBtn_Click(object sender, EventArgs e)
        {
            Player currentPlayer = IsFirstPlayer ? J1 : J2;

            // Si exo 3, on prend la valeur des deux txtBox
            if (IndexExercice == 3)
            {
                repTxtBox.Text = GetRepTxtBox(1);
            }
            // Si dernier exercice, on prend la valeur du radio btn comme réponse.
            else if (IndexExercice == 5)
            {
                repTxtBox.Text = GetRepTxtBox(2);
            }
            // Sinon
            else repTxtBox.Text = GetRepTxtBox();

            // On process la réponse
            ShowAnswerResult(currentPlayer, Exercices[IndexExercice], repTxtBox.Text);

            // Pour passer du joueur 1 au joueur 2, on change de suite sur le même type d'exercice
            if (IsFirstPlayer) Exercices[IndexExercice].GetNewSuite(TypeSuite);
            // Sinon on change de type d'exercice
            else IndexExercice++;
            // On change le tour
            IsFirstPlayer = !IsFirstPlayer;

            // Si on est pas sur le dernier exercice et que le tour est au joueur 2
            if (!IsFirstPlayer && IndexExercice <= 5)
            {
                ResetAffichage(J2, Exercices[IndexExercice]);
            }
            // Si on a terminé
            else if (IndexExercice == 6)
            {
                EndGame();
            }
            // Sinon on reset l'affichage et montre les radio buttons en cas d'exercice sur la monotonie
            // ou les deux txt box en cas d'exercice raison et premier terme
            else
            {
                ResetAffichage(J1, Exercices[IndexExercice]);
                if (IndexExercice == 3) SwitchInputType(1);
                else if (IndexExercice == 5) SwitchInputType(2);
                else SwitchInputType();
            }
        }

        /// <summary>
        /// Rafraichit l'affichage du formulaire par rapport au joueur dont c'est le tour
        /// </summary>
        /// <param name="p">Joueur en cours</param>
        /// <param name="exo">Exercice en cours</param>
        protected void ResetAffichage(Player p, Exercice exo)
        {
            enonceLbl.Text = exo.Enonce;
            exoContainer.Text = $"Question N°{IndexExercice + 1}/6";
            joueurTxt.Text = p.Pseudo;
            joueurLbl.Text = IsFirstPlayer == true ? "Joueur N°1" : "Joueur N°2";
            joueurTxt.ForeColor = IsFirstPlayer == true ? Color.Red : Color.Blue;
            pointsTxt.Text = p.Score.ToString();
            pointsTxt.ForeColor = IsFirstPlayer == true ? Color.Red : Color.Blue;
            repTxtBox.Text = "";
            raisonTxtBox.Text = "";
            premierTermeTxtBox.Text = "";
        }



        /// <summary>
        /// Passer le tour du joueur en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void skipBtn_Click(object sender, EventArgs e)
        {
            // Si c'est le 2ème joueur qui skip, on incrémente l'index d'exercice.
            if (!IsFirstPlayer)
            {
                IndexExercice++;
                // On montre les deux txt box si exo 4
                if (IndexExercice == 3) SwitchInputType(1);
                // On montre les radio btns si dernier exercice
                else if (IndexExercice == 5) SwitchInputType(2);
                // Sinon on reset
                else SwitchInputType();
            }
            if (IndexExercice == 6)
            {
                EndGame();
            }
            else
            {
                // On change de joueur et de suite
                IsFirstPlayer = !IsFirstPlayer;
                Player currentPlayer = IsFirstPlayer ? J1 : J2;
                Exercices[IndexExercice].GetNewSuite(TypeSuite);
                ResetAffichage(currentPlayer, Exercices[IndexExercice]);
            }
        }

        /// <summary>
        /// Affiche le résultat dans une message box (maladroit car n'est qu'un appel d'une méthode de Player)
        /// </summary>
        /// <param name="p">Joueur répondant</param>
        /// <param name="exo">Exercice en cours</param>
        /// <param name="reponse">Réponse du joueur</param>
        /// <param name="t">Temps restant de l'exercice</param>
        protected void ShowAnswerResult(Player p, Exercice exo, string reponse)
        {
            if (p.Repondre(exo, reponse))
            {
                p.AddScore();
                MessageBox.Show("Réponse correcte.", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Réponse incorrecte.", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Permet de switch entre radio button, double textbox et textbox
        /// </summary>
        /// <param name="type">Si 0 : On remet l'affichage de base<br/>Si 1 : On passe aux 2 txt box<br/>Si 2 : On passe aux radio btns</param>
        protected void SwitchInputType(byte type = 0)
        {
            bool isOneChecked = false;
            // Si TextBox -> RadioButtons
            if (type == 2)
            {
                // On cache et desactive la TextBox
                repTxtBox.Visible = false;
                repTxtBox.Enabled = false;
                
                foreach (Control btn in repBox.Controls)
                {
                    // Si le control est un RadioButton
                    if (btn is System.Windows.Forms.RadioButton)
                    {
                        // Activé et visible
                        btn.Visible = true;
                        btn.Enabled = true;
                        // On en check un pour enlever la possibilité de valider sans réponse
                        if (!isOneChecked)
                        {
                            ((System.Windows.Forms.RadioButton)btn).Checked = true;
                            isOneChecked = !isOneChecked;
                        }
                    }
                }
            }
            // Si TextBox -> 2x TextBox
            else if (type == 1)
            {
                // On cache le champ de réponse de base
                repTxtBox.Visible = false;
                repTxtBox.Enabled = false;
                reponseLbl.Visible = false;

                // On montre le champ raison et premier terme
                raisonTxtBox.Visible = true;
                raisonTxtBox.Enabled = true;
                raisonLbl.Visible = true;
                premierTermeTxtBox.Visible = true;
                premierTermeTxtBox.Enabled = true;
                premierTermeLbl.Visible = true;
            }
            // Si RadioButtons -> TextBox
            else
            {
                repTxtBox.Visible = true;
                repTxtBox.Enabled = true;
                reponseLbl.Visible = true;

                // On cache les labels et txtBox de raison et premier terme (qu'importe leur état)
                raisonLbl.Visible = false;
                raisonTxtBox.Visible = false;
                raisonTxtBox.Enabled = false;
                premierTermeLbl.Visible = false;
                premierTermeTxtBox.Visible = false;
                premierTermeTxtBox.Enabled = false;
                // On cache les radio btns
                foreach (Control btn in repBox.Controls)
                {
                    if (btn is System.Windows.Forms.RadioButton)
                    {
                        btn.Visible = false;
                        btn.Enabled = false;
                    }
                }
            }
        }


        /// <summary>
        /// Fin d'une partie, on crée un formulaire de fin auquel on passe notre reference du menu principal
        /// </summary>
        protected virtual void EndGame()
        {
            FinPartie fin = new(J1, J2, TypeSuite, MyMainForm, false);
            fin.Show();
            this.Dispose();
        }

        /// <summary>
        /// Clic sur le bouton de scores dont j'ai oublié de changer le nom
        /// et que je laisserai ainsi pour ne pas froisser le .designer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{J1.Pseudo}: {J1.Score}\n{J2.Pseudo}: {J2.Score}", "Partie en cours...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Bouton règles, on passe une reference de notre form de jeu pour qu'il soit géré.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void reglesBtn_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules(this);
            rules.Show();
        }

        /// <summary>
        /// Fermeture du jeu et réouverture du main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            if (MyMainForm != null && !MyMainForm.Visible) MyMainForm.Show();
        }


        /// <summary>
        /// Get la TextBox depuis les formulaires enfant
        /// </summary>
        /// <param name="type">Si 0, on prend la valeur de la repTxtBox<br/>Si 1, on prend les valeurs des deux txtBox<br/>Si 2, on prend la valeur du radioBtn dans la txtBox</param>
        /// <returns></returns>
        protected string GetRepTxtBox(byte type = 0)
        {
            if (type == 2)
            {
                foreach (Control btn in repBox.Controls)
                {
                    if (btn is System.Windows.Forms.RadioButton radio)
                    {
                        if (radio.Checked == true) repTxtBox.Text = radio.Text;
                    }
                }
            }
            else if (type == 1)
            {
                repTxtBox.Text = $"{raisonTxtBox.Text.Trim()} {premierTermeTxtBox.Text.Trim()}";
            }

            else repTxtBox.Text = repTxtBox.Text.Trim();
            return repTxtBox.Text;
        }

        protected void GetExercices()
        {
            Exercices[0] = new ExoTerme(TypeSuite);
            Exercices[1] = new ExoPremierTerme(TypeSuite);
            Exercices[2] = new ExoRang(TypeSuite);
            Exercices[3] = new ExoRaison(TypeSuite);
            Exercices[4] = new ExoSomme(TypeSuite);
            Exercices[5] = new ExoMonotonie(TypeSuite);
        }
    }
}
