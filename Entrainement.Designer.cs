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
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Entrainement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Entrainement";
            Text = "Entrainement";
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;

    }
}