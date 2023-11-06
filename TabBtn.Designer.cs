namespace SuitesNumeriques
{
    partial class TabBtn
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public bool IsSelected { get; set; }


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

        /// <summary>
        /// Change la couleur du tab s'il est selected ou unselected 
        /// </summary>
        public void ChangeFocus()
        {
            if (!IsSelected) tab.BackColor = Color.Gray;
            else tab.BackColor = Color.BlanchedAlmond;
        }
        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            tab = new Button();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Location = new Point(49, 17);
            tab.Name = "tab";
            tab.Size = new Size(75, 23);
            tab.TabIndex = 0;
            tab.Text = "button1";
            tab.UseVisualStyleBackColor = true;
            tab.Click += tab_Click;
            // 
            // TabBtn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tab);
            Name = "TabBtn";
            Size = new Size(127, 43);
            ResumeLayout(false);
        }

        #endregion

        private Button tab;
    }
}
