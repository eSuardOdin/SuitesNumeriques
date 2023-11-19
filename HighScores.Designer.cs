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
            // HighScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuBtn);
            Name = "HighScores";
            Text = "Meilleurs scores";
            FormClosed += HighScores_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button menuBtn;
    }
}