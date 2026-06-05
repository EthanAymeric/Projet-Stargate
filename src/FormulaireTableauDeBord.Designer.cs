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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTDB = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnRaces = new System.Windows.Forms.Button();
            this.btnPlanetes = new System.Windows.Forms.Button();
            this.pnlPlanetes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEspeces = new System.Windows.Forms.FlowLayoutPanel();
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
            this.pnlAllies = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEnnemis = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTDB = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSwitchTheme = new System.Windows.Forms.Button();
            this.grpFiltreMission = new System.Windows.Forms.GroupBox();
            this.btntriAlpha = new System.Windows.Forms.Button();
            this.btntriEtat = new System.Windows.Forms.Button();
            this.cboFiltreEtat = new System.Windows.Forms.ComboBox();
            this.lblFiltreEtat = new System.Windows.Forms.Label();
            this.lblFiltrePlanete = new System.Windows.Forms.Label();
            this.cboFiltrePlanete = new System.Windows.Forms.ComboBox();
            this.grpTableauDeBord = new System.Windows.Forms.GroupBox();
            this.btnStats = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.cboStatsInformateurMission = new System.Windows.Forms.ComboBox();
            this.cboStats1 = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dgvStatsMembrePartage = new System.Windows.Forms.DataGridView();
            this.lblMembreMemeMission = new System.Windows.Forms.Label();
            this.lblStatsMissionBudget = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStatsMissionBudget = new System.Windows.Forms.DataGridView();
            this.dgvMissionParPlanete = new System.Windows.Forms.DataGridView();
            this.dgvDepenseParMission = new System.Windows.Forms.DataGridView();
            this.lblStatsInformateur = new System.Windows.Forms.Label();
            this.lblStatsInformateurResultat = new System.Windows.Forms.Label();
            this.grpEspeces.SuspendLayout();
            this.grpFiltreMission.SuspendLayout();
            this.grpTableauDeBord.SuspendLayout();
            this.pnlStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsMembrePartage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsMissionBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionParPlanete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenseParMission)).BeginInit();
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
            this.btnTDB.Location = new System.Drawing.Point(12, 328);
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
            this.btnNouvelleMission.Location = new System.Drawing.Point(12, 12);
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
            this.btnRaces.Location = new System.Drawing.Point(12, 552);
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
            this.btnPlanetes.Location = new System.Drawing.Point(12, 664);
            this.btnPlanetes.Name = "btnPlanetes";
            this.btnPlanetes.Size = new System.Drawing.Size(213, 72);
            this.btnPlanetes.TabIndex = 4;
            this.btnPlanetes.Text = "Infos des planètes";
            this.btnPlanetes.UseVisualStyleBackColor = false;
            this.btnPlanetes.Click += new System.EventHandler(this.btnPlanetes_Click);
            // 
            // pnlPlanetes
            // 
            this.pnlPlanetes.AutoScroll = true;
            this.pnlPlanetes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlPlanetes.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlPlanetes.Location = new System.Drawing.Point(268, 89);
            this.pnlPlanetes.Name = "pnlPlanetes";
            this.pnlPlanetes.Size = new System.Drawing.Size(1418, 850);
            this.pnlPlanetes.TabIndex = 6;
            this.pnlPlanetes.WrapContents = false;
            // 
            // pnlEspeces
            // 
            this.pnlEspeces.AutoScroll = true;
            this.pnlEspeces.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlEspeces.Location = new System.Drawing.Point(268, 88);
            this.pnlEspeces.Name = "pnlEspeces";
            this.pnlEspeces.Size = new System.Drawing.Size(1418, 605);
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
            this.grpEspeces.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grpEspeces.Location = new System.Drawing.Point(268, 699);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Size = new System.Drawing.Size(1412, 240);
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
            this.lblIndicationCouleur.Size = new System.Drawing.Size(57, 17);
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
            this.lblIndicationPlanete.Size = new System.Drawing.Size(56, 17);
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
            this.cboPlanete.Margin = new System.Windows.Forms.Padding(2);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(149, 24);
            this.cboPlanete.TabIndex = 9;
            this.cboPlanete.SelectedIndexChanged += new System.EventHandler(this.cboPlanete_SelectedIndexChanged);
            // 
            // lblIndicationNom
            // 
            this.lblIndicationNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIndicationNom.AutoSize = true;
            this.lblIndicationNom.Location = new System.Drawing.Point(542, 51);
            this.lblIndicationNom.Name = "lblIndicationNom";
            this.lblIndicationNom.Size = new System.Drawing.Size(36, 20);
            this.lblIndicationNom.TabIndex = 8;
            this.lblIndicationNom.Text = "Nom";
            // 
            // txtNomEspece
            // 
            this.txtNomEspece.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNomEspece.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtNomEspece.Location = new System.Drawing.Point(273, 52);
            this.txtNomEspece.Name = "txtNomEspece";
            this.txtNomEspece.Size = new System.Drawing.Size(222, 21);
            this.txtNomEspece.TabIndex = 7;
            this.txtNomEspece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEspece_KeyPress);
            // 
            // cboCouleur
            // 
            this.cboCouleur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCouleur.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(13, 156);
            this.cboCouleur.Margin = new System.Windows.Forms.Padding(2);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(222, 24);
            this.cboCouleur.TabIndex = 4;
            this.cboCouleur.SelectedIndexChanged += new System.EventHandler(this.cboCouleur_SelectedIndexChanged);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherche.Location = new System.Drawing.Point(1158, 38);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(160, 45);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(1158, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 45);
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
            this.rdbEnnemis.Location = new System.Drawing.Point(16, 55);
            this.rdbEnnemis.Margin = new System.Windows.Forms.Padding(2);
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
            this.rdbAllies.Location = new System.Drawing.Point(16, 32);
            this.rdbAllies.Margin = new System.Windows.Forms.Padding(2);
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
            this.pnlAllies.Size = new System.Drawing.Size(1418, 605);
            this.pnlAllies.TabIndex = 8;
            // 
            // pnlEnnemis
            // 
            this.pnlEnnemis.AutoScroll = true;
            this.pnlEnnemis.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlEnnemis.Location = new System.Drawing.Point(268, 88);
            this.pnlEnnemis.Name = "pnlEnnemis";
            this.pnlEnnemis.Size = new System.Drawing.Size(1418, 605);
            this.pnlEnnemis.TabIndex = 9;
            // 
            // pnlTDB
            // 
            this.pnlTDB.AutoScroll = true;
            this.pnlTDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTDB.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTDB.Location = new System.Drawing.Point(6, 30);
            this.pnlTDB.MaximumSize = new System.Drawing.Size(1418, 783);
            this.pnlTDB.Name = "pnlTDB";
            this.pnlTDB.Size = new System.Drawing.Size(1406, 643);
            this.pnlTDB.TabIndex = 0;
            this.pnlTDB.WrapContents = false;
            // 
            // btnSwitchTheme
            // 
            this.btnSwitchTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitchTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnSwitchTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchTheme.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSwitchTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnSwitchTheme.Location = new System.Drawing.Point(1679, 12);
            this.btnSwitchTheme.Name = "btnSwitchTheme";
            this.btnSwitchTheme.Size = new System.Drawing.Size(213, 72);
            this.btnSwitchTheme.TabIndex = 5;
            this.btnSwitchTheme.Text = "Theme Sombre";
            this.btnSwitchTheme.UseVisualStyleBackColor = false;
            this.btnSwitchTheme.Click += new System.EventHandler(this.btnSwitchTheme_Click);
            // 
            // grpFiltreMission
            // 
            this.grpFiltreMission.Controls.Add(this.btntriAlpha);
            this.grpFiltreMission.Controls.Add(this.btntriEtat);
            this.grpFiltreMission.Controls.Add(this.cboFiltreEtat);
            this.grpFiltreMission.Controls.Add(this.lblFiltreEtat);
            this.grpFiltreMission.Controls.Add(this.lblFiltrePlanete);
            this.grpFiltreMission.Controls.Add(this.cboFiltrePlanete);
            this.grpFiltreMission.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grpFiltreMission.Location = new System.Drawing.Point(268, 87);
            this.grpFiltreMission.Name = "grpFiltreMission";
            this.grpFiltreMission.Size = new System.Drawing.Size(1418, 173);
            this.grpFiltreMission.TabIndex = 0;
            this.grpFiltreMission.TabStop = false;
            this.grpFiltreMission.Text = "Filtre de missions";
            // 
            // btntriAlpha
            // 
            this.btntriAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntriAlpha.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntriAlpha.Location = new System.Drawing.Point(1253, 100);
            this.btntriAlpha.Name = "btntriAlpha";
            this.btntriAlpha.Size = new System.Drawing.Size(118, 62);
            this.btntriAlpha.TabIndex = 4;
            this.btntriAlpha.Text = "A → Z";
            this.btntriAlpha.UseVisualStyleBackColor = true;
            this.btntriAlpha.Click += new System.EventHandler(this.btntriAlpha_Click);
            // 
            // btntriEtat
            // 
            this.btntriEtat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntriEtat.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntriEtat.Location = new System.Drawing.Point(1253, 20);
            this.btntriEtat.Name = "btntriEtat";
            this.btntriEtat.Size = new System.Drawing.Size(118, 62);
            this.btntriEtat.TabIndex = 5;
            this.btntriEtat.Text = "Etat ✖";
            this.btntriEtat.UseVisualStyleBackColor = true;
            this.btntriEtat.Click += new System.EventHandler(this.btntriEtat_Click);
            // 
            // cboFiltreEtat
            // 
            this.cboFiltreEtat.FormattingEnabled = true;
            this.cboFiltreEtat.Items.AddRange(new object[] {
            "",
            "En cours",
            "Terminée"});
            this.cboFiltreEtat.Location = new System.Drawing.Point(320, 115);
            this.cboFiltreEtat.Name = "cboFiltreEtat";
            this.cboFiltreEtat.Size = new System.Drawing.Size(121, 35);
            this.cboFiltreEtat.TabIndex = 3;
            this.cboFiltreEtat.SelectedIndexChanged += new System.EventHandler(this.cboFiltrePlanete_SelectedIndexChanged);
            // 
            // lblFiltreEtat
            // 
            this.lblFiltreEtat.AutoSize = true;
            this.lblFiltreEtat.Location = new System.Drawing.Point(24, 118);
            this.lblFiltreEtat.Name = "lblFiltreEtat";
            this.lblFiltreEtat.Size = new System.Drawing.Size(252, 27);
            this.lblFiltreEtat.TabIndex = 2;
            this.lblFiltreEtat.Text = "Etat de la mission :";
            // 
            // lblFiltrePlanete
            // 
            this.lblFiltrePlanete.AutoSize = true;
            this.lblFiltrePlanete.Location = new System.Drawing.Point(19, 47);
            this.lblFiltrePlanete.Name = "lblFiltrePlanete";
            this.lblFiltrePlanete.Size = new System.Drawing.Size(120, 27);
            this.lblFiltrePlanete.TabIndex = 1;
            this.lblFiltrePlanete.Text = "Planète :";
            // 
            // cboFiltrePlanete
            // 
            this.cboFiltrePlanete.FormattingEnabled = true;
            this.cboFiltrePlanete.Location = new System.Drawing.Point(320, 44);
            this.cboFiltrePlanete.Name = "cboFiltrePlanete";
            this.cboFiltrePlanete.Size = new System.Drawing.Size(196, 35);
            this.cboFiltrePlanete.TabIndex = 0;
            this.cboFiltrePlanete.SelectedIndexChanged += new System.EventHandler(this.cboFiltrePlanete_SelectedIndexChanged);
            // 
            // grpTableauDeBord
            // 
            this.grpTableauDeBord.Controls.Add(this.pnlTDB);
            this.grpTableauDeBord.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.grpTableauDeBord.Location = new System.Drawing.Point(268, 266);
            this.grpTableauDeBord.Name = "grpTableauDeBord";
            this.grpTableauDeBord.Size = new System.Drawing.Size(1418, 673);
            this.grpTableauDeBord.TabIndex = 10;
            this.grpTableauDeBord.TabStop = false;
            this.grpTableauDeBord.Text = "Nombre de mission trouvée : ";
            // 
            // btnStats
            // 
            this.btnStats.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStats.Font = new System.Drawing.Font("Cascadia Code", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnStats.Location = new System.Drawing.Point(12, 440);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(213, 72);
            this.btnStats.TabIndex = 10;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.AutoScroll = true;
            this.pnlStats.Controls.Add(this.lblStatsInformateurResultat);
            this.pnlStats.Controls.Add(this.lblStatsInformateur);
            this.pnlStats.Controls.Add(this.dgvDepenseParMission);
            this.pnlStats.Controls.Add(this.dgvMissionParPlanete);
            this.pnlStats.Controls.Add(this.dgvStatsMissionBudget);
            this.pnlStats.Controls.Add(this.label3);
            this.pnlStats.Controls.Add(this.label2);
            this.pnlStats.Controls.Add(this.lblStatsMissionBudget);
            this.pnlStats.Controls.Add(this.lblMembreMemeMission);
            this.pnlStats.Controls.Add(this.dgvStatsMembrePartage);
            this.pnlStats.Controls.Add(this.cboStatsInformateurMission);
            this.pnlStats.Controls.Add(this.cboStats1);
            this.pnlStats.Location = new System.Drawing.Point(268, 101);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1017, 838);
            this.pnlStats.TabIndex = 7;
            // 
            // cboStatsInformateurMission
            // 
            this.cboStatsInformateurMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStatsInformateurMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatsInformateurMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatsInformateurMission.FormattingEnabled = true;
            this.cboStatsInformateurMission.Location = new System.Drawing.Point(13, 951);
            this.cboStatsInformateurMission.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatsInformateurMission.Name = "cboStatsInformateurMission";
            this.cboStatsInformateurMission.Size = new System.Drawing.Size(240, 26);
            this.cboStatsInformateurMission.TabIndex = 2;
            this.cboStatsInformateurMission.SelectedIndexChanged += new System.EventHandler(this.cboStats2_SelectedIndexChanged);
            // 
            // cboStats1
            // 
            this.cboStats1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStats1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStats1.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cboStats1.FormattingEnabled = true;
            this.cboStats1.Location = new System.Drawing.Point(13, 47);
            this.cboStats1.Margin = new System.Windows.Forms.Padding(2);
            this.cboStats1.Name = "cboStats1";
            this.cboStats1.Size = new System.Drawing.Size(240, 28);
            this.cboStats1.TabIndex = 1;
            this.cboStats1.SelectedIndexChanged += new System.EventHandler(this.cboStats1_SelectedIndexChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(33, 8);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(267, 117);
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // dgvStatsMembrePartage
            // 
            this.dgvStatsMembrePartage.AllowUserToAddRows = false;
            this.dgvStatsMembrePartage.AllowUserToDeleteRows = false;
            this.dgvStatsMembrePartage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatsMembrePartage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStatsMembrePartage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatsMembrePartage.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStatsMembrePartage.Location = new System.Drawing.Point(13, 80);
            this.dgvStatsMembrePartage.Name = "dgvStatsMembrePartage";
            this.dgvStatsMembrePartage.ReadOnly = true;
            this.dgvStatsMembrePartage.Size = new System.Drawing.Size(981, 150);
            this.dgvStatsMembrePartage.TabIndex = 3;
            // 
            // lblMembreMemeMission
            // 
            this.lblMembreMemeMission.AutoSize = true;
            this.lblMembreMemeMission.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMembreMemeMission.Location = new System.Drawing.Point(8, 13);
            this.lblMembreMemeMission.Name = "lblMembreMemeMission";
            this.lblMembreMemeMission.Size = new System.Drawing.Size(576, 27);
            this.lblMembreMemeMission.TabIndex = 4;
            this.lblMembreMemeMission.Text = "Membres ayant participé à des missions ensemble";
            // 
            // lblStatsMissionBudget
            // 
            this.lblStatsMissionBudget.AutoSize = true;
            this.lblStatsMissionBudget.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblStatsMissionBudget.Location = new System.Drawing.Point(8, 249);
            this.lblStatsMissionBudget.Name = "lblStatsMissionBudget";
            this.lblStatsMissionBudget.Size = new System.Drawing.Size(792, 27);
            this.lblStatsMissionBudget.TabIndex = 5;
            this.lblStatsMissionBudget.Text = "Pour les missions de plus de 10 membres, budget initial et actuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de missions déjà éffectuées sur chaque planète";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 717);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Informations sur les dépenses les plus élevées de chaque mission";
            // 
            // dgvStatsMissionBudget
            // 
            this.dgvStatsMissionBudget.AllowUserToAddRows = false;
            this.dgvStatsMissionBudget.AllowUserToDeleteRows = false;
            this.dgvStatsMissionBudget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatsMissionBudget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStatsMissionBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatsMissionBudget.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStatsMissionBudget.Location = new System.Drawing.Point(13, 279);
            this.dgvStatsMissionBudget.Name = "dgvStatsMissionBudget";
            this.dgvStatsMissionBudget.ReadOnly = true;
            this.dgvStatsMissionBudget.Size = new System.Drawing.Size(981, 150);
            this.dgvStatsMissionBudget.TabIndex = 8;
            // 
            // dgvMissionParPlanete
            // 
            this.dgvMissionParPlanete.AllowUserToAddRows = false;
            this.dgvMissionParPlanete.AllowUserToDeleteRows = false;
            this.dgvMissionParPlanete.AllowUserToOrderColumns = true;
            this.dgvMissionParPlanete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMissionParPlanete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMissionParPlanete.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMissionParPlanete.Location = new System.Drawing.Point(13, 479);
            this.dgvMissionParPlanete.Name = "dgvMissionParPlanete";
            this.dgvMissionParPlanete.ReadOnly = true;
            this.dgvMissionParPlanete.Size = new System.Drawing.Size(981, 218);
            this.dgvMissionParPlanete.TabIndex = 9;
            // 
            // dgvDepenseParMission
            // 
            this.dgvDepenseParMission.AllowUserToAddRows = false;
            this.dgvDepenseParMission.AllowUserToDeleteRows = false;
            this.dgvDepenseParMission.AllowUserToOrderColumns = true;
            this.dgvDepenseParMission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepenseParMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepenseParMission.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepenseParMission.Location = new System.Drawing.Point(13, 749);
            this.dgvDepenseParMission.Name = "dgvDepenseParMission";
            this.dgvDepenseParMission.ReadOnly = true;
            this.dgvDepenseParMission.Size = new System.Drawing.Size(981, 150);
            this.dgvDepenseParMission.TabIndex = 10;
            // 
            // lblStatsInformateur
            // 
            this.lblStatsInformateur.AutoSize = true;
            this.lblStatsInformateur.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblStatsInformateur.Location = new System.Drawing.Point(8, 919);
            this.lblStatsInformateur.Name = "lblStatsInformateur";
            this.lblStatsInformateur.Size = new System.Drawing.Size(696, 27);
            this.lblStatsInformateur.TabIndex = 11;
            this.lblStatsInformateur.Text = "Informateur ayant eu le moins de sous pour chaque mission";
            // 
            // lblStatsInformateurResultat
            // 
            this.lblStatsInformateurResultat.AutoEllipsis = true;
            this.lblStatsInformateurResultat.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblStatsInformateurResultat.Location = new System.Drawing.Point(258, 951);
            this.lblStatsInformateurResultat.Name = "lblStatsInformateurResultat";
            this.lblStatsInformateurResultat.Size = new System.Drawing.Size(736, 44);
            this.lblStatsInformateurResultat.TabIndex = 12;
            this.lblStatsInformateurResultat.Text = "Informateur ayant eu le moins de sous pour chaque mission";
            // 
            // FrmTableauDeBord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.grpEspeces);
            this.Controls.Add(this.grpTableauDeBord);
            this.Controls.Add(this.btnNouvelleMission);
            this.Controls.Add(this.grpFiltreMission);
            this.Controls.Add(this.pnlPlanetes);
            this.Controls.Add(this.pnlEnnemis);
            this.Controls.Add(this.pnlAllies);
            this.Controls.Add(this.pnlEspeces);
            this.Controls.Add(this.btnSwitchTheme);
            this.Controls.Add(this.btnPlanetes);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnTDB);
            this.Controls.Add(this.btnStats);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmTableauDeBord";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de Bord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            this.grpEspeces.ResumeLayout(false);
            this.grpEspeces.PerformLayout();
            this.grpFiltreMission.ResumeLayout(false);
            this.grpFiltreMission.PerformLayout();
            this.grpTableauDeBord.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsMembrePartage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsMissionBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionParPlanete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenseParMission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnPlanetes;
        private System.Windows.Forms.GroupBox grpEspeces;
        private System.Windows.Forms.RadioButton rdbEnnemis;
        private System.Windows.Forms.RadioButton rdbAllies;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.TextBox txtNomEspece;
        private System.Windows.Forms.Label lblIndicationNom;
        private System.Windows.Forms.FlowLayoutPanel pnlTDB;
        private System.Windows.Forms.Button btnSwitchTheme;
        private System.Windows.Forms.FlowLayoutPanel pnlPlanetes;
        private System.Windows.Forms.FlowLayoutPanel pnlEspeces;
        private System.Windows.Forms.FlowLayoutPanel pnlAllies;
        private System.Windows.Forms.FlowLayoutPanel pnlEnnemis;
        private System.Windows.Forms.GroupBox grpFiltreMission;
        private System.Windows.Forms.ComboBox cboFiltrePlanete;
        private System.Windows.Forms.Label lblFiltrePlanete;
        private System.Windows.Forms.ComboBox cboFiltreEtat;
        private System.Windows.Forms.Label lblFiltreEtat;
        private System.Windows.Forms.Button btntriAlpha;
        private System.Windows.Forms.GroupBox grpTableauDeBord;
        private System.Windows.Forms.Button btntriEtat;
        private System.Windows.Forms.Label lblIndicationPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Label lblIndicationCouleur;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.ComboBox cboStats1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cboStatsInformateurMission;
        private System.Windows.Forms.DataGridView dgvStatsMembrePartage;
        private System.Windows.Forms.Label lblMembreMemeMission;
        private System.Windows.Forms.Label lblStatsMissionBudget;
        private System.Windows.Forms.DataGridView dgvDepenseParMission;
        private System.Windows.Forms.DataGridView dgvMissionParPlanete;
        private System.Windows.Forms.DataGridView dgvStatsMissionBudget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatsInformateur;
        private System.Windows.Forms.Label lblStatsInformateurResultat;
    }
}

