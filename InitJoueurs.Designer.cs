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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.j1TxtBox = new System.Windows.Forms.TextBox();
            this.j2TxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.suiteBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.launchBtn = new System.Windows.Forms.Button();
            this.suiteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez saisir le nom des joueurs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Joueur N°1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Joueur N°2";
            // 
            // j1TxtBox
            // 
            this.j1TxtBox.Location = new System.Drawing.Point(134, 64);
            this.j1TxtBox.Name = "j1TxtBox";
            this.j1TxtBox.Size = new System.Drawing.Size(168, 23);
            this.j1TxtBox.TabIndex = 3;
            // 
            // j2TxtBox
            // 
            this.j2TxtBox.Location = new System.Drawing.Point(134, 131);
            this.j2TxtBox.Name = "j2TxtBox";
            this.j2TxtBox.Size = new System.Drawing.Size(168, 23);
            this.j2TxtBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sélectionnez le type de suite du jeu :";
            // 
            // suiteBox
            // 
            this.suiteBox.Controls.Add(this.radioButton2);
            this.suiteBox.Controls.Add(this.radioButton1);
            this.suiteBox.Location = new System.Drawing.Point(49, 214);
            this.suiteBox.Name = "suiteBox";
            this.suiteBox.Size = new System.Drawing.Size(253, 49);
            this.suiteBox.TabIndex = 6;
            this.suiteBox.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "arithmétique";
            this.radioButton1.Text = "Arithmétique";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(153, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "géométrique";
            this.radioButton2.Text = "Géométrique";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // launchBtn
            // 
            this.launchBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.launchBtn.Location = new System.Drawing.Point(134, 272);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(75, 23);
            this.launchBtn.TabIndex = 7;
            this.launchBtn.Text = "OK";
            this.launchBtn.UseVisualStyleBackColor = true;
            // 
            // InitJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 307);
            this.Controls.Add(this.launchBtn);
            this.Controls.Add(this.suiteBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.j2TxtBox);
            this.Controls.Add(this.j1TxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InitJoueurs";
            this.Text = "InitJoueurs";
            this.suiteBox.ResumeLayout(false);
            this.suiteBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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