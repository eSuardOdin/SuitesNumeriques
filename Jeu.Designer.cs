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
            joueurLbl = new Label();
            pointsLbl = new Label();
            validBtn = new Button();
            skipBtn = new Button();
            button1 = new Button();
            reglesBtn = new Button();
            tab0 = new TabControl();
            exoContainer = new TabPage();
            repBox = new GroupBox();
            radio3 = new RadioButton();
            repTxtBox = new TextBox();
            radio2 = new RadioButton();
            label1 = new Label();
            radio1 = new RadioButton();
            radio0 = new RadioButton();
            enonceLbl = new Label();
            joueurTxt = new Label();
            pointsTxt = new Label();
            tab0.SuspendLayout();
            exoContainer.SuspendLayout();
            repBox.SuspendLayout();
            SuspendLayout();
            // 
            // joueurLbl
            // 
            joueurLbl.AutoSize = true;
            joueurLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            joueurLbl.Location = new Point(36, 25);
            joueurLbl.Name = "joueurLbl";
            joueurLbl.Size = new Size(73, 15);
            joueurLbl.TabIndex = 0;
            joueurLbl.Text = "Joueur N°* :";
            // 
            // pointsLbl
            // 
            pointsLbl.AutoSize = true;
            pointsLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pointsLbl.Location = new Point(560, 25);
            pointsLbl.Name = "pointsLbl";
            pointsLbl.Size = new Size(47, 15);
            pointsLbl.TabIndex = 2;
            pointsLbl.Text = "Points :";
            // 
            // validBtn
            // 
            validBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            validBtn.Location = new Point(34, 415);
            validBtn.Name = "validBtn";
            validBtn.Size = new Size(75, 23);
            validBtn.TabIndex = 4;
            validBtn.Text = "Valider";
            validBtn.UseVisualStyleBackColor = true;
            validBtn.Click += validBtn_Click;
            // 
            // skipBtn
            // 
            skipBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            skipBtn.Location = new Point(133, 413);
            skipBtn.Name = "skipBtn";
            skipBtn.Size = new Size(135, 23);
            skipBtn.TabIndex = 5;
            skipBtn.Text = "Passer la question";
            skipBtn.UseVisualStyleBackColor = true;
            skipBtn.Click += skipBtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(619, 413);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Scores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // reglesBtn
            // 
            reglesBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reglesBtn.Location = new Point(713, 413);
            reglesBtn.Name = "reglesBtn";
            reglesBtn.Size = new Size(75, 23);
            reglesBtn.TabIndex = 7;
            reglesBtn.Text = "Règles";
            reglesBtn.UseVisualStyleBackColor = true;
            reglesBtn.Click += reglesBtn_Click;
            // 
            // tab0
            // 
            tab0.Controls.Add(exoContainer);
            tab0.Location = new Point(42, 51);
            tab0.Name = "tab0";
            tab0.SelectedIndex = 0;
            tab0.Size = new Size(723, 356);
            tab0.TabIndex = 8;
            // 
            // exoContainer
            // 
            exoContainer.Controls.Add(repBox);
            exoContainer.Controls.Add(enonceLbl);
            exoContainer.Location = new Point(4, 24);
            exoContainer.Name = "exoContainer";
            exoContainer.Padding = new Padding(3);
            exoContainer.Size = new Size(715, 328);
            exoContainer.TabIndex = 0;
            exoContainer.Text = "tabPage1";
            exoContainer.UseVisualStyleBackColor = true;
            // 
            // repBox
            // 
            repBox.Controls.Add(radio3);
            repBox.Controls.Add(repTxtBox);
            repBox.Controls.Add(radio2);
            repBox.Controls.Add(label1);
            repBox.Controls.Add(radio1);
            repBox.Controls.Add(radio0);
            repBox.Location = new Point(146, 245);
            repBox.Name = "repBox";
            repBox.Size = new Size(379, 76);
            repBox.TabIndex = 1;
            repBox.TabStop = false;
            // 
            // radio3
            // 
            radio3.AutoSize = true;
            radio3.Enabled = false;
            radio3.Location = new Point(208, 47);
            radio3.Name = "radio3";
            radio3.Size = new Size(150, 19);
            radio3.TabIndex = 7;
            radio3.TabStop = true;
            radio3.Text = "Monotone décroissante";
            radio3.UseVisualStyleBackColor = true;
            radio3.Visible = false;
            // 
            // repTxtBox
            // 
            repTxtBox.Location = new Point(86, 29);
            repTxtBox.Name = "repTxtBox";
            repTxtBox.Size = new Size(206, 23);
            repTxtBox.TabIndex = 1;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Enabled = false;
            radio2.Location = new Point(75, 46);
            radio2.Name = "radio2";
            radio2.Size = new Size(137, 19);
            radio2.TabIndex = 6;
            radio2.TabStop = true;
            radio2.Text = "Monotone croissante";
            radio2.UseVisualStyleBackColor = true;
            radio2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Réponse :";
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Enabled = false;
            radio1.Location = new Point(208, 22);
            radio1.Name = "radio1";
            radio1.Size = new Size(136, 19);
            radio1.TabIndex = 5;
            radio1.TabStop = true;
            radio1.Text = "Monotone constante";
            radio1.UseVisualStyleBackColor = true;
            radio1.Visible = false;
            // 
            // radio0
            // 
            radio0.AutoSize = true;
            radio0.Enabled = false;
            radio0.Location = new Point(75, 22);
            radio0.Name = "radio0";
            radio0.Size = new Size(107, 19);
            radio0.TabIndex = 4;
            radio0.TabStop = true;
            radio0.Text = "Non monotone";
            radio0.UseVisualStyleBackColor = true;
            radio0.Visible = false;
            // 
            // enonceLbl
            // 
            enonceLbl.AutoSize = true;
            enonceLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            enonceLbl.Location = new Point(29, 26);
            enonceLbl.Name = "enonceLbl";
            enonceLbl.Size = new Size(64, 15);
            enonceLbl.TabIndex = 0;
            enonceLbl.Text = "enonceLbl";
            // 
            // joueurTxt
            // 
            joueurTxt.BackColor = SystemColors.Info;
            joueurTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            joueurTxt.Location = new Point(115, 20);
            joueurTxt.Name = "joueurTxt";
            joueurTxt.Padding = new Padding(10, 3, 10, 3);
            joueurTxt.Size = new Size(150, 25);
            joueurTxt.TabIndex = 9;
            joueurTxt.Text = "label2";
            joueurTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pointsTxt
            // 
            pointsTxt.BackColor = SystemColors.Info;
            pointsTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pointsTxt.Location = new Point(619, 20);
            pointsTxt.Name = "pointsTxt";
            pointsTxt.Padding = new Padding(10, 3, 10, 3);
            pointsTxt.Size = new Size(150, 25);
            pointsTxt.TabIndex = 10;
            pointsTxt.Text = "label2";
            pointsTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Jeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pointsTxt);
            Controls.Add(joueurTxt);
            Controls.Add(tab0);
            Controls.Add(reglesBtn);
            Controls.Add(button1);
            Controls.Add(skipBtn);
            Controls.Add(validBtn);
            Controls.Add(pointsLbl);
            Controls.Add(joueurLbl);
            Name = "Jeu";
            Text = "Jeu";
            FormClosed += Jeu_FormClosed;
            Load += Jeu_Load;
            tab0.ResumeLayout(false);
            exoContainer.ResumeLayout(false);
            exoContainer.PerformLayout();
            repBox.ResumeLayout(false);
            repBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private TextBox repTxtBox;
        private Label joueurTxt;
        private Label pointsTxt;
        private RadioButton radio3;
        private RadioButton radio2;
        private RadioButton radio1;
        private RadioButton radio0;
    }
}