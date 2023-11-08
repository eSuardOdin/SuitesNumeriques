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
            this.reponseLbl.Location = new System.Drawing.Point(73, 245);
            this.reponseLbl.Name = "reponseLbl";
            this.reponseLbl.Size = new System.Drawing.Size(64, 15);
            this.reponseLbl.TabIndex = 6;
            this.reponseLbl.Text = "Réponse : ";
            // 
            // repBox
            // 
            this.repBox.Location = new System.Drawing.Point(143, 237);
            this.repBox.Name = "repBox";
            this.repBox.Size = new System.Drawing.Size(170, 23);
            this.repBox.TabIndex = 7;
            // 
            // validBtn
            // 
            this.validBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validBtn.Location = new System.Drawing.Point(291, 282);
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
            // ExoEntrainement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.repStatutLbl);
            this.Controls.Add(this.validBtn);
            this.Controls.Add(this.repBox);
            this.Controls.Add(this.reponseLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.enonceLbl);
            this.Name = "ExoEntrainement";
            this.Size = new System.Drawing.Size(714, 319);
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
    }
}
