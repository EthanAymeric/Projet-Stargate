namespace SAE24
{
    partial class FormCreationMission
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
            this.labelPlanete = new System.Windows.Forms.Label();
            this.comboBoxPlanete = new System.Windows.Forms.ComboBox();
            this.labelNomMission = new System.Windows.Forms.Label();
            this.comboBoxChef = new System.Windows.Forms.ComboBox();
            this.labelChef = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRetour = new System.Windows.Forms.DateTimePicker();
            this.labelDateDepart = new System.Windows.Forms.Label();
            this.labelDateRetour = new System.Windows.Forms.Label();
            this.labelDuree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlanete
            // 
            this.labelPlanete.AutoSize = true;
            this.labelPlanete.Location = new System.Drawing.Point(38, 66);
            this.labelPlanete.Name = "labelPlanete";
            this.labelPlanete.Size = new System.Drawing.Size(229, 26);
            this.labelPlanete.TabIndex = 0;
            this.labelPlanete.Text = "1 - Choix de la planète";
            // 
            // comboBoxPlanete
            // 
            this.comboBoxPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlanete.FormattingEnabled = true;
            this.comboBoxPlanete.Location = new System.Drawing.Point(396, 63);
            this.comboBoxPlanete.Name = "comboBoxPlanete";
            this.comboBoxPlanete.Size = new System.Drawing.Size(291, 34);
            this.comboBoxPlanete.TabIndex = 1;
            this.comboBoxPlanete.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlanete_SelectedIndexChanged);
            // 
            // labelNomMission
            // 
            this.labelNomMission.AutoSize = true;
            this.labelNomMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomMission.Location = new System.Drawing.Point(115, 109);
            this.labelNomMission.Name = "labelNomMission";
            this.labelNomMission.Size = new System.Drawing.Size(295, 39);
            this.labelNomMission.TabIndex = 2;
            this.labelNomMission.Text = "Nom de mission: ";
            // 
            // comboBoxChef
            // 
            this.comboBoxChef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChef.FormattingEnabled = true;
            this.comboBoxChef.Location = new System.Drawing.Point(396, 190);
            this.comboBoxChef.Name = "comboBoxChef";
            this.comboBoxChef.Size = new System.Drawing.Size(291, 34);
            this.comboBoxChef.TabIndex = 4;
            // 
            // labelChef
            // 
            this.labelChef.AutoSize = true;
            this.labelChef.Location = new System.Drawing.Point(38, 193);
            this.labelChef.Name = "labelChef";
            this.labelChef.Size = new System.Drawing.Size(287, 26);
            this.labelChef.TabIndex = 3;
            this.labelChef.Text = "2 - Choix du chef de mission";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(38, 274);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(206, 26);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "3 - Choix de la date ";
            // 
            // dateTimePickerDepart
            // 
            this.dateTimePickerDepart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDepart.Location = new System.Drawing.Point(516, 274);
            this.dateTimePickerDepart.Name = "dateTimePickerDepart";
            this.dateTimePickerDepart.Size = new System.Drawing.Size(171, 32);
            this.dateTimePickerDepart.TabIndex = 6;
            this.dateTimePickerDepart.ValueChanged += new System.EventHandler(this.dateTimePickerDepart_ValueChanged);
            // 
            // dateTimePickerRetour
            // 
            this.dateTimePickerRetour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRetour.Location = new System.Drawing.Point(516, 323);
            this.dateTimePickerRetour.Name = "dateTimePickerRetour";
            this.dateTimePickerRetour.Size = new System.Drawing.Size(171, 32);
            this.dateTimePickerRetour.TabIndex = 7;
            this.dateTimePickerRetour.ValueChanged += new System.EventHandler(this.dateTimePickerRetour_ValueChanged);
            // 
            // labelDateDepart
            // 
            this.labelDateDepart.AutoSize = true;
            this.labelDateDepart.Location = new System.Drawing.Point(391, 279);
            this.labelDateDepart.Name = "labelDateDepart";
            this.labelDateDepart.Size = new System.Drawing.Size(83, 26);
            this.labelDateDepart.TabIndex = 8;
            this.labelDateDepart.Text = "Départ:";
            // 
            // labelDateRetour
            // 
            this.labelDateRetour.AutoSize = true;
            this.labelDateRetour.Location = new System.Drawing.Point(391, 328);
            this.labelDateRetour.Name = "labelDateRetour";
            this.labelDateRetour.Size = new System.Drawing.Size(83, 26);
            this.labelDateRetour.TabIndex = 9;
            this.labelDateRetour.Text = "Retour:";
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(391, 374);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(83, 26);
            this.labelDuree.TabIndex = 10;
            this.labelDuree.Text = "Durée: ";
            // 
            // FormCreationMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 859);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.labelDateRetour);
            this.Controls.Add(this.labelDateDepart);
            this.Controls.Add(this.dateTimePickerRetour);
            this.Controls.Add(this.dateTimePickerDepart);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxChef);
            this.Controls.Add(this.labelChef);
            this.Controls.Add(this.labelNomMission);
            this.Controls.Add(this.comboBoxPlanete);
            this.Controls.Add(this.labelPlanete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCreationMission";
            this.Text = "Création d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.FormCreationMission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlanete;
        private System.Windows.Forms.ComboBox comboBoxPlanete;
        private System.Windows.Forms.Label labelNomMission;
        private System.Windows.Forms.ComboBox comboBoxChef;
        private System.Windows.Forms.Label labelChef;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetour;
        private System.Windows.Forms.Label labelDateDepart;
        private System.Windows.Forms.Label labelDateRetour;
        private System.Windows.Forms.Label labelDuree;
    }
}