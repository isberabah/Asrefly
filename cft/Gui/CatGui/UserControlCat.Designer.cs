namespace cft.Gui
{
    partial class UserControlCat
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
            Cat = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Cat
            // 
            Cat.AutoSize = true;
            Cat.Location = new System.Drawing.Point(339, 244);
            Cat.Name = "Cat";
            Cat.Size = new System.Drawing.Size(38, 15);
            Cat.TabIndex = 0;
            Cat.Text = "label1";
            // 
            // UserControlCat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(Cat);
            Name = "UserControlCat";
            Size = new System.Drawing.Size(1053, 605);
            Load += UserControlCat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Cat;
    }
}
