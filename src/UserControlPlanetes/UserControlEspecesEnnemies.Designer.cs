namespace UserControlPlanetes
{
    partial class UserControlEspecesEnnemies
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
            this.pbEspeceEnnemie = new System.Windows.Forms.PictureBox();
            this.lblNomEspeceEnnemie = new System.Windows.Forms.Label();
            this.lblNbPlanete = new System.Windows.Forms.Label();
            this.lblOrigine = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblArme = new System.Windows.Forms.Label();
            this.lblAgressivite = new System.Windows.Forms.Label();
            this.lblArmeCommun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEspeceEnnemie)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEspeceEnnemie
            // 
            this.pbEspeceEnnemie.Location = new System.Drawing.Point(54, 16);
            this.pbEspeceEnnemie.Name = "pbEspeceEnnemie";
            this.pbEspeceEnnemie.Size = new System.Drawing.Size(240, 213);
            this.pbEspeceEnnemie.TabIndex = 1;
            this.pbEspeceEnnemie.TabStop = false;
            // 
            // lblNomEspeceEnnemie
            // 
            this.lblNomEspeceEnnemie.AutoSize = true;
            this.lblNomEspeceEnnemie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEspeceEnnemie.Location = new System.Drawing.Point(47, 249);
            this.lblNomEspeceEnnemie.Name = "lblNomEspeceEnnemie";
            this.lblNomEspeceEnnemie.Size = new System.Drawing.Size(118, 37);
            this.lblNomEspeceEnnemie.TabIndex = 2;
            this.lblNomEspeceEnnemie.Text = "<nom>";
            // 
            // lblNbPlanete
            // 
            this.lblNbPlanete.AutoSize = true;
            this.lblNbPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPlanete.Location = new System.Drawing.Point(50, 286);
            this.lblNbPlanete.Name = "lblNbPlanete";
            this.lblNbPlanete.Size = new System.Drawing.Size(154, 22);
            this.lblNbPlanete.TabIndex = 3;
            this.lblNbPlanete.Text = "Planète d\'origine :";
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigine.Location = new System.Drawing.Point(50, 308);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(247, 22);
            this.lblOrigine.TabIndex = 4;
            this.lblOrigine.Text = "<nom de la planète d\'origine>";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.Location = new System.Drawing.Point(50, 340);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(91, 22);
            this.lblCouleur.TabIndex = 5;
            this.lblCouleur.Text = "<couleur>";
            // 
            // lblArme
            // 
            this.lblArme.AutoSize = true;
            this.lblArme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArme.Location = new System.Drawing.Point(50, 445);
            this.lblArme.Name = "lblArme";
            this.lblArme.Size = new System.Drawing.Size(125, 22);
            this.lblArme.TabIndex = 6;
            this.lblArme.Text = "<type d\'arme>";
            this.lblArme.Click += new System.EventHandler(this.lblArme_Click);
            // 
            // lblAgressivite
            // 
            this.lblAgressivite.AutoSize = true;
            this.lblAgressivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgressivite.Location = new System.Drawing.Point(231, 379);
            this.lblAgressivite.Name = "lblAgressivite";
            this.lblAgressivite.Size = new System.Drawing.Size(78, 22);
            this.lblAgressivite.TabIndex = 7;
            this.lblAgressivite.Text = "<degré>";
            // 
            // lblArmeCommun
            // 
            this.lblArmeCommun.AutoSize = true;
            this.lblArmeCommun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmeCommun.Location = new System.Drawing.Point(50, 423);
            this.lblArmeCommun.Name = "lblArmeCommun";
            this.lblArmeCommun.Size = new System.Drawing.Size(120, 22);
            this.lblArmeCommun.TabIndex = 8;
            this.lblArmeCommun.Text = "Type d\'arme :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Degré d\'Aggressivité :";
            // 
            // UserControlEspecesEnnemies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArmeCommun);
            this.Controls.Add(this.lblAgressivite);
            this.Controls.Add(this.lblArme);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblOrigine);
            this.Controls.Add(this.lblNbPlanete);
            this.Controls.Add(this.lblNomEspeceEnnemie);
            this.Controls.Add(this.pbEspeceEnnemie);
            this.Name = "UserControlEspecesEnnemies";
            this.Size = new System.Drawing.Size(354, 494);
            ((System.ComponentModel.ISupportInitialize)(this.pbEspeceEnnemie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEspeceEnnemie;
        private System.Windows.Forms.Label lblNomEspeceEnnemie;
        private System.Windows.Forms.Label lblNbPlanete;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblArme;
        private System.Windows.Forms.Label lblAgressivite;
        private System.Windows.Forms.Label lblArmeCommun;
        private System.Windows.Forms.Label label1;
    }
}
