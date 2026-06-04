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
            this.lblIndicationCouleur = new System.Windows.Forms.Label();
            this.lblIndicationPlanete = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.lblIndicationNom = new System.Windows.Forms.Label();
            this.txtNomEspece = new System.Windows.Forms.TextBox();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rdbEnnemis = new System.Windows.Forms.RadioButton();
            this.rdbAllies = new System.Windows.Forms.RadioButton();
            this.pnlAllies = new System.Windows.Forms.Panel();
            this.pnlEnnemis = new System.Windows.Forms.Panel();
            this.btnStats = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.cboStats2 = new System.Windows.Forms.ComboBox();
            this.cboStats1 = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTDB.SuspendLayout();
            this.grpEspeces.SuspendLayout();
            this.pnlStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTDB
            // 
            this.btnTDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTDB.Location = new System.Drawing.Point(33, 144);
            this.btnTDB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTDB.Name = "btnTDB";
            this.btnTDB.Size = new System.Drawing.Size(145, 43);
            this.btnTDB.TabIndex = 1;
            this.btnTDB.Text = "Tableau de bord";
            this.btnTDB.UseVisualStyleBackColor = true;
            this.btnTDB.Visible = false;
            this.btnTDB.Click += new System.EventHandler(this.btnTDB_Click);
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouvelleMission.Location = new System.Drawing.Point(33, 504);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(145, 43);
            this.btnNouvelleMission.TabIndex = 2;
            this.btnNouvelleMission.Text = "Nouvelle Mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = true;
            this.btnNouvelleMission.Visible = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            // 
            // btnRaces
            // 
            this.btnRaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaces.Location = new System.Drawing.Point(33, 236);
            this.btnRaces.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(145, 43);
            this.btnRaces.TabIndex = 3;
            this.btnRaces.Text = "Decouverte des races";
            this.btnRaces.UseVisualStyleBackColor = true;
            this.btnRaces.Visible = false;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // btnPlanetes
            // 
            this.btnPlanetes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanetes.Location = new System.Drawing.Point(33, 322);
            this.btnPlanetes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPlanetes.Name = "btnPlanetes";
            this.btnPlanetes.Size = new System.Drawing.Size(145, 43);
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
            this.pnlTDB.Location = new System.Drawing.Point(223, 142);
            this.pnlTDB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlTDB.Name = "pnlTDB";
            this.pnlTDB.Size = new System.Drawing.Size(950, 477);
            this.pnlTDB.TabIndex = 5;
            // 
            // pbChargement
            // 
            this.pbChargement.Location = new System.Drawing.Point(155, 117);
            this.pbChargement.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbChargement.Name = "pbChargement";
            this.pbChargement.Size = new System.Drawing.Size(272, 36);
            this.pbChargement.TabIndex = 0;
            // 
            // pnlPlanetes
            // 
            this.pnlPlanetes.AutoScroll = true;
            this.pnlPlanetes.Location = new System.Drawing.Point(223, 142);
            this.pnlPlanetes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlPlanetes.Name = "pnlPlanetes";
            this.pnlPlanetes.Size = new System.Drawing.Size(950, 477);
            this.pnlPlanetes.TabIndex = 6;
            // 
            // pnlEspeces
            // 
            this.pnlEspeces.AutoScroll = true;
            this.pnlEspeces.Location = new System.Drawing.Point(452, 142);
            this.pnlEspeces.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlEspeces.Name = "pnlEspeces";
            this.pnlEspeces.Size = new System.Drawing.Size(721, 477);
            this.pnlEspeces.TabIndex = 7;
            // 
            // grpEspeces
            // 
            this.grpEspeces.Controls.Add(this.lblIndicationCouleur);
            this.grpEspeces.Controls.Add(this.lblIndicationPlanete);
            this.grpEspeces.Controls.Add(this.cboPlanete);
            this.grpEspeces.Controls.Add(this.lblIndicationNom);
            this.grpEspeces.Controls.Add(this.txtNomEspece);
            this.grpEspeces.Controls.Add(this.cboCouleur);
            this.grpEspeces.Controls.Add(this.btnRecherche);
            this.grpEspeces.Controls.Add(this.btnReset);
            this.grpEspeces.Controls.Add(this.rdbEnnemis);
            this.grpEspeces.Controls.Add(this.rdbAllies);
            this.grpEspeces.Location = new System.Drawing.Point(221, 144);
            this.grpEspeces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEspeces.Size = new System.Drawing.Size(223, 475);
            this.grpEspeces.TabIndex = 0;
            this.grpEspeces.TabStop = false;
            this.grpEspeces.Text = "Recherche d\'espèces";
            // 
            // lblIndicationCouleur
            // 
            this.lblIndicationCouleur.AutoSize = true;
            this.lblIndicationCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicationCouleur.Location = new System.Drawing.Point(168, 157);
            this.lblIndicationCouleur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndicationCouleur.Name = "lblIndicationCouleur";
            this.lblIndicationCouleur.Size = new System.Drawing.Size(81, 25);
            this.lblIndicationCouleur.TabIndex = 11;
            this.lblIndicationCouleur.Text = "Couleur";
            // 
            // lblIndicationPlanete
            // 
            this.lblIndicationPlanete.AutoSize = true;
            this.lblIndicationPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicationPlanete.Location = new System.Drawing.Point(168, 125);
            this.lblIndicationPlanete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndicationPlanete.Name = "lblIndicationPlanete";
            this.lblIndicationPlanete.Size = new System.Drawing.Size(78, 25);
            this.lblIndicationPlanete.TabIndex = 10;
            this.lblIndicationPlanete.Text = "Planète";
            // 
            // cboPlanete
            // 
            this.cboPlanete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(16, 123);
            this.cboPlanete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(149, 33);
            this.cboPlanete.TabIndex = 9;
            this.cboPlanete.SelectedIndexChanged += new System.EventHandler(this.cboPlanete_SelectedIndexChanged);
            // 
            // lblIndicationNom
            // 
            this.lblIndicationNom.AutoSize = true;
            this.lblIndicationNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicationNom.Location = new System.Drawing.Point(168, 92);
            this.lblIndicationNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndicationNom.Name = "lblIndicationNom";
            this.lblIndicationNom.Size = new System.Drawing.Size(53, 25);
            this.lblIndicationNom.TabIndex = 8;
            this.lblIndicationNom.Text = "Nom";
            // 
            // txtNomEspece
            // 
            this.txtNomEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEspece.Location = new System.Drawing.Point(16, 92);
            this.txtNomEspece.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomEspece.Name = "txtNomEspece";
            this.txtNomEspece.Size = new System.Drawing.Size(149, 30);
            this.txtNomEspece.TabIndex = 7;
            this.txtNomEspece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEspece_KeyPress);
            // 
            // cboCouleur
            // 
            this.cboCouleur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(16, 156);
            this.cboCouleur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(149, 33);
            this.cboCouleur.TabIndex = 4;
            this.cboCouleur.SelectedIndexChanged += new System.EventHandler(this.cboCouleur_SelectedIndexChanged);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecherche.Location = new System.Drawing.Point(28, 224);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(160, 45);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(28, 292);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdbEnnemis
            // 
            this.rdbEnnemis.AutoSize = true;
            this.rdbEnnemis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEnnemis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnnemis.Location = new System.Drawing.Point(16, 55);
            this.rdbEnnemis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbEnnemis.Name = "rdbEnnemis";
            this.rdbEnnemis.Size = new System.Drawing.Size(205, 29);
            this.rdbEnnemis.TabIndex = 1;
            this.rdbEnnemis.TabStop = true;
            this.rdbEnnemis.Text = "Espèces Ennemies";
            this.rdbEnnemis.UseVisualStyleBackColor = true;
            // 
            // rdbAllies
            // 
            this.rdbAllies.AutoSize = true;
            this.rdbAllies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAllies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAllies.Location = new System.Drawing.Point(16, 32);
            this.rdbAllies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbAllies.Name = "rdbAllies";
            this.rdbAllies.Size = new System.Drawing.Size(176, 29);
            this.rdbAllies.TabIndex = 0;
            this.rdbAllies.TabStop = true;
            this.rdbAllies.Text = "Espèces Alliées";
            this.rdbAllies.UseVisualStyleBackColor = true;
            // 
            // pnlAllies
            // 
            this.pnlAllies.AutoScroll = true;
            this.pnlAllies.Location = new System.Drawing.Point(452, 142);
            this.pnlAllies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlAllies.Name = "pnlAllies";
            this.pnlAllies.Size = new System.Drawing.Size(721, 477);
            this.pnlAllies.TabIndex = 8;
            // 
            // pnlEnnemis
            // 
            this.pnlEnnemis.AutoScroll = true;
            this.pnlEnnemis.Location = new System.Drawing.Point(452, 142);
            this.pnlEnnemis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlEnnemis.Name = "pnlEnnemis";
            this.pnlEnnemis.Size = new System.Drawing.Size(721, 477);
            this.pnlEnnemis.TabIndex = 9;
            // 
            // btnStats
            // 
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.Location = new System.Drawing.Point(33, 405);
            this.btnStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(145, 43);
            this.btnStats.TabIndex = 10;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Visible = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.AutoScroll = true;
            this.pnlStats.Controls.Add(this.cboStats2);
            this.pnlStats.Controls.Add(this.cboStats1);
            this.pnlStats.Location = new System.Drawing.Point(223, 142);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(950, 477);
            this.pnlStats.TabIndex = 7;
            // 
            // cboStats2
            // 
            this.cboStats2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStats2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStats2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStats2.FormattingEnabled = true;
            this.cboStats2.Location = new System.Drawing.Point(13, 1181);
            this.cboStats2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStats2.Name = "cboStats2";
            this.cboStats2.Size = new System.Drawing.Size(240, 34);
            this.cboStats2.TabIndex = 2;
            this.cboStats2.SelectedIndexChanged += new System.EventHandler(this.cboStats2_SelectedIndexChanged);
            // 
            // cboStats1
            // 
            this.cboStats1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStats1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStats1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStats1.FormattingEnabled = true;
            this.cboStats1.Location = new System.Drawing.Point(13, 169);
            this.cboStats1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStats1.Name = "cboStats1";
            this.cboStats1.Size = new System.Drawing.Size(240, 34);
            this.cboStats1.TabIndex = 1;
            this.cboStats1.SelectedIndexChanged += new System.EventHandler(this.cboStats1_SelectedIndexChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(33, 8);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(267, 117);
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // FrmTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 679);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.grpEspeces);
            this.Controls.Add(this.pnlEnnemis);
            this.Controls.Add(this.pnlAllies);
            this.Controls.Add(this.pnlEspeces);
            this.Controls.Add(this.pnlPlanetes);
            this.Controls.Add(this.pnlTDB);
            this.Controls.Add(this.btnPlanetes);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnTDB);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmTableauDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de Bord";
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            this.Shown += new System.EventHandler(this.FrmTableauDeBord_Shown);
            this.pnlTDB.ResumeLayout(false);
            this.grpEspeces.ResumeLayout(false);
            this.grpEspeces.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private System.Windows.Forms.TextBox txtNomEspece;
        private System.Windows.Forms.Label lblIndicationNom;
        private System.Windows.Forms.Label lblIndicationPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Label lblIndicationCouleur;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.ComboBox cboStats1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cboStats2;
    }
}

