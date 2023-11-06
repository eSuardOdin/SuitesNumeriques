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
    public partial class TabBtn : UserControl
    {
        public TabBtn()
        {
            InitializeComponent();
            //this.Size = tab.Size; // Resize à la taille de l'elmt enfant
            IsSelected = false;
        }

        private void tab_Click(object sender, EventArgs e)
        {
            if (!IsSelected) IsSelected = true;
        }
    }
}
