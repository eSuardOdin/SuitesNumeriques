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
        private TimeManager MyTimeManager {  get; set; }
        public JeuTimer(Player j1, Player j2, string typePartie, MainForm mainForm, TimeManager tm): base(j1,j2,typePartie, mainForm)
        {
            InitializeComponent();
            MyTimeManager = tm;
        }
    }
}
