using Microsoft.VisualBasic;

namespace SuitesNumeriques
{
    partial class Entrainement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public string TypePartie { get; private set; }
        public Partie Partie { get; private set; }

        public Entrainement(string label, string typePartie)
        {
            TypePartie = typePartie;
            Partie = new Partie(TypePartie);
            this.Text = $"Suites {label}: Rechercher...";
            // Debug
            string txt = "";
            foreach (var ex in Partie.Exercices)
            {
                txt += $"- {ex.ToString()} : Raison -> {ex.SuiteExo.Raison}, Premier terme -> {ex.SuiteExo.PremierTerme}\n";
            }
            MessageBox.Show(txt);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabBtn1 = new TabBtn();
            tabBtn2 = new TabBtn();
            tabBtn3 = new TabBtn();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabBtn1
            // 
            tabBtn1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tabBtn1.IsSelected = false;
            tabBtn1.Location = new Point(18, 7);
            tabBtn1.Name = "tabBtn1";
            tabBtn1.Size = new Size(73, 22);
            tabBtn1.TabIndex = 1;
            // 
            // tabBtn2
            // 
            tabBtn2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tabBtn2.IsSelected = false;
            tabBtn2.Location = new Point(132, 11);
            tabBtn2.Name = "tabBtn2";
            tabBtn2.Size = new Size(73, 22);
            tabBtn2.TabIndex = 2;
            // 
            // tabBtn3
            // 
            tabBtn3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tabBtn3.IsSelected = false;
            tabBtn3.Location = new Point(270, 16);
            tabBtn3.Name = "tabBtn3";
            tabBtn3.Size = new Size(73, 22);
            tabBtn3.TabIndex = 3;
            // 
            // Entrainement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabBtn3);
            Controls.Add(tabBtn2);
            Controls.Add(tabBtn1);
            Name = "Entrainement";
            Text = "Entrainement";
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabBtn tabBtn1;
        private TabBtn tabBtn2;
        private TabBtn tabBtn3;
    }
}