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
    public partial class JeuTimer : Jeu
    {
        private TimeManager MyTimeManager { get; set; }
        public JeuTimer(Player j1, Player j2, string typePartie, MainForm mainForm, TimeManager tm) : base(j1, j2, typePartie, mainForm)
        {
            InitializeComponent();
            MyTimeManager = tm;
            MyTimeManager.SecondsLeftChanged += UpdateTimeLabel;
        }

        private void UpdateTimeLabel(int secondsLeft)
        {
            if (timeLbl.InvokeRequired && this != null)
            {
                timeLbl.Invoke((MethodInvoker)delegate { timeLbl.Text = $"{(secondsLeft / 60).ToString()}min {(secondsLeft % 60).ToString()}sec"; });
                if (secondsLeft / 60 == 0) timeLbl.ForeColor = Color.Red;
                else timeLbl.ForeColor = Color.Green;
            }
            /*else
            {
                timeLbl.Text = secondsLeft.ToString();
                //timeLbl.Text = $"{(secondsLeft/60).ToString()}min {(secondsLeft%60).ToString()}sec";
            }*/
        }



        // EVENTS

        protected override void validBtn_Click(object sender, EventArgs e)
        {
            Player currentPlayer = IsFirstPlayer ? J1 : J2;
            if(currentPlayer.Repondre(Versus.Exercices[IndexExercice], base.getRepTxtBox()))
            {
                currentPlayer.AddTime(MyTimeManager.SecondsLeft);
            }

            MessageBox.Show(currentPlayer.Time.ToString());
            MyTimeManager.ResetTimer();
            base.validBtn_Click(sender, e);
        }
    }
}
