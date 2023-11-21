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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            rulesBox.Text =
                @"
- Le jeu se joue à 2 joueurs à tour de rôle avec 6 questions par parties
- À chaque tour, un calcul de même nature sur les suites est demandé ";
        }


    }
}
