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
            scoresData = new DataGridView();
            scoresList = new ListView();
            ((System.ComponentModel.ISupportInitialize)scoresData).BeginInit();
            SuspendLayout();
            // 
            // menuBtn
            // 
            menuBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuBtn.Location = new Point(345, 415);
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
            scoresLbl.Location = new Point(72, 27);
            scoresLbl.Name = "scoresLbl";
            scoresLbl.Size = new Size(40, 15);
            scoresLbl.TabIndex = 1;
            scoresLbl.Text = "label1";
            // 
            // scoresData
            // 
            scoresData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scoresData.Location = new Point(177, 12);
            scoresData.Name = "scoresData";
            scoresData.RowTemplate.Height = 25;
            scoresData.Size = new Size(92, 106);
            scoresData.TabIndex = 2;
            // 
            // scoresList
            // 
            scoresList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            scoresList.Location = new Point(177, 124);
            scoresList.Name = "scoresList";
            scoresList.Size = new Size(400, 250);
            scoresList.TabIndex = 3;
            scoresList.UseCompatibleStateImageBehavior = false;
            // 
            // HighScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoresList);
            Controls.Add(scoresData);
            Controls.Add(scoresLbl);
            Controls.Add(menuBtn);
            Name = "HighScores";
            Text = "Meilleurs scores";
            FormClosed += HighScores_FormClosed;
            ((System.ComponentModel.ISupportInitialize)scoresData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuBtn;
        private Label scoresLbl;
        private DataGridView scoresData;
        private ListView scoresList;
    }
}