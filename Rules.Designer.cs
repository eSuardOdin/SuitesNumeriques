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
            SuspendLayout();
            // 
            // rulesBox
            // 
            rulesBox.Location = new Point(29, 25);
            rulesBox.Name = "rulesBox";
            rulesBox.Size = new Size(563, 315);
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
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 388);
            Controls.Add(okBtn);
            Controls.Add(rulesBox);
            Name = "Rules";
            Text = "Jeu: Règles du jeu";
            FormClosed += Rules_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rulesBox;
        private Button okBtn;
    }
}