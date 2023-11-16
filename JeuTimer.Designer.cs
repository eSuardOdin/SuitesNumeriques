namespace SuitesNumeriques
{
    partial class JeuTimer
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
            timeLbl = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            timeLbl.Location = new Point(400, 25);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(49, 15);
            timeLbl.TabIndex = 11;
            timeLbl.Text = "timeLbl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(302, 25);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 12;
            label2.Text = "Temps restant :";
            // 
            // JeuTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(timeLbl);
            Name = "JeuTimer";
            Text = "JeuTimer";
            Controls.SetChildIndex(timeLbl, 0);
            Controls.SetChildIndex(label2, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLbl;
        private Label label2;
    }
}