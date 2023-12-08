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
            menuStrip1 = new MenuStrip();
            entrainementSurLesSuitesToolStripMenuItem = new ToolStripMenuItem();
            arithmétiquesToolStripMenuItem = new ToolStripMenuItem();
            géométriquesToolStripMenuItem = new ToolStripMenuItem();
            quelconquesEnProjetToolStripMenuItem = new ToolStripMenuItem();
            jouerToolStripMenuItem = new ToolStripMenuItem();
            sansContrainteToolStripMenuItem = new ToolStripMenuItem();
            avecContrainteToolStripMenuItem = new ToolStripMenuItem();
            meilleursTempsToolStripMenuItem = new ToolStripMenuItem();
            arithmétiqueToolStripMenuItem = new ToolStripMenuItem();
            géométriqueToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            enonceLbl = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            quelconquesEnProjetToolStripMenuItem.Click += quelconquesEnProjetToolStripMenuItem_Click;
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
            sansContrainteToolStripMenuItem.Size = new Size(157, 22);
            sansContrainteToolStripMenuItem.Text = "Sans contrainte";
            sansContrainteToolStripMenuItem.Click += sansContrainteToolStripMenuItem_Click;
            // 
            // avecContrainteToolStripMenuItem
            // 
            avecContrainteToolStripMenuItem.Name = "avecContrainteToolStripMenuItem";
            avecContrainteToolStripMenuItem.Size = new Size(157, 22);
            avecContrainteToolStripMenuItem.Text = "Avec contrainte";
            avecContrainteToolStripMenuItem.Click += avecContrainteToolStripMenuItem_Click;
            // 
            // meilleursTempsToolStripMenuItem
            // 
            meilleursTempsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arithmétiqueToolStripMenuItem, géométriqueToolStripMenuItem });
            meilleursTempsToolStripMenuItem.Name = "meilleursTempsToolStripMenuItem";
            meilleursTempsToolStripMenuItem.Size = new Size(103, 20);
            meilleursTempsToolStripMenuItem.Text = "Meilleurs temps";
            // 
            // arithmétiqueToolStripMenuItem
            // 
            arithmétiqueToolStripMenuItem.Name = "arithmétiqueToolStripMenuItem";
            arithmétiqueToolStripMenuItem.Size = new Size(144, 22);
            arithmétiqueToolStripMenuItem.Tag = "";
            arithmétiqueToolStripMenuItem.Text = "Arithmétique";
            arithmétiqueToolStripMenuItem.Click += arithmétiqueToolStripMenuItem_Click;
            // 
            // géométriqueToolStripMenuItem
            // 
            géométriqueToolStripMenuItem.Name = "géométriqueToolStripMenuItem";
            géométriqueToolStripMenuItem.Size = new Size(144, 22);
            géométriqueToolStripMenuItem.Tag = "";
            géométriqueToolStripMenuItem.Text = "Géométrique";
            géométriqueToolStripMenuItem.Click += géométriqueToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(22, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 671);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 8097);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // enonceLbl
            // 
            enonceLbl.AutoSize = true;
            enonceLbl.BackColor = SystemColors.Info;
            enonceLbl.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            enonceLbl.Location = new Point(293, 39);
            enonceLbl.Name = "enonceLbl";
            enonceLbl.Size = new Size(434, 47);
            enonceLbl.TabIndex = 5;
            enonceLbl.Text = "Fondamentaux sur les Suites Numériques";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 724);
            Controls.Add(enonceLbl);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Études des suites numériques en mathématiques";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ToolStripMenuItem arithmétiqueToolStripMenuItem;
        private ToolStripMenuItem géométriqueToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label enonceLbl;
    }
}