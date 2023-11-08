namespace SuitesNumeriques.classes
{
    partial class ExoEntrainementMonotonie
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
            this.validBtn = new System.Windows.Forms.Button();
            this.reponseLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.enonceLbl = new System.Windows.Forms.Label();
            this.repBox = new System.Windows.Forms.GroupBox();
            this.radio0 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.repBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // validBtn
            // 
            this.validBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validBtn.Location = new System.Drawing.Point(309, 307);
            this.validBtn.Name = "validBtn";
            this.validBtn.Size = new System.Drawing.Size(75, 23);
            this.validBtn.TabIndex = 13;
            this.validBtn.Text = "Valider";
            this.validBtn.UseVisualStyleBackColor = true;
            this.validBtn.Click += new System.EventHandler(this.validBtn_Click);
            // 
            // reponseLbl
            // 
            this.reponseLbl.AutoSize = true;
            this.reponseLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reponseLbl.Location = new System.Drawing.Point(91, 270);
            this.reponseLbl.Name = "reponseLbl";
            this.reponseLbl.Size = new System.Drawing.Size(64, 15);
            this.reponseLbl.TabIndex = 11;
            this.reponseLbl.Text = "Réponse : ";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.Location = new System.Drawing.Point(276, 41);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(152, 23);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Nouvelle Recherche";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // enonceLbl
            // 
            this.enonceLbl.AutoSize = true;
            this.enonceLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enonceLbl.Location = new System.Drawing.Point(95, 103);
            this.enonceLbl.Name = "enonceLbl";
            this.enonceLbl.Size = new System.Drawing.Size(40, 15);
            this.enonceLbl.TabIndex = 9;
            this.enonceLbl.Text = "label1";
            // 
            // repBox
            // 
            this.repBox.Controls.Add(this.radio3);
            this.repBox.Controls.Add(this.radio2);
            this.repBox.Controls.Add(this.radio1);
            this.repBox.Controls.Add(this.radio0);
            this.repBox.Location = new System.Drawing.Point(161, 223);
            this.repBox.Name = "repBox";
            this.repBox.Size = new System.Drawing.Size(322, 78);
            this.repBox.TabIndex = 14;
            this.repBox.TabStop = false;
            // 
            // radio0
            // 
            this.radio0.AutoSize = true;
            this.radio0.Location = new System.Drawing.Point(15, 23);
            this.radio0.Name = "radio0";
            this.radio0.Size = new System.Drawing.Size(107, 19);
            this.radio0.TabIndex = 0;
            this.radio0.TabStop = true;
            this.radio0.Text = "Non monotone";
            this.radio0.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(148, 23);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(136, 19);
            this.radio1.TabIndex = 1;
            this.radio1.TabStop = true;
            this.radio1.Text = "Monotone constante";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(15, 47);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(137, 19);
            this.radio2.TabIndex = 2;
            this.radio2.TabStop = true;
            this.radio2.Text = "Monotone croissante";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(148, 48);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(150, 19);
            this.radio3.TabIndex = 3;
            this.radio3.TabStop = true;
            this.radio3.Text = "Monotone décroissante";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // ExoEntrainementMonotonie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.repBox);
            this.Controls.Add(this.validBtn);
            this.Controls.Add(this.reponseLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.enonceLbl);
            this.Name = "ExoEntrainementMonotonie";
            this.Size = new System.Drawing.Size(708, 441);
            this.repBox.ResumeLayout(false);
            this.repBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button validBtn;
        private Label reponseLbl;
        private Button resetBtn;
        private Label enonceLbl;
        private GroupBox repBox;
        private RadioButton radio3;
        private RadioButton radio2;
        private RadioButton radio1;
        private RadioButton radio0;
    }
}
