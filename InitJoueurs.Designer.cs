namespace SuitesNumeriques
{
    partial class InitJoueurs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            j1TxtBox = new TextBox();
            j2TxtBox = new TextBox();
            label4 = new Label();
            suiteBox = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            launchBtn = new Button();
            suiteBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 0;
            label1.Text = "Veuillez saisir le nom des joueurs :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 67);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Joueur N°1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 134);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Joueur N°2";
            // 
            // j1TxtBox
            // 
            j1TxtBox.Location = new Point(134, 64);
            j1TxtBox.Name = "j1TxtBox";
            j1TxtBox.Size = new Size(168, 23);
            j1TxtBox.TabIndex = 3;
            // 
            // j2TxtBox
            // 
            j2TxtBox.Location = new Point(134, 131);
            j2TxtBox.Name = "j2TxtBox";
            j2TxtBox.Size = new Size(168, 23);
            j2TxtBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 196);
            label4.Name = "label4";
            label4.Size = new Size(210, 15);
            label4.TabIndex = 5;
            label4.Text = "Sélectionnez le type de suite du jeu :";
            // 
            // suiteBox
            // 
            suiteBox.Controls.Add(radioButton2);
            suiteBox.Controls.Add(radioButton1);
            suiteBox.Location = new Point(49, 214);
            suiteBox.Name = "suiteBox";
            suiteBox.Size = new Size(253, 49);
            suiteBox.TabIndex = 6;
            suiteBox.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(153, 21);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Tag = "géométrique";
            radioButton2.Text = "Géométrique";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(11, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Tag = "arithmétique";
            radioButton1.Text = "Arithmétique";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // launchBtn
            // 
            launchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            launchBtn.Location = new Point(134, 272);
            launchBtn.Name = "launchBtn";
            launchBtn.Size = new Size(75, 23);
            launchBtn.TabIndex = 7;
            launchBtn.Text = "OK";
            launchBtn.UseVisualStyleBackColor = true;
            launchBtn.Click += launchBtn_Click;
            // 
            // InitJoueurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 307);
            Controls.Add(launchBtn);
            Controls.Add(suiteBox);
            Controls.Add(label4);
            Controls.Add(j2TxtBox);
            Controls.Add(j1TxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InitJoueurs";
            Text = "Jeu : Initialisation de la partie";
            FormClosed += InitJoueurs_FormClosed;
            suiteBox.ResumeLayout(false);
            suiteBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox j1TxtBox;
        private TextBox j2TxtBox;
        private Label label4;
        private GroupBox suiteBox;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button launchBtn;
    }
}