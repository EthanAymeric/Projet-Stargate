namespace SAE24
{
    partial class FrmTableauDeBord
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTDB = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnRaces = new System.Windows.Forms.Button();
            this.btnPlanetes = new System.Windows.Forms.Button();
            this.pnlTDB = new System.Windows.Forms.Panel();
            this.pbChargement = new System.Windows.Forms.ProgressBar();
            this.pnlTDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTDB
            // 
            this.btnTDB.Location = new System.Drawing.Point(15, 490);
            this.btnTDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTDB.Name = "btnTDB";
            this.btnTDB.Size = new System.Drawing.Size(182, 58);
            this.btnTDB.TabIndex = 1;
            this.btnTDB.Text = "Tableau de bord";
            this.btnTDB.UseVisualStyleBackColor = true;
            this.btnTDB.Visible = false;
            this.btnTDB.Click += new System.EventHandler(this.btnTDB_Click);
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.Location = new System.Drawing.Point(244, 490);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(182, 58);
            this.btnNouvelleMission.TabIndex = 2;
            this.btnNouvelleMission.Text = "Nouvelle Mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = true;
            this.btnNouvelleMission.Visible = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            // 
            // btnRaces
            // 
            this.btnRaces.Location = new System.Drawing.Point(470, 490);
            this.btnRaces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(182, 58);
            this.btnRaces.TabIndex = 3;
            this.btnRaces.Text = "Decouverte des races";
            this.btnRaces.UseVisualStyleBackColor = true;
            this.btnRaces.Visible = false;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // btnPlanetes
            // 
            this.btnPlanetes.Location = new System.Drawing.Point(704, 490);
            this.btnPlanetes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlanetes.Name = "btnPlanetes";
            this.btnPlanetes.Size = new System.Drawing.Size(182, 58);
            this.btnPlanetes.TabIndex = 4;
            this.btnPlanetes.Text = "Infos des planètes";
            this.btnPlanetes.UseVisualStyleBackColor = true;
            this.btnPlanetes.Visible = false;
            this.btnPlanetes.Click += new System.EventHandler(this.btnPlanetes_Click);
            // 
            // pnlTDB
            // 
            this.pnlTDB.AutoScroll = true;
            this.pnlTDB.Controls.Add(this.pbChargement);
            this.pnlTDB.Location = new System.Drawing.Point(15, 16);
            this.pnlTDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTDB.Name = "pnlTDB";
            this.pnlTDB.Size = new System.Drawing.Size(872, 466);
            this.pnlTDB.TabIndex = 5;
            // 
            // pbChargement
            // 
            this.pbChargement.Location = new System.Drawing.Point(232, 180);
            this.pbChargement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbChargement.Name = "pbChargement";
            this.pbChargement.Size = new System.Drawing.Size(408, 55);
            this.pbChargement.TabIndex = 0;
            // 
            // FrmTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.pnlTDB);
            this.Controls.Add(this.btnPlanetes);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.btnTDB);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTableauDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de Bord";
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            this.Shown += new System.EventHandler(this.FrmTableauDeBord_Shown);
            this.pnlTDB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnPlanetes;
        private System.Windows.Forms.Panel pnlTDB;
        private System.Windows.Forms.ProgressBar pbChargement;
    }
}

