using Microsoft.VisualBasic;

namespace SuitesNumeriques
{
    partial class Entrainement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tab5 = new System.Windows.Forms.TabPage();
            this.exo5 = new SuitesNumeriques.classes.ExoEntrainementMonotonie();
            this.tab4 = new System.Windows.Forms.TabPage();
            this.exo4 = new SuitesNumeriques.ExoEntrainement();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.exo3 = new SuitesNumeriques.ExoEntrainement();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.exo2 = new SuitesNumeriques.ExoEntrainement();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.exo1 = new SuitesNumeriques.ExoEntrainement();
            this.tab0 = new System.Windows.Forms.TabPage();
            this.exo0 = new SuitesNumeriques.ExoEntrainement();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab5.SuspendLayout();
            this.tab4.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab0.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tab5
            // 
            this.tab5.Controls.Add(this.exo5);
            this.tab5.Location = new System.Drawing.Point(4, 24);
            this.tab5.Name = "tab5";
            this.tab5.Padding = new System.Windows.Forms.Padding(3);
            this.tab5.Size = new System.Drawing.Size(788, 418);
            this.tab5.TabIndex = 5;
            this.tab5.Tag = "5";
            this.tab5.Text = "La Monotonie";
            this.tab5.UseVisualStyleBackColor = true;
            // 
            // exo5
            // 
            this.exo5.Location = new System.Drawing.Point(12, 5);
            this.exo5.Name = "exo5";
            this.exo5.Size = new System.Drawing.Size(708, 441);
            this.exo5.TabIndex = 0;
            // 
            // tab4
            // 
            this.tab4.Controls.Add(this.exo4);
            this.tab4.Location = new System.Drawing.Point(4, 24);
            this.tab4.Name = "tab4";
            this.tab4.Padding = new System.Windows.Forms.Padding(3);
            this.tab4.Size = new System.Drawing.Size(788, 418);
            this.tab4.TabIndex = 4;
            this.tab4.Tag = "4";
            this.tab4.Text = "La Somme";
            this.tab4.UseVisualStyleBackColor = true;
            // 
            // exo4
            // 
            this.exo4.Location = new System.Drawing.Point(30, 30);
            this.exo4.Name = "exo4";
            this.exo4.Size = new System.Drawing.Size(714, 325);
            this.exo4.TabIndex = 0;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.exo3);
            this.tab3.Location = new System.Drawing.Point(4, 24);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(788, 418);
            this.tab3.TabIndex = 3;
            this.tab3.Tag = "3";
            this.tab3.Text = "La Raison et le Premier terme";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // exo3
            // 
            this.exo3.Location = new System.Drawing.Point(30, 30);
            this.exo3.Name = "exo3";
            this.exo3.Size = new System.Drawing.Size(714, 325);
            this.exo3.TabIndex = 0;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.exo2);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(788, 418);
            this.tab2.TabIndex = 2;
            this.tab2.Tag = "2";
            this.tab2.Text = "Le Rang";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // exo2
            // 
            this.exo2.Location = new System.Drawing.Point(30, 30);
            this.exo2.Name = "exo2";
            this.exo2.Size = new System.Drawing.Size(714, 325);
            this.exo2.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.exo1);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(788, 418);
            this.tab1.TabIndex = 1;
            this.tab1.Tag = "1";
            this.tab1.Text = "Le Premier terme";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // exo1
            // 
            this.exo1.Location = new System.Drawing.Point(30, 30);
            this.exo1.Name = "exo1";
            this.exo1.Size = new System.Drawing.Size(714, 325);
            this.exo1.TabIndex = 0;
            // 
            // tab0
            // 
            this.tab0.Controls.Add(this.exo0);
            this.tab0.Location = new System.Drawing.Point(4, 24);
            this.tab0.Name = "tab0";
            this.tab0.Padding = new System.Windows.Forms.Padding(3);
            this.tab0.Size = new System.Drawing.Size(788, 418);
            this.tab0.TabIndex = 0;
            this.tab0.Tag = "0";
            this.tab0.Text = "Un Terme";
            this.tab0.UseVisualStyleBackColor = true;
            // 
            // exo0
            // 
            this.exo0.Location = new System.Drawing.Point(30, 30);
            this.exo0.Name = "exo0";
            this.exo0.Size = new System.Drawing.Size(714, 325);
            this.exo0.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab0);
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Controls.Add(this.tab4);
            this.tabControl1.Controls.Add(this.tab5);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // Entrainement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Entrainement";
            this.Text = "Entrainement";
            this.tab5.ResumeLayout(false);
            this.tab4.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab0.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabPage tab5;
        private TabPage tab4;
        private ExoEntrainement exo4;
        private TabPage tab3;
        private ExoEntrainement exo3;
        private TabPage tab2;
        private ExoEntrainement exo2;
        private TabPage tab1;
        private ExoEntrainement exo1;
        private TabPage tab0;
        private ExoEntrainement exo0;
        private TabControl tabControl1;
        private classes.ExoEntrainementMonotonie exo5;
    }
}