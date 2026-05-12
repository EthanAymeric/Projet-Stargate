namespace UserControlPlanetes
{
    partial class UserControlEspeces
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
            this.pbEspece = new System.Windows.Forms.PictureBox();
            this.lblNomEspece = new System.Windows.Forms.Label();
            this.lblOrigine = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblNbPlanete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEspece)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEspece
            // 
            this.pbEspece.Location = new System.Drawing.Point(54, 28);
            this.pbEspece.Name = "pbEspece";
            this.pbEspece.Size = new System.Drawing.Size(236, 225);
            this.pbEspece.TabIndex = 0;
            this.pbEspece.TabStop = false;
            // 
            // lblNomEspece
            // 
            this.lblNomEspece.AutoSize = true;
            this.lblNomEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEspece.Location = new System.Drawing.Point(47, 272);
            this.lblNomEspece.Name = "lblNomEspece";
            this.lblNomEspece.Size = new System.Drawing.Size(100, 37);
            this.lblNomEspece.TabIndex = 1;
            this.lblNomEspece.Text = "label1";
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigine.Location = new System.Drawing.Point(50, 400);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(58, 22);
            this.lblOrigine.TabIndex = 2;
            this.lblOrigine.Text = "label1";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.Location = new System.Drawing.Point(50, 320);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(58, 22);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "label1";
            // 
            // lblNbPlanete
            // 
            this.lblNbPlanete.AutoSize = true;
            this.lblNbPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPlanete.Location = new System.Drawing.Point(50, 367);
            this.lblNbPlanete.Name = "lblNbPlanete";
            this.lblNbPlanete.Size = new System.Drawing.Size(58, 22);
            this.lblNbPlanete.TabIndex = 4;
            this.lblNbPlanete.Text = "label1";
            // 
            // UserControlEspeces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNbPlanete);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblOrigine);
            this.Controls.Add(this.lblNomEspece);
            this.Controls.Add(this.pbEspece);
            this.Name = "UserControlEspeces";
            this.Size = new System.Drawing.Size(350, 466);
            this.Load += new System.EventHandler(this.UserControlEspeces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEspece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEspece;
        private System.Windows.Forms.Label lblNomEspece;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblNbPlanete;
    }
}
