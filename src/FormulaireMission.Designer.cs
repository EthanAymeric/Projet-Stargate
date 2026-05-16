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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.grpMembre = new System.Windows.Forms.GroupBox();
            this.pnlMembre = new System.Windows.Forms.Panel();
            this.grpCaptures = new System.Windows.Forms.GroupBox();
            this.txtCaptures = new System.Windows.Forms.RichTextBox();
            this.grpFeuilleRoute = new System.Windows.Forms.GroupBox();
            this.txtFeuilleRoute = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.missionPB1 = new SAE24.MissionPB();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpMembre.SuspendLayout();
            this.grpCaptures.SuspendLayout();
            this.grpFeuilleRoute.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpDepenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            this.grpContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.grpEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 613);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSolde);
            this.tabPage1.Controls.Add(this.lblBudget);
            this.tabPage1.Controls.Add(this.lblArrivee);
            this.tabPage1.Controls.Add(this.lblDepart);
            this.tabPage1.Controls.Add(this.grpMembre);
            this.tabPage1.Controls.Add(this.grpCaptures);
            this.tabPage1.Controls.Add(this.grpFeuilleRoute);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Location = new System.Drawing.Point(9, 103);
            this.lblSolde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(35, 13);
            this.lblSolde.TabIndex = 17;
            this.lblSolde.Text = "label1";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(9, 75);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(35, 13);
            this.lblBudget.TabIndex = 16;
            this.lblBudget.Text = "label1";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(9, 47);
            this.lblArrivee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(35, 13);
            this.lblArrivee.TabIndex = 15;
            this.lblArrivee.Text = "label1";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(9, 19);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(35, 13);
            this.lblDepart.TabIndex = 14;
            this.lblDepart.Text = "label1";
            // 
            // grpMembre
            // 
            this.grpMembre.Controls.Add(this.pnlMembre);
            this.grpMembre.Location = new System.Drawing.Point(3, 259);
            this.grpMembre.Name = "grpMembre";
            this.grpMembre.Size = new System.Drawing.Size(556, 182);
            this.grpMembre.TabIndex = 11;
            this.grpMembre.TabStop = false;
            this.grpMembre.Text = "Membre de l\'équipage";
            // 
            // pnlMembre
            // 
            this.pnlMembre.AutoScroll = true;
            this.pnlMembre.Location = new System.Drawing.Point(7, 20);
            this.pnlMembre.Name = "pnlMembre";
            this.pnlMembre.Size = new System.Drawing.Size(543, 155);
            this.pnlMembre.TabIndex = 0;
            // 
            // grpCaptures
            // 
            this.grpCaptures.Controls.Add(this.txtCaptures);
            this.grpCaptures.Location = new System.Drawing.Point(3, 447);
            this.grpCaptures.Name = "grpCaptures";
            this.grpCaptures.Size = new System.Drawing.Size(553, 136);
            this.grpCaptures.TabIndex = 12;
            this.grpCaptures.TabStop = false;
            this.grpCaptures.Text = "Objectifs (captures)";
            // 
            // txtCaptures
            // 
            this.txtCaptures.Location = new System.Drawing.Point(7, 20);
            this.txtCaptures.Name = "txtCaptures";
            this.txtCaptures.ReadOnly = true;
            this.txtCaptures.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCaptures.Size = new System.Drawing.Size(540, 110);
            this.txtCaptures.TabIndex = 0;
            this.txtCaptures.Text = "";
            // 
            // grpFeuilleRoute
            // 
            this.grpFeuilleRoute.Controls.Add(this.txtFeuilleRoute);
            this.grpFeuilleRoute.Location = new System.Drawing.Point(6, 142);
            this.grpFeuilleRoute.Name = "grpFeuilleRoute";
            this.grpFeuilleRoute.Size = new System.Drawing.Size(553, 111);
            this.grpFeuilleRoute.TabIndex = 10;
            this.grpFeuilleRoute.TabStop = false;
            this.grpFeuilleRoute.Text = "Feuille de route";
            // 
            // txtFeuilleRoute
            // 
            this.txtFeuilleRoute.Location = new System.Drawing.Point(6, 19);
            this.txtFeuilleRoute.Name = "txtFeuilleRoute";
            this.txtFeuilleRoute.ReadOnly = true;
            this.txtFeuilleRoute.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtFeuilleRoute.Size = new System.Drawing.Size(540, 86);
            this.txtFeuilleRoute.TabIndex = 6;
            this.txtFeuilleRoute.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDepense);
            this.tabPage2.Controls.Add(this.lblSommeVersees);
            this.tabPage2.Controls.Add(this.grpDepenses);
            this.tabPage2.Controls.Add(this.grpContacts);
            this.tabPage2.Controls.Add(this.grpEvent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDepense
            // 
            this.lblDepense.AutoSize = true;
            this.lblDepense.Location = new System.Drawing.Point(562, 462);
            this.lblDepense.Name = "lblDepense";
            this.lblDepense.Size = new System.Drawing.Size(35, 13);
            this.lblDepense.TabIndex = 9;
            this.lblDepense.Text = "label1";
            // 
            // lblSommeVersees
            // 
            this.lblSommeVersees.AutoSize = true;
            this.lblSommeVersees.Location = new System.Drawing.Point(10, 454);
            this.lblSommeVersees.Name = "lblSommeVersees";
            this.lblSommeVersees.Size = new System.Drawing.Size(35, 13);
            this.lblSommeVersees.TabIndex = 8;
            this.lblSommeVersees.Text = "label1";
            // 
            // grpDepenses
            // 
            this.grpDepenses.Controls.Add(this.dgvDepenses);
            this.grpDepenses.Location = new System.Drawing.Point(559, 6);
            this.grpDepenses.Name = "grpDepenses";
            this.grpDepenses.Size = new System.Drawing.Size(423, 446);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepenses.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepenses.Location = new System.Drawing.Point(6, 19);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.ReadOnly = true;
            this.dgvDepenses.Size = new System.Drawing.Size(411, 419);
            this.dgvDepenses.TabIndex = 0;
            // 
            // grpContacts
            // 
            this.grpContacts.Controls.Add(this.dgvContact);
            this.grpContacts.Location = new System.Drawing.Point(6, 273);
            this.grpContacts.Name = "grpContacts";
            this.grpContacts.Size = new System.Drawing.Size(547, 178);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContact.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContact.Location = new System.Drawing.Point(7, 20);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.ReadOnly = true;
            this.dgvContact.RowTemplate.ReadOnly = true;
            this.dgvContact.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContact.Size = new System.Drawing.Size(534, 150);
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
            this.grpEvent.Location = new System.Drawing.Point(6, 6);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Size = new System.Drawing.Size(547, 262);
            this.grpEvent.TabIndex = 5;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Evénement du Journal";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(262, 213);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(46, 43);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(210, 213);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(46, 43);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(158, 213);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(46, 43);
            this.btnPrecedent.TabIndex = 3;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(106, 213);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(46, 43);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Location = new System.Drawing.Point(71, 125);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(35, 13);
            this.lblEventDescription.TabIndex = 1;
            this.lblEventDescription.Text = "label2";
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Location = new System.Drawing.Point(8, 125);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(35, 13);
            this.lblDateEvent.TabIndex = 0;
            this.lblDateEvent.Text = "label1";
            // 
            // missionPB1
            // 
            this.missionPB1.Location = new System.Drawing.Point(424, 10);
            this.missionPB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.missionPB1.Name = "missionPB1";
            this.missionPB1.Size = new System.Drawing.Size(172, 139);
            this.missionPB1.TabIndex = 0;
            // 
            // FormulaireMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 744);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.missionPB1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormulaireMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireMission";
            this.Load += new System.EventHandler(this.FormulaireMission_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpMembre.ResumeLayout(false);
            this.grpCaptures.ResumeLayout(false);
            this.grpFeuilleRoute.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpDepenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).EndInit();
            this.grpContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MissionPB missionPB1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpMembre;
        private System.Windows.Forms.Panel pnlMembre;
        private System.Windows.Forms.GroupBox grpCaptures;
        private System.Windows.Forms.RichTextBox txtCaptures;
        private System.Windows.Forms.GroupBox grpFeuilleRoute;
        private System.Windows.Forms.RichTextBox txtFeuilleRoute;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}