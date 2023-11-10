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
            this.testRepBox = new System.Windows.Forms.TextBox();
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
            // testRepBox
            // 
            this.testRepBox.Location = new System.Drawing.Point(186, 221);
            this.testRepBox.Name = "testRepBox";
            this.testRepBox.Size = new System.Drawing.Size(100, 23);
            this.testRepBox.TabIndex = 8;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testRepBox);
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
        private TextBox testRepBox;
    }
}