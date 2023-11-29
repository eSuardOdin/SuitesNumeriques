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
            this.enonceLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.reponseLbl = new System.Windows.Forms.Label();
            this.repBox = new System.Windows.Forms.TextBox();
            this.validBtn = new System.Windows.Forms.Button();
            this.repStatutLbl = new System.Windows.Forms.Label();
            this.premierTermeLbl = new System.Windows.Forms.Label();
            this.raisonLbl = new System.Windows.Forms.Label();
            this.premierTermeTxtBox = new System.Windows.Forms.TextBox();
            this.raisonTxtBox = new System.Windows.Forms.TextBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio0 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enonceLbl
            // 
            this.enonceLbl.AutoSize = true;
            this.enonceLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enonceLbl.Location = new System.Drawing.Point(77, 78);
            this.enonceLbl.Name = "enonceLbl";
            this.enonceLbl.Size = new System.Drawing.Size(40, 15);
            this.enonceLbl.TabIndex = 4;
            this.enonceLbl.Text = "label1";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.Location = new System.Drawing.Point(258, 16);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(152, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Nouvelle Recherche";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // reponseLbl
            // 
            this.reponseLbl.AutoSize = true;
            this.reponseLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reponseLbl.Location = new System.Drawing.Point(221, 255);
            this.reponseLbl.Name = "reponseLbl";
            this.reponseLbl.Size = new System.Drawing.Size(64, 15);
            this.reponseLbl.TabIndex = 6;
            this.reponseLbl.Text = "Réponse : ";
            // 
            // repBox
            // 
            this.repBox.Location = new System.Drawing.Point(291, 247);
            this.repBox.Name = "repBox";
            this.repBox.Size = new System.Drawing.Size(170, 23);
            this.repBox.TabIndex = 7;
            // 
            // validBtn
            // 
            this.validBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validBtn.Location = new System.Drawing.Point(291, 293);
            this.validBtn.Name = "validBtn";
            this.validBtn.Size = new System.Drawing.Size(75, 23);
            this.validBtn.TabIndex = 8;
            this.validBtn.Text = "Valider";
            this.validBtn.UseVisualStyleBackColor = true;
            this.validBtn.Click += new System.EventHandler(this.validBtn_Click);
            // 
            // repStatutLbl
            // 
            this.repStatutLbl.AutoSize = true;
            this.repStatutLbl.Location = new System.Drawing.Point(334, 241);
            this.repStatutLbl.Name = "repStatutLbl";
            this.repStatutLbl.Size = new System.Drawing.Size(0, 15);
            this.repStatutLbl.TabIndex = 9;
            // 
            // premierTermeLbl
            // 
            this.premierTermeLbl.AutoSize = true;
            this.premierTermeLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.premierTermeLbl.Location = new System.Drawing.Point(189, 255);
            this.premierTermeLbl.Name = "premierTermeLbl";
            this.premierTermeLbl.Size = new System.Drawing.Size(96, 15);
            this.premierTermeLbl.TabIndex = 13;
            this.premierTermeLbl.Text = "Premier terme :";
            this.premierTermeLbl.Visible = false;
            // 
            // raisonLbl
            // 
            this.raisonLbl.AutoSize = true;
            this.raisonLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raisonLbl.Location = new System.Drawing.Point(236, 230);
            this.raisonLbl.Name = "raisonLbl";
            this.raisonLbl.Size = new System.Drawing.Size(49, 15);
            this.raisonLbl.TabIndex = 10;
            this.raisonLbl.Text = "Raison :";
            this.raisonLbl.Visible = false;
            // 
            // premierTermeTxtBox
            // 
            this.premierTermeTxtBox.Location = new System.Drawing.Point(291, 248);
            this.premierTermeTxtBox.Name = "premierTermeTxtBox";
            this.premierTermeTxtBox.Size = new System.Drawing.Size(110, 23);
            this.premierTermeTxtBox.TabIndex = 12;
            this.premierTermeTxtBox.Visible = false;
            // 
            // raisonTxtBox
            // 
            this.raisonTxtBox.Location = new System.Drawing.Point(291, 223);
            this.raisonTxtBox.Name = "raisonTxtBox";
            this.raisonTxtBox.Size = new System.Drawing.Size(110, 23);
            this.raisonTxtBox.TabIndex = 11;
            this.raisonTxtBox.Visible = false;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(9, 46);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(137, 19);
            this.radio2.TabIndex = 16;
            this.radio2.TabStop = true;
            this.radio2.Text = "Monotone croissante";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio0
            // 
            this.radio0.AutoSize = true;
            this.radio0.Location = new System.Drawing.Point(9, 22);
            this.radio0.Name = "radio0";
            this.radio0.Size = new System.Drawing.Size(107, 19);
            this.radio0.TabIndex = 14;
            this.radio0.TabStop = true;
            this.radio0.Text = "Non monotone";
            this.radio0.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(170, 46);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(150, 19);
            this.radio3.TabIndex = 17;
            this.radio3.TabStop = true;
            this.radio3.Text = "Monotone décroissante";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(170, 22);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(136, 19);
            this.radio1.TabIndex = 15;
            this.radio1.TabStop = true;
            this.radio1.Text = "Monotone constante";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio0);
            this.groupBox1.Controls.Add(this.radio3);
            this.groupBox1.Controls.Add(this.radio2);
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.Location = new System.Drawing.Point(175, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 74);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // ExoEntrainement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.premierTermeLbl);
            this.Controls.Add(this.raisonLbl);
            this.Controls.Add(this.premierTermeTxtBox);
            this.Controls.Add(this.raisonTxtBox);
            this.Controls.Add(this.repStatutLbl);
            this.Controls.Add(this.validBtn);
            this.Controls.Add(this.repBox);
            this.Controls.Add(this.reponseLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.enonceLbl);
            this.Name = "ExoEntrainement";
            this.Size = new System.Drawing.Size(714, 319);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
