namespace SAE24
{
    partial class MembreEquipage
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
            this.pbMembre = new System.Windows.Forms.PictureBox();
            this.lblMembre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMembre
            // 
            this.pbMembre.Location = new System.Drawing.Point(18, 3);
            this.pbMembre.Name = "pbMembre";
            this.pbMembre.Size = new System.Drawing.Size(84, 84);
            this.pbMembre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMembre.TabIndex = 0;
            this.pbMembre.TabStop = false;
            // 
            // lblMembre
            // 
            this.lblMembre.Location = new System.Drawing.Point(0, 90);
            this.lblMembre.Name = "lblMembre";
            this.lblMembre.Size = new System.Drawing.Size(120, 33);
            this.lblMembre.TabIndex = 1;
            this.lblMembre.Text = "label1";
            this.lblMembre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MembreEquipage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMembre);
            this.Controls.Add(this.pbMembre);
            this.Name = "MembreEquipage";
            this.Size = new System.Drawing.Size(118, 121);
            ((System.ComponentModel.ISupportInitialize)(this.pbMembre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMembre;
        private System.Windows.Forms.Label lblMembre;
    }
}
