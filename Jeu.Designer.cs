namespace SuitesNumeriques
{
    partial class Jeu
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
            this.joueurLbl = new System.Windows.Forms.Label();
            this.pointsLbl = new System.Windows.Forms.Label();
            this.validBtn = new System.Windows.Forms.Button();
            this.skipBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reglesBtn = new System.Windows.Forms.Button();
            this.tab0 = new System.Windows.Forms.TabControl();
            this.exoContainer = new System.Windows.Forms.TabPage();
            this.repBox = new System.Windows.Forms.GroupBox();
            this.premierTermeLbl = new System.Windows.Forms.Label();
            this.raisonLbl = new System.Windows.Forms.Label();
            this.premierTermeTxtBox = new System.Windows.Forms.TextBox();
            this.raisonTxtBox = new System.Windows.Forms.TextBox();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.repTxtBox = new System.Windows.Forms.TextBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.reponseLbl = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio0 = new System.Windows.Forms.RadioButton();
            this.enonceLbl = new System.Windows.Forms.Label();
            this.joueurTxt = new System.Windows.Forms.Label();
            this.pointsTxt = new System.Windows.Forms.Label();
            this.tab0.SuspendLayout();
            this.exoContainer.SuspendLayout();
            this.repBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // joueurLbl
            // 
            this.joueurLbl.AutoSize = true;
            this.joueurLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joueurLbl.Location = new System.Drawing.Point(36, 25);
            this.joueurLbl.Name = "joueurLbl";
            this.joueurLbl.Size = new System.Drawing.Size(73, 15);
            this.joueurLbl.TabIndex = 0;
            this.joueurLbl.Text = "Joueur N°* :";
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointsLbl.Location = new System.Drawing.Point(560, 25);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(47, 15);
            this.pointsLbl.TabIndex = 2;
            this.pointsLbl.Text = "Points :";
            // 
            // validBtn
            // 
            this.validBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validBtn.Location = new System.Drawing.Point(34, 415);
            this.validBtn.Name = "validBtn";
            this.validBtn.Size = new System.Drawing.Size(75, 23);
            this.validBtn.TabIndex = 4;
            this.validBtn.Text = "Valider";
            this.validBtn.UseVisualStyleBackColor = true;
            this.validBtn.Click += new System.EventHandler(this.validBtn_Click);
            // 
            // skipBtn
            // 
            this.skipBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skipBtn.Location = new System.Drawing.Point(133, 413);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(135, 23);
            this.skipBtn.TabIndex = 5;
            this.skipBtn.Text = "Passer la question";
            this.skipBtn.UseVisualStyleBackColor = true;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(619, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Scores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reglesBtn
            // 
            this.reglesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reglesBtn.Location = new System.Drawing.Point(713, 413);
            this.reglesBtn.Name = "reglesBtn";
            this.reglesBtn.Size = new System.Drawing.Size(75, 23);
            this.reglesBtn.TabIndex = 7;
            this.reglesBtn.Text = "Règles";
            this.reglesBtn.UseVisualStyleBackColor = true;
            this.reglesBtn.Click += new System.EventHandler(this.reglesBtn_Click);
            // 
            // tab0
            // 
            this.tab0.Controls.Add(this.exoContainer);
            this.tab0.Location = new System.Drawing.Point(42, 51);
            this.tab0.Name = "tab0";
            this.tab0.SelectedIndex = 0;
            this.tab0.Size = new System.Drawing.Size(723, 356);
            this.tab0.TabIndex = 8;
            // 
            // exoContainer
            // 
            this.exoContainer.Controls.Add(this.repBox);
            this.exoContainer.Controls.Add(this.enonceLbl);
            this.exoContainer.Location = new System.Drawing.Point(4, 24);
            this.exoContainer.Name = "exoContainer";
            this.exoContainer.Padding = new System.Windows.Forms.Padding(3);
            this.exoContainer.Size = new System.Drawing.Size(715, 328);
            this.exoContainer.TabIndex = 0;
            this.exoContainer.Text = "tabPage1";
            this.exoContainer.UseVisualStyleBackColor = true;
            // 
            // repBox
            // 
            this.repBox.Controls.Add(this.premierTermeLbl);
            this.repBox.Controls.Add(this.radio3);
            this.repBox.Controls.Add(this.repTxtBox);
            this.repBox.Controls.Add(this.raisonLbl);
            this.repBox.Controls.Add(this.radio2);
            this.repBox.Controls.Add(this.reponseLbl);
            this.repBox.Controls.Add(this.premierTermeTxtBox);
            this.repBox.Controls.Add(this.radio1);
            this.repBox.Controls.Add(this.raisonTxtBox);
            this.repBox.Controls.Add(this.radio0);
            this.repBox.Location = new System.Drawing.Point(146, 245);
            this.repBox.Name = "repBox";
            this.repBox.Size = new System.Drawing.Size(379, 76);
            this.repBox.TabIndex = 1;
            this.repBox.TabStop = false;
            // 
            // premierTermeLbl
            // 
            this.premierTermeLbl.AutoSize = true;
            this.premierTermeLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.premierTermeLbl.Location = new System.Drawing.Point(9, 49);
            this.premierTermeLbl.Name = "premierTermeLbl";
            this.premierTermeLbl.Size = new System.Drawing.Size(96, 15);
            this.premierTermeLbl.TabIndex = 8;
            this.premierTermeLbl.Text = "Premier terme :";
            this.premierTermeLbl.Visible = false;
            // 
            // raisonLbl
            // 
            this.raisonLbl.AutoSize = true;
            this.raisonLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raisonLbl.Location = new System.Drawing.Point(56, 24);
            this.raisonLbl.Name = "raisonLbl";
            this.raisonLbl.Size = new System.Drawing.Size(49, 15);
            this.raisonLbl.TabIndex = 2;
            this.raisonLbl.Text = "Raison :";
            this.raisonLbl.Visible = false;
            // 
            // premierTermeTxtBox
            // 
            this.premierTermeTxtBox.Location = new System.Drawing.Point(111, 42);
            this.premierTermeTxtBox.Name = "premierTermeTxtBox";
            this.premierTermeTxtBox.Size = new System.Drawing.Size(110, 23);
            this.premierTermeTxtBox.TabIndex = 3;
            this.premierTermeTxtBox.Visible = false;
            // 
            // raisonTxtBox
            // 
            this.raisonTxtBox.Location = new System.Drawing.Point(111, 17);
            this.raisonTxtBox.Name = "raisonTxtBox";
            this.raisonTxtBox.Size = new System.Drawing.Size(110, 23);
            this.raisonTxtBox.TabIndex = 2;
            this.raisonTxtBox.Visible = false;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Enabled = false;
            this.radio3.Location = new System.Drawing.Point(208, 47);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(150, 19);
            this.radio3.TabIndex = 7;
            this.radio3.TabStop = true;
            this.radio3.Text = "Monotone décroissante";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.Visible = false;
            // 
            // repTxtBox
            // 
            this.repTxtBox.Location = new System.Drawing.Point(86, 29);
            this.repTxtBox.Name = "repTxtBox";
            this.repTxtBox.Size = new System.Drawing.Size(206, 23);
            this.repTxtBox.TabIndex = 1;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Enabled = false;
            this.radio2.Location = new System.Drawing.Point(75, 46);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(137, 19);
            this.radio2.TabIndex = 6;
            this.radio2.TabStop = true;
            this.radio2.Text = "Monotone croissante";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.Visible = false;
            // 
            // reponseLbl
            // 
            this.reponseLbl.AutoSize = true;
            this.reponseLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reponseLbl.Location = new System.Drawing.Point(6, 32);
            this.reponseLbl.Name = "reponseLbl";
            this.reponseLbl.Size = new System.Drawing.Size(61, 15);
            this.reponseLbl.TabIndex = 0;
            this.reponseLbl.Text = "Réponse :";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Enabled = false;
            this.radio1.Location = new System.Drawing.Point(208, 22);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(136, 19);
            this.radio1.TabIndex = 5;
            this.radio1.TabStop = true;
            this.radio1.Text = "Monotone constante";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.Visible = false;
            // 
            // radio0
            // 
            this.radio0.AutoSize = true;
            this.radio0.Enabled = false;
            this.radio0.Location = new System.Drawing.Point(75, 22);
            this.radio0.Name = "radio0";
            this.radio0.Size = new System.Drawing.Size(107, 19);
            this.radio0.TabIndex = 4;
            this.radio0.TabStop = true;
            this.radio0.Text = "Non monotone";
            this.radio0.UseVisualStyleBackColor = true;
            this.radio0.Visible = false;
            // 
            // enonceLbl
            // 
            this.enonceLbl.AutoSize = true;
            this.enonceLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enonceLbl.Location = new System.Drawing.Point(29, 26);
            this.enonceLbl.Name = "enonceLbl";
            this.enonceLbl.Size = new System.Drawing.Size(64, 15);
            this.enonceLbl.TabIndex = 0;
            this.enonceLbl.Text = "enonceLbl";
            // 
            // joueurTxt
            // 
            this.joueurTxt.BackColor = System.Drawing.SystemColors.Info;
            this.joueurTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joueurTxt.Location = new System.Drawing.Point(115, 20);
            this.joueurTxt.Name = "joueurTxt";
            this.joueurTxt.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.joueurTxt.Size = new System.Drawing.Size(150, 25);
            this.joueurTxt.TabIndex = 9;
            this.joueurTxt.Text = "label2";
            this.joueurTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsTxt
            // 
            this.pointsTxt.BackColor = System.Drawing.SystemColors.Info;
            this.pointsTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointsTxt.Location = new System.Drawing.Point(619, 20);
            this.pointsTxt.Name = "pointsTxt";
            this.pointsTxt.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pointsTxt.Size = new System.Drawing.Size(150, 25);
            this.pointsTxt.TabIndex = 10;
            this.pointsTxt.Text = "label2";
            this.pointsTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pointsTxt);
            this.Controls.Add(this.joueurTxt);
            this.Controls.Add(this.tab0);
            this.Controls.Add(this.reglesBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skipBtn);
            this.Controls.Add(this.validBtn);
            this.Controls.Add(this.pointsLbl);
            this.Controls.Add(this.joueurLbl);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jeu_FormClosed);
            this.tab0.ResumeLayout(false);
            this.exoContainer.ResumeLayout(false);
            this.exoContainer.PerformLayout();
            this.repBox.ResumeLayout(false);
            this.repBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label joueurLbl;
        private Label pointsLbl;
        private Button validBtn;
        private Button skipBtn;
        private Button button1;
        private Button reglesBtn;
        private TabControl tab0;
        private TabPage exoContainer;
        private Label enonceLbl;
        private GroupBox repBox;
        private Label reponseLbl;
        private TextBox repTxtBox;
        private Label joueurTxt;
        private Label pointsTxt;
        private RadioButton radio3;
        private RadioButton radio2;
        private RadioButton radio1;
        private RadioButton radio0;
        private Label premierTermeLbl;
        private Label raisonLbl;
        private TextBox premierTermeTxtBox;
        private TextBox raisonTxtBox;
    }
}