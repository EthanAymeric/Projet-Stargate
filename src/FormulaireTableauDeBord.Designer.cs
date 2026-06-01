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
            this.pnlTDB = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSwitchTheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTDB
            // 
            this.btnTDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnTDB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTDB.FlatAppearance.BorderSize = 2;
            this.btnTDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTDB.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnTDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnTDB.Location = new System.Drawing.Point(12, 91);
            this.btnTDB.Name = "btnTDB";
            this.btnTDB.Size = new System.Drawing.Size(213, 72);
            this.btnTDB.TabIndex = 1;
            this.btnTDB.Text = "Tableau de bord";
            this.btnTDB.UseVisualStyleBackColor = false;
            this.btnTDB.Click += new System.EventHandler(this.btnTDB_Click);
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnNouvelleMission.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNouvelleMission.FlatAppearance.BorderSize = 2;
            this.btnNouvelleMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNouvelleMission.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnNouvelleMission.Location = new System.Drawing.Point(13, 188);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(213, 72);
            this.btnNouvelleMission.TabIndex = 2;
            this.btnNouvelleMission.Text = "Nouvelle Mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            // 
            // btnRaces
            // 
            this.btnRaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnRaces.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRaces.FlatAppearance.BorderSize = 2;
            this.btnRaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaces.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnRaces.Location = new System.Drawing.Point(13, 291);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(213, 72);
            this.btnRaces.TabIndex = 3;
            this.btnRaces.Text = "Decouverte des races";
            this.btnRaces.UseVisualStyleBackColor = false;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // btnPlanetes
            // 
            this.btnPlanetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnPlanetes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlanetes.FlatAppearance.BorderSize = 2;
            this.btnPlanetes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlanetes.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnPlanetes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnPlanetes.Location = new System.Drawing.Point(13, 403);
            this.btnPlanetes.Name = "btnPlanetes";
            this.btnPlanetes.Size = new System.Drawing.Size(213, 72);
            this.btnPlanetes.TabIndex = 4;
            this.btnPlanetes.Text = "Infos des planètes";
            this.btnPlanetes.UseVisualStyleBackColor = false;
            this.btnPlanetes.Click += new System.EventHandler(this.btnPlanetes_Click);
            // 
            // pnlTDB
            // 
            this.pnlTDB.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTDB.Location = new System.Drawing.Point(268, 88);
            this.pnlTDB.Name = "pnlTDB";
            this.pnlTDB.Size = new System.Drawing.Size(1206, 783);
            this.pnlTDB.TabIndex = 0;
            // 
            // btnSwitchTheme
            // 
            this.btnSwitchTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnSwitchTheme.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSwitchTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnSwitchTheme.Location = new System.Drawing.Point(1796, 12);
            this.btnSwitchTheme.Name = "btnSwitchTheme";
            this.btnSwitchTheme.Size = new System.Drawing.Size(97, 51);
            this.btnSwitchTheme.TabIndex = 5;
            this.btnSwitchTheme.Text = "Theme Sombre";
            this.btnSwitchTheme.UseVisualStyleBackColor = false;
            this.btnSwitchTheme.Click += new System.EventHandler(this.btnSwitchTheme_Click);
            // 
            // FrmTableauDeBord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1905, 1042);
            this.Controls.Add(this.btnSwitchTheme);
            this.Controls.Add(this.pnlTDB);
            this.Controls.Add(this.btnPlanetes);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.btnTDB);
            this.Name = "FrmTableauDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de Bord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnPlanetes;
        private System.Windows.Forms.FlowLayoutPanel pnlTDB;
        private System.Windows.Forms.Button btnSwitchTheme;
    }
}

