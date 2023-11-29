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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entrainementSurLesSuitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arithmétiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.géométriquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quelconquesEnProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jouerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sansContrainteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avecContrainteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meilleursTempsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arithmétiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.géométriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrainementSurLesSuitesToolStripMenuItem,
            this.jouerToolStripMenuItem,
            this.meilleursTempsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entrainementSurLesSuitesToolStripMenuItem
            // 
            this.entrainementSurLesSuitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arithmétiquesToolStripMenuItem,
            this.géométriquesToolStripMenuItem,
            this.quelconquesEnProjetToolStripMenuItem});
            this.entrainementSurLesSuitesToolStripMenuItem.Name = "entrainementSurLesSuitesToolStripMenuItem";
            this.entrainementSurLesSuitesToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.entrainementSurLesSuitesToolStripMenuItem.Text = "Entrainement sur les Suites";
            // 
            // arithmétiquesToolStripMenuItem
            // 
            this.arithmétiquesToolStripMenuItem.Name = "arithmétiquesToolStripMenuItem";
            this.arithmétiquesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.arithmétiquesToolStripMenuItem.Tag = "arithmétique";
            this.arithmétiquesToolStripMenuItem.Text = "Arithmétiques";
            this.arithmétiquesToolStripMenuItem.Click += new System.EventHandler(this.arithmétiquesToolStripMenuItem_Click);
            // 
            // géométriquesToolStripMenuItem
            // 
            this.géométriquesToolStripMenuItem.Name = "géométriquesToolStripMenuItem";
            this.géométriquesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.géométriquesToolStripMenuItem.Tag = "géométrique";
            this.géométriquesToolStripMenuItem.Text = "Géométriques";
            this.géométriquesToolStripMenuItem.Click += new System.EventHandler(this.géométriquesToolStripMenuItem_Click);
            // 
            // quelconquesEnProjetToolStripMenuItem
            // 
            this.quelconquesEnProjetToolStripMenuItem.Name = "quelconquesEnProjetToolStripMenuItem";
            this.quelconquesEnProjetToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.quelconquesEnProjetToolStripMenuItem.Text = "Quelconques (En projet)";
            this.quelconquesEnProjetToolStripMenuItem.Click += new System.EventHandler(this.quelconquesEnProjetToolStripMenuItem_Click);
            // 
            // jouerToolStripMenuItem
            // 
            this.jouerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sansContrainteToolStripMenuItem,
            this.avecContrainteToolStripMenuItem});
            this.jouerToolStripMenuItem.Name = "jouerToolStripMenuItem";
            this.jouerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.jouerToolStripMenuItem.Text = "Jouer";
            // 
            // sansContrainteToolStripMenuItem
            // 
            this.sansContrainteToolStripMenuItem.Name = "sansContrainteToolStripMenuItem";
            this.sansContrainteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sansContrainteToolStripMenuItem.Text = "Sans contrainte";
            this.sansContrainteToolStripMenuItem.Click += new System.EventHandler(this.sansContrainteToolStripMenuItem_Click);
            // 
            // avecContrainteToolStripMenuItem
            // 
            this.avecContrainteToolStripMenuItem.Name = "avecContrainteToolStripMenuItem";
            this.avecContrainteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avecContrainteToolStripMenuItem.Text = "Avec contrainte";
            this.avecContrainteToolStripMenuItem.Click += new System.EventHandler(this.avecContrainteToolStripMenuItem_Click);
            // 
            // meilleursTempsToolStripMenuItem
            // 
            this.meilleursTempsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arithmétiqueToolStripMenuItem,
            this.géométriqueToolStripMenuItem});
            this.meilleursTempsToolStripMenuItem.Name = "meilleursTempsToolStripMenuItem";
            this.meilleursTempsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.meilleursTempsToolStripMenuItem.Text = "Meilleurs temps";
            // 
            // arithmétiqueToolStripMenuItem
            // 
            this.arithmétiqueToolStripMenuItem.Name = "arithmétiqueToolStripMenuItem";
            this.arithmétiqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arithmétiqueToolStripMenuItem.Tag = "";
            this.arithmétiqueToolStripMenuItem.Text = "Arithmétique";
            this.arithmétiqueToolStripMenuItem.Click += new System.EventHandler(this.arithmétiqueToolStripMenuItem_Click);
            // 
            // géométriqueToolStripMenuItem
            // 
            this.géométriqueToolStripMenuItem.Name = "géométriqueToolStripMenuItem";
            this.géométriqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.géométriqueToolStripMenuItem.Tag = "";
            this.géométriqueToolStripMenuItem.Text = "Géométrique";
            this.géométriqueToolStripMenuItem.Click += new System.EventHandler(this.géométriqueToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(23, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 671);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 8097);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Études des suites numériques en mathématiques";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripMenuItem arithmétiqueToolStripMenuItem;
        private ToolStripMenuItem géométriqueToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}