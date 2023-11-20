namespace SuitesNumeriques
{
    partial class HighScores
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
            menuBtn = new Button();
            scoresLbl = new Label();
            scoresList = new ListView();
            SuspendLayout();
            // 
            // menuBtn
            // 
            menuBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuBtn.Location = new Point(219, 362);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(75, 23);
            menuBtn.TabIndex = 0;
            menuBtn.Text = "Menu";
            menuBtn.UseVisualStyleBackColor = true;
            menuBtn.Click += menuBtn_Click;
            // 
            // scoresLbl
            // 
            scoresLbl.AutoSize = true;
            scoresLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            scoresLbl.Location = new Point(219, 32);
            scoresLbl.Name = "scoresLbl";
            scoresLbl.Size = new Size(96, 15);
            scoresLbl.TabIndex = 1;
            scoresLbl.Text = "Meilleurs scores";
            // 
            // scoresList
            // 
            scoresList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            scoresList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            scoresList.LabelWrap = false;
            scoresList.Location = new Point(69, 81);
            scoresList.Name = "scoresList";
            scoresList.Scrollable = false;
            scoresList.Size = new Size(400, 250);
            scoresList.TabIndex = 3;
            scoresList.UseCompatibleStateImageBehavior = false;
            scoresList.ColumnWidthChanging += scoresList_ColumnWidthChanging;
            // 
            // HighScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 452);
            Controls.Add(scoresList);
            Controls.Add(scoresLbl);
            Controls.Add(menuBtn);
            Name = "HighScores";
            Text = "Meilleurs scores";
            FormClosed += HighScores_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuBtn;
        private Label scoresLbl;
        private ListView scoresList;
    }
}