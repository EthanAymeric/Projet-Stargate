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
            this.cboStats2 = new System.Windows.Forms.ComboBox();
            this.cboStats1 = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTDB.SuspendLayout();
            this.grpEspeces.SuspendLayout();
            this.grpFiltreMission.SuspendLayout();
            this.grpTableauDeBord.SuspendLayout();
            this.pnlStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
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
            this.btnNouvelleMission.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNouvelleMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnNouvelleMission.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNouvelleMission.FlatAppearance.BorderSize = 2;
            this.btnNouvelleMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNouvelleMission.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnNouvelleMission.Location = new System.Drawing.Point(13, 440);
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
            this.btnRaces.Location = new System.Drawing.Point(13, 552);
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
            this.btnPlanetes.Location = new System.Drawing.Point(13, 664);
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
            this.grpEspeces.Location = new System.Drawing.Point(268, 630);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Size = new System.Drawing.Size(1418, 240);
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
            this.lblIndicationNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIndicationNom.AutoSize = true;
            this.lblIndicationNom.Location = new System.Drawing.Point(548, 51);
            this.lblIndicationNom.Name = "lblIndicationNom";
            this.lblIndicationNom.Size = new System.Drawing.Size(243, 20);
            this.lblIndicationNom.TabIndex = 8;
            this.lblIndicationNom.Text = "Nom";
            // 
            // txtNomEspece
            // 
            this.txtNomEspece.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNomEspece.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtNomEspece.Location = new System.Drawing.Point(276, 52);
            this.txtNomEspece.Name = "txtNomEspece";
            this.txtNomEspece.Size = new System.Drawing.Size(222, 21);
            this.txtNomEspece.TabIndex = 7;
            this.txtNomEspece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEspece_KeyPress);
            // cboCouleur
            // 
            this.cboCouleur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCouleur.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(16, 156);
            this.cboCouleur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(222, 24);
            this.cboCouleur.TabIndex = 4;
            this.cboCouleur.SelectedIndexChanged += new System.EventHandler(this.cboCouleur_SelectedIndexChanged);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherche.Location = new System.Drawing.Point(1164, 38);
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
            this.btnReset.Location = new System.Drawing.Point(1164, 129);
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
            this.rdbEnnemis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rdbAllies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pnlTDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTDB.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTDB.Location = new System.Drawing.Point(6, 30);
            this.pnlTDB.MaximumSize = new System.Drawing.Size(1418, 783);
            this.pnlTDB.Name = "pnlTDB";
            this.pnlTDB.Size = new System.Drawing.Size(1406, 568);
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
            this.grpTableauDeBord.Size = new System.Drawing.Size(1418, 605);
            this.grpTableauDeBord.TabIndex = 10;
            this.grpTableauDeBord.TabStop = false;
            this.grpTableauDeBord.Text = "Nombre de mission trouvée : ";
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.grpTableauDeBord);
            this.Controls.Add(this.grpFiltreMission);
            this.Controls.Add(this.grpEspeces);
            this.Controls.Add(this.pnlPlanetes);
            this.Controls.Add(this.pnlEnnemis);
            this.Controls.Add(this.pnlAllies);
            this.Controls.Add(this.pnlEspeces);
            this.Controls.Add(this.btnSwitchTheme);
            this.Controls.Add(this.btnPlanetes);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnTDB);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private System.Windows.Forms.ComboBox cboStats2;
    }
}

