namespace SuitesNumeriques
{
    partial class FinPartie
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
            winnerTxt = new Label();
            label1 = new Label();
            j1PseudoLbl = new Label();
            j2PseudoLbl = new Label();
            j1ScoreLbl = new Label();
            j2ScoreLbl = new Label();
            menuBtn = new Button();
            newGameBtn = new Button();
            SuspendLayout();
            // 
            // winnerTxt
            // 
            winnerTxt.BackColor = SystemColors.HighlightText;
            winnerTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            winnerTxt.Location = new Point(148, 21);
            winnerTxt.Name = "winnerTxt";
            winnerTxt.Padding = new Padding(10, 3, 10, 3);
            winnerTxt.Size = new Size(325, 40);
            winnerTxt.TabIndex = 10;
            winnerTxt.Text = "label2";
            winnerTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(275, 90);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "SCORES";
            // 
            // j1PseudoLbl
            // 
            j1PseudoLbl.AutoSize = true;
            j1PseudoLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            j1PseudoLbl.Location = new Point(171, 130);
            j1PseudoLbl.Name = "j1PseudoLbl";
            j1PseudoLbl.Size = new Size(40, 15);
            j1PseudoLbl.TabIndex = 12;
            j1PseudoLbl.Text = "label2";
            // 
            // j2PseudoLbl
            // 
            j2PseudoLbl.AutoSize = true;
            j2PseudoLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            j2PseudoLbl.Location = new Point(171, 191);
            j2PseudoLbl.Name = "j2PseudoLbl";
            j2PseudoLbl.Size = new Size(40, 15);
            j2PseudoLbl.TabIndex = 13;
            j2PseudoLbl.Text = "label2";
            // 
            // j1ScoreLbl
            // 
            j1ScoreLbl.AutoSize = true;
            j1ScoreLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            j1ScoreLbl.Location = new Point(363, 130);
            j1ScoreLbl.Name = "j1ScoreLbl";
            j1ScoreLbl.Size = new Size(40, 15);
            j1ScoreLbl.TabIndex = 14;
            j1ScoreLbl.Text = "label2";
            // 
            // j2ScoreLbl
            // 
            j2ScoreLbl.AutoSize = true;
            j2ScoreLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            j2ScoreLbl.Location = new Point(363, 191);
            j2ScoreLbl.Name = "j2ScoreLbl";
            j2ScoreLbl.Size = new Size(40, 15);
            j2ScoreLbl.TabIndex = 15;
            j2ScoreLbl.Text = "label2";
            // 
            // menuBtn
            // 
            menuBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuBtn.Location = new Point(97, 256);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(130, 23);
            menuBtn.TabIndex = 16;
            menuBtn.Text = "Menu";
            menuBtn.UseVisualStyleBackColor = true;
            menuBtn.Click += menuBtn_Click;
            // 
            // newGameBtn
            // 
            newGameBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newGameBtn.Location = new Point(363, 256);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(130, 23);
            newGameBtn.TabIndex = 17;
            newGameBtn.Text = "Nouvelle Partie";
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // FinPartie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 300);
            Controls.Add(newGameBtn);
            Controls.Add(menuBtn);
            Controls.Add(j2ScoreLbl);
            Controls.Add(j1ScoreLbl);
            Controls.Add(j2PseudoLbl);
            Controls.Add(j1PseudoLbl);
            Controls.Add(label1);
            Controls.Add(winnerTxt);
            Name = "FinPartie";
            Text = "Jeu : Scores";
            FormClosed += FinPartie_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label winnerTxt;
        private Label label1;
        private Label j1PseudoLbl;
        private Label j2PseudoLbl;
        private Label j1ScoreLbl;
        private Label j2ScoreLbl;
        private Button menuBtn;
        private Button newGameBtn;
    }
}