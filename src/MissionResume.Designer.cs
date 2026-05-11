namespace SAE24
{
    partial class MissionResume
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
            this.pbPlanete = new System.Windows.Forms.PictureBox();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.lblDateDeb = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlanete
            // 
            this.pbPlanete.Location = new System.Drawing.Point(13, 12);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(129, 126);
            this.pbPlanete.TabIndex = 0;
            this.pbPlanete.TabStop = false;
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Location = new System.Drawing.Point(160, 23);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(44, 16);
            this.lblNomMission.TabIndex = 1;
            this.lblNomMission.Text = "label1";
            this.lblNomMission.Visible = false;
            // 
            // lblDateDeb
            // 
            this.lblDateDeb.AutoSize = true;
            this.lblDateDeb.Location = new System.Drawing.Point(160, 63);
            this.lblDateDeb.Name = "lblDateDeb";
            this.lblDateDeb.Size = new System.Drawing.Size(44, 16);
            this.lblDateDeb.TabIndex = 2;
            this.lblDateDeb.Text = "label1";
            this.lblDateDeb.Visible = false;
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(312, 63);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(44, 16);
            this.lblDuree.TabIndex = 3;
            this.lblDuree.Text = "label1";
            this.lblDuree.Visible = false;
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.Location = new System.Drawing.Point(160, 104);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(44, 16);
            this.lblChef.TabIndex = 4;
            this.lblChef.Text = "label1";
            this.lblChef.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "label1";
            this.label4.Visible = false;
            // 
            // MissionResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblDateDeb);
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.pbPlanete);
            this.Name = "MissionResume";
            this.Size = new System.Drawing.Size(549, 148);
            this.Load += new System.EventHandler(this.MissionResume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblDateDeb;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label label4;
    }
}
