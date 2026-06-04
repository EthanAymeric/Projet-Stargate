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
            this.pbChargement = new System.Windows.Forms.ProgressBar();
            this.pnlPlanetes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEspeces = new System.Windows.Forms.FlowLayoutPanel();
            this.grpEspeces = new System.Windows.Forms.GroupBox();
            this.lblIndicationNom = new System.Windows.Forms.Label();
            this.txtNomEspece = new System.Windows.Forms.TextBox();
            this.ckCouleur = new System.Windows.Forms.CheckBox();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rdbEnnemis = new System.Windows.Forms.RadioButton();
            this.rdbAllies = new System.Windows.Forms.RadioButton();
            this.pnlAllies = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEnnemis = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTDB = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSwitchTheme = new System.Windows.Forms.Button();
            this.grpEspeces.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTDB
            // 
            this.btnTDB.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnNouvelleMission.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnRaces.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnPlanetes.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.pnlPlanetes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlPlanetes.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlPlanetes.Location = new System.Drawing.Point(268, 89);
            this.pnlPlanetes.Name = "pnlPlanetes";
            this.pnlPlanetes.Size = new System.Drawing.Size(1418, 567);
            this.pnlPlanetes.TabIndex = 6;
            this.pnlPlanetes.WrapContents = false;
            // 
            // pnlEspeces
            // 
            this.pnlEspeces.AutoScroll = true;
            this.pnlEspeces.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlEspeces.Location = new System.Drawing.Point(268, 88);
            this.pnlEspeces.Name = "pnlEspeces";
            this.pnlEspeces.Size = new System.Drawing.Size(1418, 568);
            this.pnlEspeces.TabIndex = 7;
            // 
            // grpEspeces
            // 
            this.grpEspeces.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpEspeces.Controls.Add(this.lblIndicationNom);
            this.grpEspeces.Controls.Add(this.txtNomEspece);
            this.grpEspeces.Controls.Add(this.ckCouleur);
            this.grpEspeces.Controls.Add(this.cboCouleur);
            this.grpEspeces.Controls.Add(this.btnRecherche);
            this.grpEspeces.Controls.Add(this.btnReset);
            this.grpEspeces.Controls.Add(this.rdbEnnemis);
            this.grpEspeces.Controls.Add(this.rdbAllies);
            this.grpEspeces.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grpEspeces.Location = new System.Drawing.Point(268, 630);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Size = new System.Drawing.Size(1418, 240);
            this.grpEspeces.TabIndex = 0;
            this.grpEspeces.TabStop = false;
            this.grpEspeces.Text = "Recherche d\'espèces";
            // 
            // lblIndicationNom
            // 
            this.lblIndicationNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIndicationNom.AutoSize = true;
            this.lblIndicationNom.Location = new System.Drawing.Point(548, 51);
            this.lblIndicationNom.Name = "lblIndicationNom";
            this.lblIndicationNom.Size = new System.Drawing.Size(243, 20);
            this.lblIndicationNom.TabIndex = 8;
            this.lblIndicationNom.Text = "Nom de l\'espèce recherchée";
            // 
            // txtNomEspece
            // 
            this.txtNomEspece.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNomEspece.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtNomEspece.Location = new System.Drawing.Point(276, 52);
            this.txtNomEspece.Name = "txtNomEspece";
            this.txtNomEspece.Size = new System.Drawing.Size(222, 21);
            this.txtNomEspece.TabIndex = 7;
            this.txtNomEspece.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNomEspece_MouseClick);
            this.txtNomEspece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEspece_KeyPress);
            // 
            // ckCouleur
            // 
            this.ckCouleur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckCouleur.AutoSize = true;
            this.ckCouleur.Location = new System.Drawing.Point(552, 146);
            this.ckCouleur.Name = "ckCouleur";
            this.ckCouleur.Size = new System.Drawing.Size(370, 24);
            this.ckCouleur.TabIndex = 6;
            this.ckCouleur.Text = "Appliquer la couleur dans la recherche";
            this.ckCouleur.UseVisualStyleBackColor = true;
            this.ckCouleur.CheckedChanged += new System.EventHandler(this.ckCouleur_CheckedChanged);
            // 
            // cboCouleur
            // 
            this.cboCouleur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCouleur.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(276, 145);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(222, 24);
            this.cboCouleur.TabIndex = 4;
            this.cboCouleur.SelectedIndexChanged += new System.EventHandler(this.cboCouleur_SelectedIndexChanged);
            this.cboCouleur.SelectedValueChanged += new System.EventHandler(this.cboCouleur_SelectedValueChanged);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecherche.Location = new System.Drawing.Point(1164, 38);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(157, 48);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(1164, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 52);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdbEnnemis
            // 
            this.rdbEnnemis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdbEnnemis.AutoSize = true;
            this.rdbEnnemis.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rdbEnnemis.Location = new System.Drawing.Point(24, 145);
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
            this.rdbAllies.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rdbAllies.Location = new System.Drawing.Point(24, 49);
            this.rdbAllies.Name = "rdbAllies";
            this.rdbAllies.Size = new System.Drawing.Size(162, 24);
            this.rdbAllies.TabIndex = 0;
            this.rdbAllies.TabStop = true;
            this.rdbAllies.Text = "Espèces Alliées";
            this.rdbAllies.UseVisualStyleBackColor = true;
            // 
            // pnlAllies
            // 
            this.pnlAllies.AutoScroll = true;
            this.pnlAllies.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlAllies.Location = new System.Drawing.Point(268, 88);
            this.pnlAllies.Name = "pnlAllies";
            this.pnlAllies.Size = new System.Drawing.Size(1418, 544);
            this.pnlAllies.TabIndex = 8;
            // 
            // pnlEnnemis
            // 
            this.pnlEnnemis.AutoScroll = true;
            this.pnlEnnemis.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlEnnemis.Location = new System.Drawing.Point(268, 88);
            this.pnlEnnemis.Name = "pnlEnnemis";
            this.pnlEnnemis.Size = new System.Drawing.Size(1418, 544);
            this.pnlEnnemis.TabIndex = 9;
            // 
            // pnlTDB
            // 
            this.pnlTDB.AutoScroll = true;
            this.pnlTDB.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTDB.Location = new System.Drawing.Point(268, 88);
            this.pnlTDB.Name = "pnlTDB";
            this.pnlTDB.Size = new System.Drawing.Size(1418, 783);
            this.pnlTDB.TabIndex = 0;
            this.pnlTDB.WrapContents = false;
            // 
            // btnSwitchTheme
            // 
            this.btnSwitchTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnSwitchTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.grpEspeces);
            this.Controls.Add(this.pnlPlanetes);
            this.Controls.Add(this.pnlEnnemis);
            this.Controls.Add(this.pnlTDB);
            this.Controls.Add(this.pnlAllies);
            this.Controls.Add(this.pnlEspeces);
            this.Controls.Add(this.btnSwitchTheme);
            this.Controls.Add(this.btnPlanetes);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.btnTDB);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmTableauDeBord";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de Bord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            this.grpEspeces.ResumeLayout(false);
            this.grpEspeces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnPlanetes;
        private System.Windows.Forms.ProgressBar pbChargement;
        private System.Windows.Forms.GroupBox grpEspeces;
        private System.Windows.Forms.RadioButton rdbEnnemis;
        private System.Windows.Forms.RadioButton rdbAllies;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.CheckBox ckCouleur;
        private System.Windows.Forms.TextBox txtNomEspece;
        private System.Windows.Forms.Label lblIndicationNom;
        private System.Windows.Forms.FlowLayoutPanel pnlTDB;
        private System.Windows.Forms.Button btnSwitchTheme;
        private System.Windows.Forms.FlowLayoutPanel pnlPlanetes;
        private System.Windows.Forms.FlowLayoutPanel pnlEspeces;
        private System.Windows.Forms.FlowLayoutPanel pnlAllies;
        private System.Windows.Forms.FlowLayoutPanel pnlEnnemis;
    }
}

