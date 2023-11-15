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
            if (timeLbl.InvokeRequired)
            {
                timeLbl.Invoke((MethodInvoker)delegate { timeLbl.Text = secondsLeft.ToString(); });
            }
            else
            {
                timeLbl.Text = secondsLeft.ToString();
            }
        }
    }
}
