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
            resetBtn = new Button();
            validBtn = new Button();
            answerTxt = new TextBox();
            answerLbl = new Label();
            enonceLbl = new Label();
            SuspendLayout();
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(279, 34);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(140, 23);
            resetBtn.TabIndex = 0;
            resetBtn.Text = "Nouvelle Recherche";
            resetBtn.UseVisualStyleBackColor = true;
            // 
            // validBtn
            // 
            validBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            validBtn.Location = new Point(309, 299);
            validBtn.Name = "validBtn";
            validBtn.Size = new Size(75, 23);
            validBtn.TabIndex = 1;
            validBtn.Text = "Valider";
            validBtn.UseVisualStyleBackColor = true;
            // 
            // answerTxt
            // 
            answerTxt.Location = new Point(159, 270);
            answerTxt.Name = "answerTxt";
            answerTxt.Size = new Size(225, 23);
            answerTxt.TabIndex = 2;
            // 
            // answerLbl
            // 
            answerLbl.AutoSize = true;
            answerLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            answerLbl.Location = new Point(77, 273);
            answerLbl.Name = "answerLbl";
            answerLbl.Size = new Size(64, 15);
            answerLbl.TabIndex = 3;
            answerLbl.Text = "Réponse : ";
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
            // ExoEntrainement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(enonceLbl);
            Controls.Add(answerLbl);
            Controls.Add(answerTxt);
            Controls.Add(validBtn);
            Controls.Add(resetBtn);
            Name = "ExoEntrainement";
            Size = new Size(714, 325);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetBtn;
        private Button validBtn;
        private TextBox answerTxt;
        private Label answerLbl;
        private Label enonceLbl;
    }
}
