namespace SuitesNumeriques
{
    partial class ExoEntrainement
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            enonceLbl = new Label();
            resetBtn = new Button();
            reponseLbl = new Label();
            repBox = new TextBox();
            validBtn = new Button();
            repStatutLbl = new Label();
            premierTermeLbl = new Label();
            raisonLbl = new Label();
            premierTermeTxtBox = new TextBox();
            raisonTxtBox = new TextBox();
            radio2 = new RadioButton();
            radio0 = new RadioButton();
            radio3 = new RadioButton();
            radio1 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // enonceLbl
            // 
            enonceLbl.AutoSize = true;
            enonceLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            enonceLbl.Location = new Point(77, 78);
            enonceLbl.Name = "enonceLbl";
            enonceLbl.Size = new Size(40, 15);
            enonceLbl.TabIndex = 4;
            enonceLbl.Text = "label1";
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(258, 16);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(152, 23);
            resetBtn.TabIndex = 5;
            resetBtn.Text = "Nouvelle Recherche";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // reponseLbl
            // 
            reponseLbl.AutoSize = true;
            reponseLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reponseLbl.Location = new Point(96, 251);
            reponseLbl.Name = "reponseLbl";
            reponseLbl.Size = new Size(64, 15);
            reponseLbl.TabIndex = 6;
            reponseLbl.Text = "Réponse : ";
            // 
            // repBox
            // 
            repBox.Location = new Point(291, 247);
            repBox.Name = "repBox";
            repBox.Size = new Size(170, 23);
            repBox.TabIndex = 7;
            // 
            // validBtn
            // 
            validBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            validBtn.Location = new Point(291, 293);
            validBtn.Name = "validBtn";
            validBtn.Size = new Size(75, 23);
            validBtn.TabIndex = 8;
            validBtn.Text = "Valider";
            validBtn.UseVisualStyleBackColor = true;
            validBtn.Click += validBtn_Click;
            // 
            // repStatutLbl
            // 
            repStatutLbl.AutoSize = true;
            repStatutLbl.Location = new Point(334, 241);
            repStatutLbl.Name = "repStatutLbl";
            repStatutLbl.Size = new Size(0, 15);
            repStatutLbl.TabIndex = 9;
            // 
            // premierTermeLbl
            // 
            premierTermeLbl.AutoSize = true;
            premierTermeLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            premierTermeLbl.Location = new Point(189, 255);
            premierTermeLbl.Name = "premierTermeLbl";
            premierTermeLbl.Size = new Size(96, 15);
            premierTermeLbl.TabIndex = 13;
            premierTermeLbl.Text = "Premier terme :";
            premierTermeLbl.Visible = false;
            // 
            // raisonLbl
            // 
            raisonLbl.AutoSize = true;
            raisonLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            raisonLbl.Location = new Point(236, 230);
            raisonLbl.Name = "raisonLbl";
            raisonLbl.Size = new Size(49, 15);
            raisonLbl.TabIndex = 10;
            raisonLbl.Text = "Raison :";
            raisonLbl.Visible = false;
            // 
            // premierTermeTxtBox
            // 
            premierTermeTxtBox.Location = new Point(291, 248);
            premierTermeTxtBox.Name = "premierTermeTxtBox";
            premierTermeTxtBox.Size = new Size(110, 23);
            premierTermeTxtBox.TabIndex = 12;
            premierTermeTxtBox.Visible = false;
            // 
            // raisonTxtBox
            // 
            raisonTxtBox.Location = new Point(291, 223);
            raisonTxtBox.Name = "raisonTxtBox";
            raisonTxtBox.Size = new Size(110, 23);
            raisonTxtBox.TabIndex = 11;
            raisonTxtBox.Visible = false;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Location = new Point(9, 46);
            radio2.Name = "radio2";
            radio2.Size = new Size(137, 19);
            radio2.TabIndex = 16;
            radio2.TabStop = true;
            radio2.Text = "Monotone croissante";
            radio2.UseVisualStyleBackColor = true;
            // 
            // radio0
            // 
            radio0.AutoSize = true;
            radio0.Location = new Point(9, 22);
            radio0.Name = "radio0";
            radio0.Size = new Size(107, 19);
            radio0.TabIndex = 14;
            radio0.TabStop = true;
            radio0.Text = "Non monotone";
            radio0.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            radio3.AutoSize = true;
            radio3.Location = new Point(170, 46);
            radio3.Name = "radio3";
            radio3.Size = new Size(150, 19);
            radio3.TabIndex = 17;
            radio3.TabStop = true;
            radio3.Text = "Monotone décroissante";
            radio3.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Location = new Point(170, 22);
            radio1.Name = "radio1";
            radio1.Size = new Size(136, 19);
            radio1.TabIndex = 15;
            radio1.TabStop = true;
            radio1.Text = "Monotone constante";
            radio1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio0);
            groupBox1.Controls.Add(radio3);
            groupBox1.Controls.Add(radio2);
            groupBox1.Controls.Add(radio1);
            groupBox1.Location = new Point(175, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 74);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // ExoEntrainement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(raisonLbl);
            Controls.Add(repStatutLbl);
            Controls.Add(validBtn);
            Controls.Add(reponseLbl);
            Controls.Add(resetBtn);
            Controls.Add(enonceLbl);
            Controls.Add(raisonTxtBox);
            Controls.Add(premierTermeTxtBox);
            Controls.Add(repBox);
            Controls.Add(groupBox1);
            Controls.Add(premierTermeLbl);
            Name = "ExoEntrainement";
            Size = new Size(714, 319);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enonceLbl;
        private Button resetBtn;
        private Label reponseLbl;
        private TextBox repBox;
        private Button validBtn;
        private Label repStatutLbl;
        private Label premierTermeLbl;
        private Label raisonLbl;
        private TextBox premierTermeTxtBox;
        private TextBox raisonTxtBox;
        private RadioButton radio2;
        private RadioButton radio0;
        private RadioButton radio3;
        private RadioButton radio1;
        private GroupBox groupBox1;
    }
}
