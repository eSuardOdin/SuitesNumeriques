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
            SuspendLayout();
            // 
            // enonceLbl
            // 
            enonceLbl.AutoSize = true;
            enonceLbl.Location = new Point(77, 78);
            enonceLbl.Name = "enonceLbl";
            enonceLbl.Size = new Size(38, 15);
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
            // ExoEntrainement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resetBtn);
            Controls.Add(enonceLbl);
            Name = "ExoEntrainement";
            Size = new Size(714, 203);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enonceLbl;
        private Button resetBtn;
    }
}
