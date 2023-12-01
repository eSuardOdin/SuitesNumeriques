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
            this.menuBtn = new System.Windows.Forms.Button();
            this.scoresLbl = new System.Windows.Forms.Label();
            this.scoresList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuBtn.Location = new System.Drawing.Point(219, 362);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(75, 23);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // scoresLbl
            // 
            this.scoresLbl.AutoSize = true;
            this.scoresLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoresLbl.Location = new System.Drawing.Point(219, 32);
            this.scoresLbl.Name = "scoresLbl";
            this.scoresLbl.Size = new System.Drawing.Size(96, 15);
            this.scoresLbl.TabIndex = 1;
            this.scoresLbl.Text = "Meilleurs scores";
            // 
            // scoresList
            // 
            this.scoresList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoresList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.scoresList.LabelWrap = false;
            this.scoresList.Location = new System.Drawing.Point(69, 81);
            this.scoresList.Name = "scoresList";
            this.scoresList.Scrollable = false;
            this.scoresList.Size = new System.Drawing.Size(400, 250);
            this.scoresList.TabIndex = 3;
            this.scoresList.UseCompatibleStateImageBehavior = false;
            this.scoresList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.scoresList_ColumnWidthChanging);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 452);
            this.Controls.Add(this.scoresList);
            this.Controls.Add(this.scoresLbl);
            this.Controls.Add(this.menuBtn);
            this.Name = "HighScores";
            this.Text = "Meilleurs scores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HighScores_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button menuBtn;
        private Label scoresLbl;
        private ListView scoresList;
    }
}