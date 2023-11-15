namespace SuitesNumeriques
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            entrainementSurLesSuitesToolStripMenuItem = new ToolStripMenuItem();
            arithmétiquesToolStripMenuItem = new ToolStripMenuItem();
            géométriquesToolStripMenuItem = new ToolStripMenuItem();
            quelconquesEnProjetToolStripMenuItem = new ToolStripMenuItem();
            jouerToolStripMenuItem = new ToolStripMenuItem();
            sansContrainteToolStripMenuItem = new ToolStripMenuItem();
            avecContrainteToolStripMenuItem = new ToolStripMenuItem();
            meilleursTempsToolStripMenuItem = new ToolStripMenuItem();
            picLeft = new PictureBox();
            picRight = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRight).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { entrainementSurLesSuitesToolStripMenuItem, jouerToolStripMenuItem, meilleursTempsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // entrainementSurLesSuitesToolStripMenuItem
            // 
            entrainementSurLesSuitesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arithmétiquesToolStripMenuItem, géométriquesToolStripMenuItem, quelconquesEnProjetToolStripMenuItem });
            entrainementSurLesSuitesToolStripMenuItem.Name = "entrainementSurLesSuitesToolStripMenuItem";
            entrainementSurLesSuitesToolStripMenuItem.Size = new Size(160, 20);
            entrainementSurLesSuitesToolStripMenuItem.Text = "Entrainement sur les Suites";
            // 
            // arithmétiquesToolStripMenuItem
            // 
            arithmétiquesToolStripMenuItem.Name = "arithmétiquesToolStripMenuItem";
            arithmétiquesToolStripMenuItem.Size = new Size(202, 22);
            arithmétiquesToolStripMenuItem.Tag = "arithmétique";
            arithmétiquesToolStripMenuItem.Text = "Arithmétiques";
            arithmétiquesToolStripMenuItem.Click += arithmétiquesToolStripMenuItem_Click;
            // 
            // géométriquesToolStripMenuItem
            // 
            géométriquesToolStripMenuItem.Name = "géométriquesToolStripMenuItem";
            géométriquesToolStripMenuItem.Size = new Size(202, 22);
            géométriquesToolStripMenuItem.Tag = "géométrique";
            géométriquesToolStripMenuItem.Text = "Géométriques";
            géométriquesToolStripMenuItem.Click += géométriquesToolStripMenuItem_Click;
            // 
            // quelconquesEnProjetToolStripMenuItem
            // 
            quelconquesEnProjetToolStripMenuItem.Name = "quelconquesEnProjetToolStripMenuItem";
            quelconquesEnProjetToolStripMenuItem.Size = new Size(202, 22);
            quelconquesEnProjetToolStripMenuItem.Text = "Quelconques (En projet)";
            // 
            // jouerToolStripMenuItem
            // 
            jouerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sansContrainteToolStripMenuItem, avecContrainteToolStripMenuItem });
            jouerToolStripMenuItem.Name = "jouerToolStripMenuItem";
            jouerToolStripMenuItem.Size = new Size(47, 20);
            jouerToolStripMenuItem.Text = "Jouer";
            // 
            // sansContrainteToolStripMenuItem
            // 
            sansContrainteToolStripMenuItem.Name = "sansContrainteToolStripMenuItem";
            sansContrainteToolStripMenuItem.Size = new Size(180, 22);
            sansContrainteToolStripMenuItem.Text = "Sans contrainte";
            sansContrainteToolStripMenuItem.Click += sansContrainteToolStripMenuItem_Click;
            // 
            // avecContrainteToolStripMenuItem
            // 
            avecContrainteToolStripMenuItem.Name = "avecContrainteToolStripMenuItem";
            avecContrainteToolStripMenuItem.Size = new Size(180, 22);
            avecContrainteToolStripMenuItem.Text = "Avec contrainte";
            avecContrainteToolStripMenuItem.Click += avecContrainteToolStripMenuItem_Click;
            // 
            // meilleursTempsToolStripMenuItem
            // 
            meilleursTempsToolStripMenuItem.Name = "meilleursTempsToolStripMenuItem";
            meilleursTempsToolStripMenuItem.Size = new Size(103, 20);
            meilleursTempsToolStripMenuItem.Text = "Meilleurs temps";
            // 
            // picLeft
            // 
            picLeft.ImageLocation = "C:\\Users\\Erwann\\source\\repos\\SuitesNumeriques\\Stuff\\ari.png";
            picLeft.Location = new Point(12, 37);
            picLeft.Name = "picLeft";
            picLeft.Size = new Size(500, 671);
            picLeft.TabIndex = 1;
            picLeft.TabStop = false;
            // 
            // picRight
            // 
            picRight.ImageLocation = "C:\\Users\\Erwann\\source\\repos\\SuitesNumeriques\\Stuff\\geo.png";
            picRight.Location = new Point(565, 37);
            picRight.Name = "picRight";
            picRight.Size = new Size(510, 671);
            picRight.TabIndex = 2;
            picRight.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 724);
            Controls.Add(picRight);
            Controls.Add(picLeft);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Études des suites numériques en mathématiques";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem entrainementSurLesSuitesToolStripMenuItem;
        private ToolStripMenuItem arithmétiquesToolStripMenuItem;
        private ToolStripMenuItem géométriquesToolStripMenuItem;
        private ToolStripMenuItem quelconquesEnProjetToolStripMenuItem;
        private ToolStripMenuItem jouerToolStripMenuItem;
        private ToolStripMenuItem sansContrainteToolStripMenuItem;
        private ToolStripMenuItem avecContrainteToolStripMenuItem;
        private ToolStripMenuItem meilleursTempsToolStripMenuItem;
        private PictureBox picLeft;
        private PictureBox picRight;
    }
}