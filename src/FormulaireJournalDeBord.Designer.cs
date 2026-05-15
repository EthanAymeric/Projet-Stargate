namespace SAE24
{
    partial class FormulaireJournalDeBord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpEvent = new System.Windows.Forms.GroupBox();
            this.grpContacts = new System.Windows.Forms.GroupBox();
            this.grpDepenses = new System.Windows.Forms.GroupBox();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.dgvDepenses = new System.Windows.Forms.DataGridView();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.lblSommeVersees = new System.Windows.Forms.Label();
            this.lblDepense = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.grpEvent.SuspendLayout();
            this.grpContacts.SuspendLayout();
            this.grpDepenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEvent
            // 
            this.grpEvent.Controls.Add(this.btnLast);
            this.grpEvent.Controls.Add(this.btnSuivant);
            this.grpEvent.Controls.Add(this.btnPrecedent);
            this.grpEvent.Controls.Add(this.btnFirst);
            this.grpEvent.Controls.Add(this.lblEventDescription);
            this.grpEvent.Controls.Add(this.lblDateEvent);
            this.grpEvent.Location = new System.Drawing.Point(4, 4);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Size = new System.Drawing.Size(581, 262);
            this.grpEvent.TabIndex = 0;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Evénement du Journal";
            // 
            // grpContacts
            // 
            this.grpContacts.Controls.Add(this.dgvContact);
            this.grpContacts.Location = new System.Drawing.Point(4, 272);
            this.grpContacts.Name = "grpContacts";
            this.grpContacts.Size = new System.Drawing.Size(581, 178);
            this.grpContacts.TabIndex = 1;
            this.grpContacts.TabStop = false;
            this.grpContacts.Text = "Contacts avec les informateurs";
            // 
            // grpDepenses
            // 
            this.grpDepenses.Controls.Add(this.dgvDepenses);
            this.grpDepenses.Location = new System.Drawing.Point(591, 4);
            this.grpDepenses.Name = "grpDepenses";
            this.grpDepenses.Size = new System.Drawing.Size(457, 446);
            this.grpDepenses.TabIndex = 2;
            this.grpDepenses.TabStop = false;
            this.grpDepenses.Text = "Dépenses Effectuées";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContact.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvContact.Location = new System.Drawing.Point(7, 20);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.ReadOnly = true;
            this.dgvContact.RowTemplate.ReadOnly = true;
            this.dgvContact.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContact.Size = new System.Drawing.Size(568, 150);
            this.dgvContact.TabIndex = 0;
            // 
            // dgvDepenses
            // 
            this.dgvDepenses.AllowUserToAddRows = false;
            this.dgvDepenses.AllowUserToDeleteRows = false;
            this.dgvDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepenses.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDepenses.Location = new System.Drawing.Point(6, 19);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.ReadOnly = true;
            this.dgvDepenses.Size = new System.Drawing.Size(445, 419);
            this.dgvDepenses.TabIndex = 0;
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
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Location = new System.Drawing.Point(71, 125);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(35, 13);
            this.lblEventDescription.TabIndex = 1;
            this.lblEventDescription.Text = "label2";
            // 
            // lblSommeVersees
            // 
            this.lblSommeVersees.AutoSize = true;
            this.lblSommeVersees.Location = new System.Drawing.Point(4, 457);
            this.lblSommeVersees.Name = "lblSommeVersees";
            this.lblSommeVersees.Size = new System.Drawing.Size(35, 13);
            this.lblSommeVersees.TabIndex = 3;
            this.lblSommeVersees.Text = "label1";
            // 
            // lblDepense
            // 
            this.lblDepense.AutoSize = true;
            this.lblDepense.Location = new System.Drawing.Point(594, 457);
            this.lblDepense.Name = "lblDepense";
            this.lblDepense.Size = new System.Drawing.Size(35, 13);
            this.lblDepense.TabIndex = 4;
            this.lblDepense.Text = "label1";
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
            // FormulaireJournalDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 528);
            this.Controls.Add(this.lblDepense);
            this.Controls.Add(this.lblSommeVersees);
            this.Controls.Add(this.grpDepenses);
            this.Controls.Add(this.grpContacts);
            this.Controls.Add(this.grpEvent);
            this.Name = "FormulaireJournalDeBord";
            this.Text = "FormulaireJournalDeBord";
            this.Load += new System.EventHandler(this.FormulaireJournalDeBord_Load);
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            this.grpContacts.ResumeLayout(false);
            this.grpDepenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEvent;
        private System.Windows.Forms.GroupBox grpContacts;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.GroupBox grpDepenses;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.Label lblDateEvent;
        private System.Windows.Forms.DataGridView dgvDepenses;
        private System.Windows.Forms.Label lblSommeVersees;
        private System.Windows.Forms.Label lblDepense;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnFirst;
    }
}