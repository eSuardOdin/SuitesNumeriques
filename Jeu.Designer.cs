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
            joueurLbl = new Label();
            joueurTxtBox = new TextBox();
            pointsLbl = new Label();
            pointsTxtBox = new TextBox();
            validBtn = new Button();
            skipBtn = new Button();
            button1 = new Button();
            reglesBtn = new Button();
            SuspendLayout();
            // 
            // joueurLbl
            // 
            joueurLbl.AutoSize = true;
            joueurLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            joueurLbl.Location = new Point(36, 25);
            joueurLbl.Name = "joueurLbl";
            joueurLbl.Size = new Size(73, 15);
            joueurLbl.TabIndex = 0;
            joueurLbl.Text = "Joueur N°* :";
            // 
            // joueurTxtBox
            // 
            joueurTxtBox.BackColor = SystemColors.Info;
            joueurTxtBox.Enabled = false;
            joueurTxtBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            joueurTxtBox.Location = new Point(133, 22);
            joueurTxtBox.Name = "joueurTxtBox";
            joueurTxtBox.Size = new Size(188, 23);
            joueurTxtBox.TabIndex = 1;
            joueurTxtBox.Text = "Joueur";
            joueurTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // pointsLbl
            // 
            pointsLbl.AutoSize = true;
            pointsLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pointsLbl.Location = new Point(560, 25);
            pointsLbl.Name = "pointsLbl";
            pointsLbl.Size = new Size(47, 15);
            pointsLbl.TabIndex = 2;
            pointsLbl.Text = "Points :";
            // 
            // pointsTxtBox
            // 
            pointsTxtBox.BackColor = SystemColors.Info;
            pointsTxtBox.Enabled = false;
            pointsTxtBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pointsTxtBox.Location = new Point(633, 22);
            pointsTxtBox.Name = "pointsTxtBox";
            pointsTxtBox.Size = new Size(115, 23);
            pointsTxtBox.TabIndex = 3;
            pointsTxtBox.Text = "0";
            pointsTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // validBtn
            // 
            validBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            validBtn.Location = new Point(34, 415);
            validBtn.Name = "validBtn";
            validBtn.Size = new Size(75, 23);
            validBtn.TabIndex = 4;
            validBtn.Text = "Valider";
            validBtn.UseVisualStyleBackColor = true;
            // 
            // skipBtn
            // 
            skipBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            skipBtn.Location = new Point(133, 413);
            skipBtn.Name = "skipBtn";
            skipBtn.Size = new Size(135, 23);
            skipBtn.TabIndex = 5;
            skipBtn.Text = "Passer la question";
            skipBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(619, 413);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Scores";
            button1.UseVisualStyleBackColor = true;
            // 
            // reglesBtn
            // 
            reglesBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reglesBtn.Location = new Point(713, 413);
            reglesBtn.Name = "reglesBtn";
            reglesBtn.Size = new Size(75, 23);
            reglesBtn.TabIndex = 7;
            reglesBtn.Text = "Règles";
            reglesBtn.UseVisualStyleBackColor = true;
            // 
            // Jeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reglesBtn);
            Controls.Add(button1);
            Controls.Add(skipBtn);
            Controls.Add(validBtn);
            Controls.Add(pointsTxtBox);
            Controls.Add(pointsLbl);
            Controls.Add(joueurTxtBox);
            Controls.Add(joueurLbl);
            Name = "Jeu";
            Text = "Jeu";
            ResumeLayout(false);
            PerformLayout();
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
    }
}