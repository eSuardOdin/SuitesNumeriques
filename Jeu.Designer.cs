namespace SuitesNumeriques
{
    partial class Jeu
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
            this.joueurLbl = new System.Windows.Forms.Label();
            this.joueurTxtBox = new System.Windows.Forms.TextBox();
            this.pointsLbl = new System.Windows.Forms.Label();
            this.pointsTxtBox = new System.Windows.Forms.TextBox();
            this.validBtn = new System.Windows.Forms.Button();
            this.skipBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reglesBtn = new System.Windows.Forms.Button();
            this.tab0 = new System.Windows.Forms.TabControl();
            this.exoContainer = new System.Windows.Forms.TabPage();
            this.repBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enonceLbl = new System.Windows.Forms.Label();
            this.repTxtBox = new System.Windows.Forms.TextBox();
            this.tab0.SuspendLayout();
            this.exoContainer.SuspendLayout();
            this.repBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // joueurLbl
            // 
            this.joueurLbl.AutoSize = true;
            this.joueurLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joueurLbl.Location = new System.Drawing.Point(36, 25);
            this.joueurLbl.Name = "joueurLbl";
            this.joueurLbl.Size = new System.Drawing.Size(73, 15);
            this.joueurLbl.TabIndex = 0;
            this.joueurLbl.Text = "Joueur N°* :";
            // 
            // joueurTxtBox
            // 
            this.joueurTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.joueurTxtBox.Enabled = false;
            this.joueurTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joueurTxtBox.Location = new System.Drawing.Point(133, 22);
            this.joueurTxtBox.Name = "joueurTxtBox";
            this.joueurTxtBox.Size = new System.Drawing.Size(188, 23);
            this.joueurTxtBox.TabIndex = 1;
            this.joueurTxtBox.Text = "Joueur";
            this.joueurTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointsLbl.Location = new System.Drawing.Point(560, 25);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(47, 15);
            this.pointsLbl.TabIndex = 2;
            this.pointsLbl.Text = "Points :";
            // 
            // pointsTxtBox
            // 
            this.pointsTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.pointsTxtBox.Enabled = false;
            this.pointsTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointsTxtBox.Location = new System.Drawing.Point(633, 22);
            this.pointsTxtBox.Name = "pointsTxtBox";
            this.pointsTxtBox.Size = new System.Drawing.Size(115, 23);
            this.pointsTxtBox.TabIndex = 3;
            this.pointsTxtBox.Text = "0";
            this.pointsTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // validBtn
            // 
            this.validBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validBtn.Location = new System.Drawing.Point(34, 415);
            this.validBtn.Name = "validBtn";
            this.validBtn.Size = new System.Drawing.Size(75, 23);
            this.validBtn.TabIndex = 4;
            this.validBtn.Text = "Valider";
            this.validBtn.UseVisualStyleBackColor = true;
            this.validBtn.Click += new System.EventHandler(this.validBtn_Click);
            // 
            // skipBtn
            // 
            this.skipBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skipBtn.Location = new System.Drawing.Point(133, 413);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(135, 23);
            this.skipBtn.TabIndex = 5;
            this.skipBtn.Text = "Passer la question";
            this.skipBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(619, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Scores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // reglesBtn
            // 
            this.reglesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reglesBtn.Location = new System.Drawing.Point(713, 413);
            this.reglesBtn.Name = "reglesBtn";
            this.reglesBtn.Size = new System.Drawing.Size(75, 23);
            this.reglesBtn.TabIndex = 7;
            this.reglesBtn.Text = "Règles";
            this.reglesBtn.UseVisualStyleBackColor = true;
            // 
            // tab0
            // 
            this.tab0.Controls.Add(this.exoContainer);
            this.tab0.Location = new System.Drawing.Point(42, 51);
            this.tab0.Name = "tab0";
            this.tab0.SelectedIndex = 0;
            this.tab0.Size = new System.Drawing.Size(723, 356);
            this.tab0.TabIndex = 8;
            // 
            // exoContainer
            // 
            this.exoContainer.Controls.Add(this.repBox);
            this.exoContainer.Controls.Add(this.enonceLbl);
            this.exoContainer.Location = new System.Drawing.Point(4, 24);
            this.exoContainer.Name = "exoContainer";
            this.exoContainer.Padding = new System.Windows.Forms.Padding(3);
            this.exoContainer.Size = new System.Drawing.Size(715, 328);
            this.exoContainer.TabIndex = 0;
            this.exoContainer.Text = "tabPage1";
            this.exoContainer.UseVisualStyleBackColor = true;
            // 
            // repBox
            // 
            this.repBox.Controls.Add(this.repTxtBox);
            this.repBox.Controls.Add(this.label1);
            this.repBox.Location = new System.Drawing.Point(146, 245);
            this.repBox.Name = "repBox";
            this.repBox.Size = new System.Drawing.Size(350, 76);
            this.repBox.TabIndex = 1;
            this.repBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réponse :";
            // 
            // enonceLbl
            // 
            this.enonceLbl.AutoSize = true;
            this.enonceLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enonceLbl.Location = new System.Drawing.Point(29, 26);
            this.enonceLbl.Name = "enonceLbl";
            this.enonceLbl.Size = new System.Drawing.Size(64, 15);
            this.enonceLbl.TabIndex = 0;
            this.enonceLbl.Text = "enonceLbl";
            // 
            // repTxtBox
            // 
            this.repTxtBox.Location = new System.Drawing.Point(86, 29);
            this.repTxtBox.Name = "repTxtBox";
            this.repTxtBox.Size = new System.Drawing.Size(206, 23);
            this.repTxtBox.TabIndex = 1;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab0);
            this.Controls.Add(this.reglesBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skipBtn);
            this.Controls.Add(this.validBtn);
            this.Controls.Add(this.pointsTxtBox);
            this.Controls.Add(this.pointsLbl);
            this.Controls.Add(this.joueurTxtBox);
            this.Controls.Add(this.joueurLbl);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.tab0.ResumeLayout(false);
            this.exoContainer.ResumeLayout(false);
            this.exoContainer.PerformLayout();
            this.repBox.ResumeLayout(false);
            this.repBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label joueurLbl;
        private TextBox joueurTxtBox;
        private Label pointsLbl;
        private TextBox pointsTxtBox;
        private Button validBtn;
        private Button skipBtn;
        private Button button1;
        private Button reglesBtn;
        private TabControl tab0;
        private TabPage exoContainer;
        private Label enonceLbl;
        private GroupBox repBox;
        private Label label1;
        private TextBox repTxtBox;
    }
}