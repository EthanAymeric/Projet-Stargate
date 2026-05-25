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
            this.pnlPlanetes = new System.Windows.Forms.Panel();
            this.pnlEspeces = new System.Windows.Forms.Panel();
            this.grpEspeces = new System.Windows.Forms.GroupBox();
            this.ckCouleur = new System.Windows.Forms.CheckBox();
            this.cboNom = new System.Windows.Forms.ComboBox();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rdbEnnemis = new System.Windows.Forms.RadioButton();
            this.rdbAllies = new System.Windows.Forms.RadioButton();
            this.pnlAllies = new System.Windows.Forms.Panel();
            this.pnlEnnemis = new System.Windows.Forms.Panel();
            this.ckNom = new System.Windows.Forms.CheckBox();
            this.pnlTDB.SuspendLayout();
            this.grpEspeces.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTDB
            // 
            this.btnTDB.Location = new System.Drawing.Point(15, 489);
            this.btnTDB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.btnNouvelleMission.Location = new System.Drawing.Point(244, 489);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.btnRaces.Location = new System.Drawing.Point(470, 489);
            this.btnRaces.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.btnPlanetes.Location = new System.Drawing.Point(704, 489);
            this.btnPlanetes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.pnlTDB.Location = new System.Drawing.Point(15, 15);
            this.pnlTDB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlTDB.Name = "pnlTDB";
            this.pnlTDB.Size = new System.Drawing.Size(872, 466);
            this.pnlTDB.TabIndex = 5;
            // 
            // pbChargement
            // 
            this.pbChargement.Location = new System.Drawing.Point(232, 180);
            this.pbChargement.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbChargement.Name = "pbChargement";
            this.pbChargement.Size = new System.Drawing.Size(408, 55);
            this.pbChargement.TabIndex = 0;
            // 
            // pnlPlanetes
            // 
            this.pnlPlanetes.AutoScroll = true;
            this.pnlPlanetes.Location = new System.Drawing.Point(15, 15);
            this.pnlPlanetes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlPlanetes.Name = "pnlPlanetes";
            this.pnlPlanetes.Size = new System.Drawing.Size(872, 466);
            this.pnlPlanetes.TabIndex = 6;
            // 
            // pnlEspeces
            // 
            this.pnlEspeces.AutoScroll = true;
            this.pnlEspeces.Location = new System.Drawing.Point(15, 15);
            this.pnlEspeces.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlEspeces.Name = "pnlEspeces";
            this.pnlEspeces.Size = new System.Drawing.Size(872, 348);
            this.pnlEspeces.TabIndex = 7;
            // 
            // grpEspeces
            // 
            this.grpEspeces.Controls.Add(this.ckNom);
            this.grpEspeces.Controls.Add(this.ckCouleur);
            this.grpEspeces.Controls.Add(this.cboNom);
            this.grpEspeces.Controls.Add(this.cboCouleur);
            this.grpEspeces.Controls.Add(this.btnRecherche);
            this.grpEspeces.Controls.Add(this.btnReset);
            this.grpEspeces.Controls.Add(this.rdbEnnemis);
            this.grpEspeces.Controls.Add(this.rdbAllies);
            this.grpEspeces.Location = new System.Drawing.Point(15, 368);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Size = new System.Drawing.Size(869, 114);
            this.grpEspeces.TabIndex = 0;
            this.grpEspeces.TabStop = false;
            this.grpEspeces.Text = "Recherche d\'espèces";
            // 
            // ckCouleur
            // 
            this.ckCouleur.AutoSize = true;
            this.ckCouleur.Location = new System.Drawing.Point(430, 69);
            this.ckCouleur.Name = "ckCouleur";
            this.ckCouleur.Size = new System.Drawing.Size(304, 24);
            this.ckCouleur.TabIndex = 6;
            this.ckCouleur.Text = "Appliquer la couleur dans la recherche";
            this.ckCouleur.UseVisualStyleBackColor = true;
            this.ckCouleur.CheckedChanged += new System.EventHandler(this.ckCouleur_CheckedChanged);
            // 
            // cboNom
            // 
            this.cboNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNom.FormattingEnabled = true;
            this.cboNom.Location = new System.Drawing.Point(229, 17);
            this.cboNom.Name = "cboNom";
            this.cboNom.Size = new System.Drawing.Size(182, 28);
            this.cboNom.TabIndex = 5;
            this.cboNom.SelectedIndexChanged += new System.EventHandler(this.cboNom_SelectedIndexChanged);
            // 
            // cboCouleur
            // 
            this.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(229, 67);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(182, 28);
            this.cboCouleur.TabIndex = 4;
            this.cboCouleur.SelectedIndexChanged += new System.EventHandler(this.cboCouleur_SelectedIndexChanged);
            this.cboCouleur.SelectedValueChanged += new System.EventHandler(this.cboCouleur_SelectedValueChanged);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(756, 17);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(107, 32);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(756, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 32);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdbEnnemis
            // 
            this.rdbEnnemis.AutoSize = true;
            this.rdbEnnemis.Location = new System.Drawing.Point(6, 68);
            this.rdbEnnemis.Name = "rdbEnnemis";
            this.rdbEnnemis.Size = new System.Drawing.Size(171, 24);
            this.rdbEnnemis.TabIndex = 1;
            this.rdbEnnemis.TabStop = true;
            this.rdbEnnemis.Text = "Espèces Ennemies";
            this.rdbEnnemis.UseVisualStyleBackColor = true;
            // 
            // rdbAllies
            // 
            this.rdbAllies.AutoSize = true;
            this.rdbAllies.Location = new System.Drawing.Point(6, 25);
            this.rdbAllies.Name = "rdbAllies";
            this.rdbAllies.Size = new System.Drawing.Size(146, 24);
            this.rdbAllies.TabIndex = 0;
            this.rdbAllies.TabStop = true;
            this.rdbAllies.Text = "Espèces Alliées";
            this.rdbAllies.UseVisualStyleBackColor = true;
            // 
            // pnlAllies
            // 
            this.pnlAllies.AutoScroll = true;
            this.pnlAllies.Location = new System.Drawing.Point(15, 15);
            this.pnlAllies.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlAllies.Name = "pnlAllies";
            this.pnlAllies.Size = new System.Drawing.Size(872, 348);
            this.pnlAllies.TabIndex = 8;
            // 
            // pnlEnnemis
            // 
            this.pnlEnnemis.AutoScroll = true;
            this.pnlEnnemis.Location = new System.Drawing.Point(15, 15);
            this.pnlEnnemis.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlEnnemis.Name = "pnlEnnemis";
            this.pnlEnnemis.Size = new System.Drawing.Size(872, 348);
            this.pnlEnnemis.TabIndex = 9;
            // 
            // ckNom
            // 
            this.ckNom.AutoSize = true;
            this.ckNom.Location = new System.Drawing.Point(430, 21);
            this.ckNom.Name = "ckNom";
            this.ckNom.Size = new System.Drawing.Size(283, 24);
            this.ckNom.TabIndex = 7;
            this.ckNom.Text = "Appliquer le nom dans la recherche";
            this.ckNom.UseVisualStyleBackColor = true;
            // 
            // FrmTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.grpEspeces);
            this.Controls.Add(this.pnlEnnemis);
            this.Controls.Add(this.pnlAllies);
            this.Controls.Add(this.pnlEspeces);
            this.Controls.Add(this.pnlPlanetes);
            this.Controls.Add(this.pnlTDB);
            this.Controls.Add(this.btnPlanetes);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.btnTDB);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmTableauDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de Bord";
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            this.Shown += new System.EventHandler(this.FrmTableauDeBord_Shown);
            this.pnlTDB.ResumeLayout(false);
            this.grpEspeces.ResumeLayout(false);
            this.grpEspeces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnPlanetes;
        private System.Windows.Forms.Panel pnlTDB;
        private System.Windows.Forms.ProgressBar pbChargement;
        private System.Windows.Forms.Panel pnlPlanetes;
        private System.Windows.Forms.Panel pnlEspeces;
        private System.Windows.Forms.GroupBox grpEspeces;
        private System.Windows.Forms.RadioButton rdbEnnemis;
        private System.Windows.Forms.RadioButton rdbAllies;
        private System.Windows.Forms.Panel pnlAllies;
        private System.Windows.Forms.Panel pnlEnnemis;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.ComboBox cboNom;
        private System.Windows.Forms.CheckBox ckCouleur;
        private System.Windows.Forms.CheckBox ckNom;
    }
}

