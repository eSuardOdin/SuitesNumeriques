namespace SuitesNumeriques
{
    partial class Rules
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
            rulesBox = new RichTextBox();
            okBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // rulesBox
            // 
            rulesBox.Location = new Point(29, 25);
            rulesBox.Name = "rulesBox";
            rulesBox.Size = new Size(563, 283);
            rulesBox.TabIndex = 7;
            rulesBox.Text = "";
            // 
            // okBtn
            // 
            okBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            okBtn.Location = new Point(268, 353);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 8;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 320);
            label1.Name = "label1";
            label1.Size = new Size(595, 15);
            label1.TabIndex = 9;
            label1.Text = "ATTENTION: Le formulaire de jeu est toujours ouvert pour montrer à mr Kister que le timer est stoppé, merci de ne";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(12, 335);
            label2.Name = "label2";
            label2.Size = new Size(464, 15);
            label2.TabIndex = 10;
            label2.Text = "pas profiter du temps gratuit pour finir sur le podium des meilleurs scores, petits malins.";
            label2.Visible = false;
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 388);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(okBtn);
            Controls.Add(rulesBox);
            Name = "Rules";
            Text = "Jeu: Règles du jeu";
            FormClosed += Rules_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rulesBox;
        private Button okBtn;
        private Label label1;
        private Label label2;
    }
}