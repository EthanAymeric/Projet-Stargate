namespace SAE24
{
    partial class FormulaireMission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcResume = new System.Windows.Forms.TabControl();
            this.tpInfoGeneral = new System.Windows.Forms.TabPage();
            this.lblSolde = new System.Windows.Forms.Label();
            this.grpCaptures = new System.Windows.Forms.GroupBox();
            this.txtCaptures = new System.Windows.Forms.RichTextBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.grpMembre = new System.Windows.Forms.GroupBox();
            this.pnlMembre = new System.Windows.Forms.Panel();
            this.grpFeuilleRoute = new System.Windows.Forms.GroupBox();
            this.txtFeuilleRoute = new System.Windows.Forms.RichTextBox();
            this.tpEvent = new System.Windows.Forms.TabPage();
            this.grpCapture = new System.Windows.Forms.GroupBox();
            this.dgvCapture = new System.Windows.Forms.DataGridView();
            this.lblDepense = new System.Windows.Forms.Label();
            this.lblSommeVersees = new System.Windows.Forms.Label();
            this.grpDepenses = new System.Windows.Forms.GroupBox();
            this.dgvDepenses = new System.Windows.Forms.DataGridView();
            this.grpContacts = new System.Windows.Forms.GroupBox();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.grpEvent = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.tpAjout = new System.Windows.Forms.TabPage();
            this.grpFormDepense = new System.Windows.Forms.GroupBox();
            this.btnAjoutDepense = new System.Windows.Forms.Button();
            this.grpFormCapture = new System.Windows.Forms.GroupBox();
            this.btnAjoutCapture = new System.Windows.Forms.Button();
            this.grpFormContact = new System.Windows.Forms.GroupBox();
            this.btnAjoutContact = new System.Windows.Forms.Button();
            this.grpFormEvent = new System.Windows.Forms.GroupBox();
            this.btnAjoutEvent = new System.Windows.Forms.Button();
            this.grpChoixAjout = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbNewContact = new System.Windows.Forms.RadioButton();
            this.missionPB1 = new SAE24.MissionPB();
            this.lblDateDepense = new System.Windows.Forms.Label();
            this.dtpDepense = new System.Windows.Forms.DateTimePicker();
            this.lblMontantDepense = new System.Windows.Forms.Label();
            this.lblMotifDepense = new System.Windows.Forms.Label();
            this.lblTypeDepense = new System.Windows.Forms.Label();
            this.cboTypeDepense = new System.Windows.Forms.ComboBox();
            this.txtMontantDepense = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tcResume.SuspendLayout();
            this.tpInfoGeneral.SuspendLayout();
            this.grpCaptures.SuspendLayout();
            this.grpMembre.SuspendLayout();
            this.grpFeuilleRoute.SuspendLayout();
            this.tpEvent.SuspendLayout();
            this.grpCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapture)).BeginInit();
            this.grpDepenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            this.grpContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.grpEvent.SuspendLayout();
            this.tpAjout.SuspendLayout();
            this.grpFormDepense.SuspendLayout();
            this.grpFormCapture.SuspendLayout();
            this.grpFormContact.SuspendLayout();
            this.grpFormEvent.SuspendLayout();
            this.grpChoixAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcResume
            // 
            this.tcResume.Controls.Add(this.tpInfoGeneral);
            this.tcResume.Controls.Add(this.tpEvent);
            this.tcResume.Controls.Add(this.tpAjout);
            this.tcResume.Location = new System.Drawing.Point(16, 190);
            this.tcResume.Margin = new System.Windows.Forms.Padding(4);
            this.tcResume.Name = "tcResume";
            this.tcResume.SelectedIndex = 0;
            this.tcResume.Size = new System.Drawing.Size(1328, 675);
            this.tcResume.TabIndex = 10;
            // 
            // tpInfoGeneral
            // 
            this.tpInfoGeneral.Controls.Add(this.lblSolde);
            this.tpInfoGeneral.Controls.Add(this.grpCaptures);
            this.tpInfoGeneral.Controls.Add(this.lblBudget);
            this.tpInfoGeneral.Controls.Add(this.lblArrivee);
            this.tpInfoGeneral.Controls.Add(this.lblDepart);
            this.tpInfoGeneral.Controls.Add(this.grpMembre);
            this.tpInfoGeneral.Controls.Add(this.grpFeuilleRoute);
            this.tpInfoGeneral.Location = new System.Drawing.Point(4, 25);
            this.tpInfoGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.tpInfoGeneral.Name = "tpInfoGeneral";
            this.tpInfoGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.tpInfoGeneral.Size = new System.Drawing.Size(1320, 646);
            this.tpInfoGeneral.TabIndex = 0;
            this.tpInfoGeneral.Text = "Informations Générales";
            this.tpInfoGeneral.UseVisualStyleBackColor = true;
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Location = new System.Drawing.Point(440, 58);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(44, 16);
            this.lblSolde.TabIndex = 17;
            this.lblSolde.Text = "label1";
            // 
            // grpCaptures
            // 
            this.grpCaptures.Controls.Add(this.txtCaptures);
            this.grpCaptures.Location = new System.Drawing.Point(4, 469);
            this.grpCaptures.Margin = new System.Windows.Forms.Padding(4);
            this.grpCaptures.Name = "grpCaptures";
            this.grpCaptures.Padding = new System.Windows.Forms.Padding(4);
            this.grpCaptures.Size = new System.Drawing.Size(741, 167);
            this.grpCaptures.TabIndex = 12;
            this.grpCaptures.TabStop = false;
            this.grpCaptures.Text = "Objectifs (captures)";
            // 
            // txtCaptures
            // 
            this.txtCaptures.Location = new System.Drawing.Point(9, 25);
            this.txtCaptures.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaptures.Name = "txtCaptures";
            this.txtCaptures.ReadOnly = true;
            this.txtCaptures.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCaptures.Size = new System.Drawing.Size(723, 134);
            this.txtCaptures.TabIndex = 0;
            this.txtCaptures.Text = "";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(440, 23);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(44, 16);
            this.lblBudget.TabIndex = 16;
            this.lblBudget.Text = "label1";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(12, 58);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(44, 16);
            this.lblArrivee.TabIndex = 15;
            this.lblArrivee.Text = "label1";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(12, 23);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(44, 16);
            this.lblDepart.TabIndex = 14;
            this.lblDepart.Text = "label1";
            // 
            // grpMembre
            // 
            this.grpMembre.Controls.Add(this.pnlMembre);
            this.grpMembre.Location = new System.Drawing.Point(4, 238);
            this.grpMembre.Margin = new System.Windows.Forms.Padding(4);
            this.grpMembre.Name = "grpMembre";
            this.grpMembre.Padding = new System.Windows.Forms.Padding(4);
            this.grpMembre.Size = new System.Drawing.Size(741, 224);
            this.grpMembre.TabIndex = 11;
            this.grpMembre.TabStop = false;
            this.grpMembre.Text = "Membre de l\'équipage";
            // 
            // pnlMembre
            // 
            this.pnlMembre.AutoScroll = true;
            this.pnlMembre.Location = new System.Drawing.Point(9, 25);
            this.pnlMembre.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMembre.Name = "pnlMembre";
            this.pnlMembre.Size = new System.Drawing.Size(724, 191);
            this.pnlMembre.TabIndex = 0;
            // 
            // grpFeuilleRoute
            // 
            this.grpFeuilleRoute.Controls.Add(this.txtFeuilleRoute);
            this.grpFeuilleRoute.Location = new System.Drawing.Point(4, 94);
            this.grpFeuilleRoute.Margin = new System.Windows.Forms.Padding(4);
            this.grpFeuilleRoute.Name = "grpFeuilleRoute";
            this.grpFeuilleRoute.Padding = new System.Windows.Forms.Padding(4);
            this.grpFeuilleRoute.Size = new System.Drawing.Size(737, 137);
            this.grpFeuilleRoute.TabIndex = 10;
            this.grpFeuilleRoute.TabStop = false;
            this.grpFeuilleRoute.Text = "Feuille de route";
            // 
            // txtFeuilleRoute
            // 
            this.txtFeuilleRoute.Location = new System.Drawing.Point(8, 23);
            this.txtFeuilleRoute.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeuilleRoute.Name = "txtFeuilleRoute";
            this.txtFeuilleRoute.ReadOnly = true;
            this.txtFeuilleRoute.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtFeuilleRoute.Size = new System.Drawing.Size(720, 105);
            this.txtFeuilleRoute.TabIndex = 6;
            this.txtFeuilleRoute.Text = "";
            // 
            // tpEvent
            // 
            this.tpEvent.Controls.Add(this.grpCapture);
            this.tpEvent.Controls.Add(this.lblDepense);
            this.tpEvent.Controls.Add(this.lblSommeVersees);
            this.tpEvent.Controls.Add(this.grpDepenses);
            this.tpEvent.Controls.Add(this.grpContacts);
            this.tpEvent.Controls.Add(this.grpEvent);
            this.tpEvent.Location = new System.Drawing.Point(4, 25);
            this.tpEvent.Margin = new System.Windows.Forms.Padding(4);
            this.tpEvent.Name = "tpEvent";
            this.tpEvent.Padding = new System.Windows.Forms.Padding(4);
            this.tpEvent.Size = new System.Drawing.Size(1320, 646);
            this.tpEvent.TabIndex = 1;
            this.tpEvent.Text = "Évènements";
            this.tpEvent.UseVisualStyleBackColor = true;
            // 
            // grpCapture
            // 
            this.grpCapture.Controls.Add(this.dgvCapture);
            this.grpCapture.Location = new System.Drawing.Point(745, 336);
            this.grpCapture.Margin = new System.Windows.Forms.Padding(4);
            this.grpCapture.Name = "grpCapture";
            this.grpCapture.Padding = new System.Windows.Forms.Padding(4);
            this.grpCapture.Size = new System.Drawing.Size(564, 219);
            this.grpCapture.TabIndex = 8;
            this.grpCapture.TabStop = false;
            this.grpCapture.Text = "Capture Effectuées";
            // 
            // dgvCapture
            // 
            this.dgvCapture.AllowUserToAddRows = false;
            this.dgvCapture.AllowUserToDeleteRows = false;
            this.dgvCapture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCapture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCapture.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCapture.Location = new System.Drawing.Point(8, 23);
            this.dgvCapture.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCapture.Name = "dgvCapture";
            this.dgvCapture.ReadOnly = true;
            this.dgvCapture.RowHeadersWidth = 51;
            this.dgvCapture.Size = new System.Drawing.Size(548, 185);
            this.dgvCapture.TabIndex = 0;
            // 
            // lblDepense
            // 
            this.lblDepense.AutoSize = true;
            this.lblDepense.Location = new System.Drawing.Point(749, 569);
            this.lblDepense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepense.Name = "lblDepense";
            this.lblDepense.Size = new System.Drawing.Size(44, 16);
            this.lblDepense.TabIndex = 9;
            this.lblDepense.Text = "label1";
            // 
            // lblSommeVersees
            // 
            this.lblSommeVersees.AutoSize = true;
            this.lblSommeVersees.Location = new System.Drawing.Point(13, 559);
            this.lblSommeVersees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSommeVersees.Name = "lblSommeVersees";
            this.lblSommeVersees.Size = new System.Drawing.Size(44, 16);
            this.lblSommeVersees.TabIndex = 8;
            this.lblSommeVersees.Text = "label1";
            // 
            // grpDepenses
            // 
            this.grpDepenses.Controls.Add(this.dgvDepenses);
            this.grpDepenses.Location = new System.Drawing.Point(745, 7);
            this.grpDepenses.Margin = new System.Windows.Forms.Padding(4);
            this.grpDepenses.Name = "grpDepenses";
            this.grpDepenses.Padding = new System.Windows.Forms.Padding(4);
            this.grpDepenses.Size = new System.Drawing.Size(564, 322);
            this.grpDepenses.TabIndex = 7;
            this.grpDepenses.TabStop = false;
            this.grpDepenses.Text = "Dépenses Effectuées";
            // 
            // dgvDepenses
            // 
            this.dgvDepenses.AllowUserToAddRows = false;
            this.dgvDepenses.AllowUserToDeleteRows = false;
            this.dgvDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepenses.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDepenses.Location = new System.Drawing.Point(8, 23);
            this.dgvDepenses.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.ReadOnly = true;
            this.dgvDepenses.RowHeadersWidth = 51;
            this.dgvDepenses.Size = new System.Drawing.Size(548, 292);
            this.dgvDepenses.TabIndex = 0;
            // 
            // grpContacts
            // 
            this.grpContacts.Controls.Add(this.dgvContact);
            this.grpContacts.Location = new System.Drawing.Point(8, 336);
            this.grpContacts.Margin = new System.Windows.Forms.Padding(4);
            this.grpContacts.Name = "grpContacts";
            this.grpContacts.Padding = new System.Windows.Forms.Padding(4);
            this.grpContacts.Size = new System.Drawing.Size(729, 219);
            this.grpContacts.TabIndex = 6;
            this.grpContacts.TabStop = false;
            this.grpContacts.Text = "Contacts avec les informateurs";
            // 
            // dgvContact
            // 
            this.dgvContact.AllowUserToAddRows = false;
            this.dgvContact.AllowUserToDeleteRows = false;
            this.dgvContact.AllowUserToResizeColumns = false;
            this.dgvContact.AllowUserToResizeRows = false;
            this.dgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContact.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContact.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvContact.Location = new System.Drawing.Point(9, 25);
            this.dgvContact.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.ReadOnly = true;
            this.dgvContact.RowHeadersWidth = 51;
            this.dgvContact.RowTemplate.ReadOnly = true;
            this.dgvContact.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContact.Size = new System.Drawing.Size(712, 185);
            this.dgvContact.TabIndex = 0;
            // 
            // grpEvent
            // 
            this.grpEvent.Controls.Add(this.btnLast);
            this.grpEvent.Controls.Add(this.btnSuivant);
            this.grpEvent.Controls.Add(this.btnPrecedent);
            this.grpEvent.Controls.Add(this.btnFirst);
            this.grpEvent.Controls.Add(this.lblEventDescription);
            this.grpEvent.Controls.Add(this.lblDateEvent);
            this.grpEvent.Location = new System.Drawing.Point(8, 7);
            this.grpEvent.Margin = new System.Windows.Forms.Padding(4);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Padding = new System.Windows.Forms.Padding(4);
            this.grpEvent.Size = new System.Drawing.Size(729, 322);
            this.grpEvent.TabIndex = 5;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Evénement du Journal";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(437, 262);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(61, 53);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(368, 262);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(61, 53);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(299, 262);
            this.btnPrecedent.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(61, 53);
            this.btnPrecedent.TabIndex = 3;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(229, 262);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(61, 53);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Location = new System.Drawing.Point(95, 154);
            this.lblEventDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(44, 16);
            this.lblEventDescription.TabIndex = 1;
            this.lblEventDescription.Text = "label2";
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Location = new System.Drawing.Point(11, 154);
            this.lblDateEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(44, 16);
            this.lblDateEvent.TabIndex = 0;
            this.lblDateEvent.Text = "label1";
            // 
            // tpAjout
            // 
            this.tpAjout.Controls.Add(this.grpFormDepense);
            this.tpAjout.Controls.Add(this.grpFormCapture);
            this.tpAjout.Controls.Add(this.grpFormContact);
            this.tpAjout.Controls.Add(this.grpFormEvent);
            this.tpAjout.Controls.Add(this.grpChoixAjout);
            this.tpAjout.Location = new System.Drawing.Point(4, 25);
            this.tpAjout.Margin = new System.Windows.Forms.Padding(4);
            this.tpAjout.Name = "tpAjout";
            this.tpAjout.Size = new System.Drawing.Size(1320, 646);
            this.tpAjout.TabIndex = 2;
            this.tpAjout.Text = "Ajout d\'évènements";
            this.tpAjout.UseVisualStyleBackColor = true;
            // 
            // grpFormDepense
            // 
            this.grpFormDepense.Controls.Add(this.richTextBox1);
            this.grpFormDepense.Controls.Add(this.txtMontantDepense);
            this.grpFormDepense.Controls.Add(this.cboTypeDepense);
            this.grpFormDepense.Controls.Add(this.lblTypeDepense);
            this.grpFormDepense.Controls.Add(this.lblMotifDepense);
            this.grpFormDepense.Controls.Add(this.lblMontantDepense);
            this.grpFormDepense.Controls.Add(this.dtpDepense);
            this.grpFormDepense.Controls.Add(this.lblDateDepense);
            this.grpFormDepense.Controls.Add(this.btnAjoutDepense);
            this.grpFormDepense.Location = new System.Drawing.Point(278, 138);
            this.grpFormDepense.Name = "grpFormDepense";
            this.grpFormDepense.Size = new System.Drawing.Size(765, 503);
            this.grpFormDepense.TabIndex = 3;
            this.grpFormDepense.TabStop = false;
            this.grpFormDepense.Text = "Ajout de Dépense";
            this.grpFormDepense.Visible = false;
            // 
            // btnAjoutDepense
            // 
            this.btnAjoutDepense.Location = new System.Drawing.Point(662, 459);
            this.btnAjoutDepense.Name = "btnAjoutDepense";
            this.btnAjoutDepense.Size = new System.Drawing.Size(97, 38);
            this.btnAjoutDepense.TabIndex = 2;
            this.btnAjoutDepense.Text = "Valider";
            this.btnAjoutDepense.UseVisualStyleBackColor = true;
            // 
            // grpFormCapture
            // 
            this.grpFormCapture.Controls.Add(this.btnAjoutCapture);
            this.grpFormCapture.Location = new System.Drawing.Point(278, 138);
            this.grpFormCapture.Name = "grpFormCapture";
            this.grpFormCapture.Size = new System.Drawing.Size(765, 503);
            this.grpFormCapture.TabIndex = 3;
            this.grpFormCapture.TabStop = false;
            this.grpFormCapture.Text = "Ajout de Capture";
            this.grpFormCapture.Visible = false;
            // 
            // btnAjoutCapture
            // 
            this.btnAjoutCapture.Location = new System.Drawing.Point(662, 459);
            this.btnAjoutCapture.Name = "btnAjoutCapture";
            this.btnAjoutCapture.Size = new System.Drawing.Size(97, 38);
            this.btnAjoutCapture.TabIndex = 2;
            this.btnAjoutCapture.Text = "Valider";
            this.btnAjoutCapture.UseVisualStyleBackColor = true;
            // 
            // grpFormContact
            // 
            this.grpFormContact.Controls.Add(this.btnAjoutContact);
            this.grpFormContact.Location = new System.Drawing.Point(278, 138);
            this.grpFormContact.Name = "grpFormContact";
            this.grpFormContact.Size = new System.Drawing.Size(797, 511);
            this.grpFormContact.TabIndex = 3;
            this.grpFormContact.TabStop = false;
            this.grpFormContact.Text = "Ajout de Contact";
            this.grpFormContact.Visible = false;
            // 
            // btnAjoutContact
            // 
            this.btnAjoutContact.Location = new System.Drawing.Point(662, 459);
            this.btnAjoutContact.Name = "btnAjoutContact";
            this.btnAjoutContact.Size = new System.Drawing.Size(97, 38);
            this.btnAjoutContact.TabIndex = 2;
            this.btnAjoutContact.Text = "Valider";
            this.btnAjoutContact.UseVisualStyleBackColor = true;
            // 
            // grpFormEvent
            // 
            this.grpFormEvent.Controls.Add(this.btnAjoutEvent);
            this.grpFormEvent.Location = new System.Drawing.Point(278, 138);
            this.grpFormEvent.Name = "grpFormEvent";
            this.grpFormEvent.Size = new System.Drawing.Size(765, 503);
            this.grpFormEvent.TabIndex = 1;
            this.grpFormEvent.TabStop = false;
            this.grpFormEvent.Text = "Ajout d\'Évènements";
            this.grpFormEvent.Visible = false;
            // 
            // btnAjoutEvent
            // 
            this.btnAjoutEvent.Location = new System.Drawing.Point(662, 459);
            this.btnAjoutEvent.Name = "btnAjoutEvent";
            this.btnAjoutEvent.Size = new System.Drawing.Size(97, 38);
            this.btnAjoutEvent.TabIndex = 2;
            this.btnAjoutEvent.Text = "Valider";
            this.btnAjoutEvent.UseVisualStyleBackColor = true;
            this.btnAjoutEvent.Click += new System.EventHandler(this.btnValidationAjout_Click);
            // 
            // grpChoixAjout
            // 
            this.grpChoixAjout.Controls.Add(this.label4);
            this.grpChoixAjout.Controls.Add(this.label3);
            this.grpChoixAjout.Controls.Add(this.label2);
            this.grpChoixAjout.Controls.Add(this.label1);
            this.grpChoixAjout.Controls.Add(this.radioButton3);
            this.grpChoixAjout.Controls.Add(this.radioButton2);
            this.grpChoixAjout.Controls.Add(this.radioButton1);
            this.grpChoixAjout.Controls.Add(this.rdbNewContact);
            this.grpChoixAjout.Location = new System.Drawing.Point(372, 4);
            this.grpChoixAjout.Name = "grpChoixAjout";
            this.grpChoixAjout.Size = new System.Drawing.Size(577, 128);
            this.grpChoixAjout.TabIndex = 0;
            this.grpChoixAjout.TabStop = false;
            this.grpChoixAjout.Text = "Type d\'évènement à ajouter";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(461, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nouvelle capture";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(314, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nouvel Évènement";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(168, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nouvelle Dépense";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nouveau Contact";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.Location = new System.Drawing.Point(486, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 50);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "4";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.Location = new System.Drawing.Point(339, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 50);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "3";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.Location = new System.Drawing.Point(193, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 50);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "2";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdbNewContact
            // 
            this.rdbNewContact.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbNewContact.Location = new System.Drawing.Point(43, 34);
            this.rdbNewContact.Name = "rdbNewContact";
            this.rdbNewContact.Size = new System.Drawing.Size(50, 50);
            this.rdbNewContact.TabIndex = 0;
            this.rdbNewContact.TabStop = true;
            this.rdbNewContact.Tag = "1";
            this.rdbNewContact.UseVisualStyleBackColor = true;
            this.rdbNewContact.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // missionPB1
            // 
            this.missionPB1.Location = new System.Drawing.Point(565, 12);
            this.missionPB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.missionPB1.Name = "missionPB1";
            this.missionPB1.Size = new System.Drawing.Size(229, 171);
            this.missionPB1.TabIndex = 0;
            // 
            // lblDateDepense
            // 
            this.lblDateDepense.AutoSize = true;
            this.lblDateDepense.Location = new System.Drawing.Point(7, 48);
            this.lblDateDepense.Name = "lblDateDepense";
            this.lblDateDepense.Size = new System.Drawing.Size(45, 16);
            this.lblDateDepense.TabIndex = 3;
            this.lblDateDepense.Text = "Date : ";
            // 
            // dtpDepense
            // 
            this.dtpDepense.Location = new System.Drawing.Point(94, 43);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(200, 22);
            this.dtpDepense.TabIndex = 4;
            // 
            // lblMontantDepense
            // 
            this.lblMontantDepense.AutoSize = true;
            this.lblMontantDepense.Location = new System.Drawing.Point(7, 89);
            this.lblMontantDepense.Name = "lblMontantDepense";
            this.lblMontantDepense.Size = new System.Drawing.Size(44, 16);
            this.lblMontantDepense.TabIndex = 5;
            this.lblMontantDepense.Text = "label5";
            // 
            // lblMotifDepense
            // 
            this.lblMotifDepense.AutoSize = true;
            this.lblMotifDepense.Location = new System.Drawing.Point(7, 130);
            this.lblMotifDepense.Name = "lblMotifDepense";
            this.lblMotifDepense.Size = new System.Drawing.Size(44, 16);
            this.lblMotifDepense.TabIndex = 6;
            this.lblMotifDepense.Text = "label6";
            // 
            // lblTypeDepense
            // 
            this.lblTypeDepense.AutoSize = true;
            this.lblTypeDepense.Location = new System.Drawing.Point(10, 170);
            this.lblTypeDepense.Name = "lblTypeDepense";
            this.lblTypeDepense.Size = new System.Drawing.Size(44, 16);
            this.lblTypeDepense.TabIndex = 7;
            this.lblTypeDepense.Text = "label7";
            // 
            // cboTypeDepense
            // 
            this.cboTypeDepense.FormattingEnabled = true;
            this.cboTypeDepense.Location = new System.Drawing.Point(94, 170);
            this.cboTypeDepense.Name = "cboTypeDepense";
            this.cboTypeDepense.Size = new System.Drawing.Size(121, 24);
            this.cboTypeDepense.TabIndex = 8;
            // 
            // txtMontantDepense
            // 
            this.txtMontantDepense.Location = new System.Drawing.Point(94, 82);
            this.txtMontantDepense.Name = "txtMontantDepense";
            this.txtMontantDepense.Size = new System.Drawing.Size(100, 22);
            this.txtMontantDepense.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(94, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(176, 15);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // FormulaireMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1360, 878);
            this.Controls.Add(this.tcResume);
            this.Controls.Add(this.missionPB1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormulaireMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireMission";
            this.Load += new System.EventHandler(this.FormulaireMission_Load);
            this.tcResume.ResumeLayout(false);
            this.tpInfoGeneral.ResumeLayout(false);
            this.tpInfoGeneral.PerformLayout();
            this.grpCaptures.ResumeLayout(false);
            this.grpMembre.ResumeLayout(false);
            this.grpFeuilleRoute.ResumeLayout(false);
            this.tpEvent.ResumeLayout(false);
            this.tpEvent.PerformLayout();
            this.grpCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapture)).EndInit();
            this.grpDepenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).EndInit();
            this.grpContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            this.tpAjout.ResumeLayout(false);
            this.grpFormDepense.ResumeLayout(false);
            this.grpFormDepense.PerformLayout();
            this.grpFormCapture.ResumeLayout(false);
            this.grpFormContact.ResumeLayout(false);
            this.grpFormEvent.ResumeLayout(false);
            this.grpChoixAjout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MissionPB missionPB1;
        private System.Windows.Forms.TabControl tcResume;
        private System.Windows.Forms.TabPage tpInfoGeneral;
        private System.Windows.Forms.GroupBox grpMembre;
        private System.Windows.Forms.Panel pnlMembre;
        private System.Windows.Forms.GroupBox grpCaptures;
        private System.Windows.Forms.RichTextBox txtCaptures;
        private System.Windows.Forms.GroupBox grpFeuilleRoute;
        private System.Windows.Forms.RichTextBox txtFeuilleRoute;
        private System.Windows.Forms.TabPage tpEvent;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblDepense;
        private System.Windows.Forms.Label lblSommeVersees;
        private System.Windows.Forms.GroupBox grpDepenses;
        private System.Windows.Forms.DataGridView dgvDepenses;
        private System.Windows.Forms.GroupBox grpContacts;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.GroupBox grpEvent;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.Label lblDateEvent;
        private System.Windows.Forms.GroupBox grpCapture;
        private System.Windows.Forms.DataGridView dgvCapture;
        private System.Windows.Forms.TabPage tpAjout;
        private System.Windows.Forms.GroupBox grpChoixAjout;
        private System.Windows.Forms.RadioButton rdbNewContact;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpFormDepense;
        private System.Windows.Forms.Button btnAjoutDepense;
        private System.Windows.Forms.GroupBox grpFormCapture;
        private System.Windows.Forms.Button btnAjoutCapture;
        private System.Windows.Forms.GroupBox grpFormContact;
        private System.Windows.Forms.Button btnAjoutContact;
        private System.Windows.Forms.GroupBox grpFormEvent;
        private System.Windows.Forms.Button btnAjoutEvent;
        private System.Windows.Forms.DateTimePicker dtpDepense;
        private System.Windows.Forms.Label lblDateDepense;
        private System.Windows.Forms.TextBox txtMontantDepense;
        private System.Windows.Forms.ComboBox cboTypeDepense;
        private System.Windows.Forms.Label lblTypeDepense;
        private System.Windows.Forms.Label lblMotifDepense;
        private System.Windows.Forms.Label lblMontantDepense;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}