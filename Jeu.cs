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
        public Player J1 { get; private set; }
        public Player J2 { get; private set; }
        public Jeu(Player j1, Player j2)
        {
            InitializeComponent();
            J1 = j1;
            J2 = j2;
            joueurTxtBox.Text = j1.Pseudo;
        }
    }
}
