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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tab5 = new TabPage();
            exo5 = new classes.ExoEntrainementMonotonie();
            tab4 = new TabPage();
            exo4 = new ExoEntrainement();
            tab3 = new TabPage();
            exo3 = new ExoEntrainement();
            tab2 = new TabPage();
            exo2 = new ExoEntrainement();
            tab1 = new TabPage();
            exo1 = new ExoEntrainement();
            tab0 = new TabPage();
            exo0 = new ExoEntrainement();
            tabControl1 = new TabControl();
            tab5.SuspendLayout();
            tab4.SuspendLayout();
            tab3.SuspendLayout();
            tab2.SuspendLayout();
            tab1.SuspendLayout();
            tab0.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tab5
            // 
            tab5.Controls.Add(exo5);
            tab5.Location = new Point(4, 24);
            tab5.Name = "tab5";
            tab5.Padding = new Padding(3);
            tab5.Size = new Size(788, 418);
            tab5.TabIndex = 5;
            tab5.Tag = "5";
            tab5.Text = "La Monotonie";
            tab5.UseVisualStyleBackColor = true;
            // 
            // exo5
            // 
            exo5.Location = new Point(12, 5);
            exo5.Name = "exo5";
            exo5.Size = new Size(708, 441);
            exo5.TabIndex = 0;
            // 
            // tab4
            // 
            tab4.Controls.Add(exo4);
            tab4.Location = new Point(4, 24);
            tab4.Name = "tab4";
            tab4.Padding = new Padding(3);
            tab4.Size = new Size(788, 418);
            tab4.TabIndex = 4;
            tab4.Tag = "4";
            tab4.Text = "La Somme";
            tab4.UseVisualStyleBackColor = true;
            // 
            // exo4
            // 
            exo4.Location = new Point(30, 30);
            exo4.Name = "exo4";
            exo4.Size = new Size(714, 325);
            exo4.TabIndex = 0;
            // 
            // tab3
            // 
            tab3.Controls.Add(exo3);
            tab3.Location = new Point(4, 24);
            tab3.Name = "tab3";
            tab3.Padding = new Padding(3);
            tab3.Size = new Size(788, 418);
            tab3.TabIndex = 3;
            tab3.Tag = "3";
            tab3.Text = "La Raison et le Premier terme";
            tab3.UseVisualStyleBackColor = true;
            // 
            // exo3
            // 
            exo3.Location = new Point(30, 30);
            exo3.Name = "exo3";
            exo3.Size = new Size(714, 325);
            exo3.TabIndex = 0;
            // 
            // tab2
            // 
            tab2.Controls.Add(exo2);
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(788, 418);
            tab2.TabIndex = 2;
            tab2.Tag = "2";
            tab2.Text = "Le Rang";
            tab2.UseVisualStyleBackColor = true;
            // 
            // exo2
            // 
            exo2.Location = new Point(30, 30);
            exo2.Name = "exo2";
            exo2.Size = new Size(714, 325);
            exo2.TabIndex = 0;
            // 
            // tab1
            // 
            tab1.Controls.Add(exo1);
            tab1.Location = new Point(4, 24);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(788, 418);
            tab1.TabIndex = 1;
            tab1.Tag = "1";
            tab1.Text = "Le Premier terme";
            tab1.UseVisualStyleBackColor = true;
            // 
            // exo1
            // 
            exo1.Location = new Point(30, 30);
            exo1.Name = "exo1";
            exo1.Size = new Size(714, 325);
            exo1.TabIndex = 0;
            // 
            // tab0
            // 
            tab0.Controls.Add(exo0);
            tab0.Location = new Point(4, 24);
            tab0.Name = "tab0";
            tab0.Padding = new Padding(3);
            tab0.Size = new Size(788, 418);
            tab0.TabIndex = 0;
            tab0.Tag = "0";
            tab0.Text = "Un Terme";
            tab0.UseVisualStyleBackColor = true;
            // 
            // exo0
            // 
            exo0.Location = new Point(30, 30);
            exo0.Name = "exo0";
            exo0.Size = new Size(714, 325);
            exo0.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab0);
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tab2);
            tabControl1.Controls.Add(tab3);
            tabControl1.Controls.Add(tab4);
            tabControl1.Controls.Add(tab5);
            tabControl1.Location = new Point(2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 446);
            tabControl1.TabIndex = 0;
            // 
            // Entrainement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Entrainement";
            Text = "Entrainement";
            FormClosed += Entrainement_FormClosed;
            tab5.ResumeLayout(false);
            tab4.ResumeLayout(false);
            tab3.ResumeLayout(false);
            tab2.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tab0.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
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