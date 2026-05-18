namespace UserControlPlanetes
{
    partial class UserControlPlanete
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPlanete = new System.Windows.Forms.PictureBox();
            this.lblNomPlanete = new System.Windows.Forms.Label();
            this.pbTemp = new System.Windows.Forms.PictureBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblGraviteCommun = new System.Windows.Forms.Label();
            this.lblGraviteValue = new System.Windows.Forms.Label();
            this.lblPresenceDatabaz = new System.Windows.Forms.Label();
            this.lblEspecesCommun = new System.Windows.Forms.Label();
            this.lblEspecesValue = new System.Windows.Forms.Label();
            this.lblMissionsCommun = new System.Windows.Forms.Label();
            this.lblMissionsValue = new System.Windows.Forms.Label();
            this.lblAlliesCommun = new System.Windows.Forms.Label();
            this.lblEnnemis = new System.Windows.Forms.Label();
            this.lblAlliesValue = new System.Windows.Forms.Label();
            this.lblEnnemisValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlanete
            // 
            this.pbPlanete.Location = new System.Drawing.Point(28, 35);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(170, 151);
            this.pbPlanete.TabIndex = 0;
            this.pbPlanete.TabStop = false;
            // 
            // lblNomPlanete
            // 
            this.lblNomPlanete.AutoSize = true;
            this.lblNomPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPlanete.Location = new System.Drawing.Point(52, 189);
            this.lblNomPlanete.Name = "lblNomPlanete";
            this.lblNomPlanete.Size = new System.Drawing.Size(88, 29);
            this.lblNomPlanete.TabIndex = 1;
            this.lblNomPlanete.Text = "<nom>";
            this.lblNomPlanete.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbTemp
            // 
            this.pbTemp.Location = new System.Drawing.Point(221, 35);
            this.pbTemp.Name = "pbTemp";
            this.pbTemp.Size = new System.Drawing.Size(42, 37);
            this.pbTemp.TabIndex = 2;
            this.pbTemp.TabStop = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(269, 35);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(128, 22);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "<température>";
            // 
            // lblGraviteCommun
            // 
            this.lblGraviteCommun.AutoSize = true;
            this.lblGraviteCommun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraviteCommun.Location = new System.Drawing.Point(217, 100);
            this.lblGraviteCommun.Name = "lblGraviteCommun";
            this.lblGraviteCommun.Size = new System.Drawing.Size(78, 22);
            this.lblGraviteCommun.TabIndex = 4;
            this.lblGraviteCommun.Text = "Gravité :";
            // 
            // lblGraviteValue
            // 
            this.lblGraviteValue.AutoSize = true;
            this.lblGraviteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraviteValue.Location = new System.Drawing.Point(269, 100);
            this.lblGraviteValue.Name = "lblGraviteValue";
            this.lblGraviteValue.Size = new System.Drawing.Size(86, 22);
            this.lblGraviteValue.TabIndex = 5;
            this.lblGraviteValue.Text = "<gravité>";
            // 
            // lblPresenceDatabaz
            // 
            this.lblPresenceDatabaz.AutoSize = true;
            this.lblPresenceDatabaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresenceDatabaz.Location = new System.Drawing.Point(216, 75);
            this.lblPresenceDatabaz.Name = "lblPresenceDatabaz";
            this.lblPresenceDatabaz.Size = new System.Drawing.Size(303, 25);
            this.lblPresenceDatabaz.TabIndex = 6;
            this.lblPresenceDatabaz.Text = "<Présence de Databaz (ou non)>";
            // 
            // lblEspecesCommun
            // 
            this.lblEspecesCommun.AutoSize = true;
            this.lblEspecesCommun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecesCommun.Location = new System.Drawing.Point(217, 122);
            this.lblEspecesCommun.Name = "lblEspecesCommun";
            this.lblEspecesCommun.Size = new System.Drawing.Size(173, 22);
            this.lblEspecesCommun.TabIndex = 7;
            this.lblEspecesCommun.Text = "Espèces présentes :";
            // 
            // lblEspecesValue
            // 
            this.lblEspecesValue.AutoSize = true;
            this.lblEspecesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecesValue.Location = new System.Drawing.Point(332, 122);
            this.lblEspecesValue.Name = "lblEspecesValue";
            this.lblEspecesValue.Size = new System.Drawing.Size(87, 22);
            this.lblEspecesValue.TabIndex = 8;
            this.lblEspecesValue.Text = "<nom(s)>";
            this.lblEspecesValue.Click += new System.EventHandler(this.lblEspecesValue_Click);
            // 
            // lblMissionsCommun
            // 
            this.lblMissionsCommun.AutoSize = true;
            this.lblMissionsCommun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionsCommun.Location = new System.Drawing.Point(217, 166);
            this.lblMissionsCommun.Name = "lblMissionsCommun";
            this.lblMissionsCommun.Size = new System.Drawing.Size(166, 22);
            this.lblMissionsCommun.TabIndex = 9;
            this.lblMissionsCommun.Text = "Missions réalisées :";
            // 
            // lblMissionsValue
            // 
            this.lblMissionsValue.AutoSize = true;
            this.lblMissionsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionsValue.Location = new System.Drawing.Point(332, 166);
            this.lblMissionsValue.Name = "lblMissionsValue";
            this.lblMissionsValue.Size = new System.Drawing.Size(87, 22);
            this.lblMissionsValue.TabIndex = 10;
            this.lblMissionsValue.Text = "<nom(s)>";
            this.lblMissionsValue.Click += new System.EventHandler(this.lblMissionsValue_Click);
            // 
            // lblAlliesCommun
            // 
            this.lblAlliesCommun.AutoSize = true;
            this.lblAlliesCommun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlliesCommun.Location = new System.Drawing.Point(217, 144);
            this.lblAlliesCommun.Name = "lblAlliesCommun";
            this.lblAlliesCommun.Size = new System.Drawing.Size(63, 22);
            this.lblAlliesCommun.TabIndex = 11;
            this.lblAlliesCommun.Text = "Alliés :";
            // 
            // lblEnnemis
            // 
            this.lblEnnemis.AutoSize = true;
            this.lblEnnemis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnnemis.Location = new System.Drawing.Point(321, 144);
            this.lblEnnemis.Name = "lblEnnemis";
            this.lblEnnemis.Size = new System.Drawing.Size(89, 22);
            this.lblEnnemis.TabIndex = 12;
            this.lblEnnemis.Text = "Ennemis :";
            // 
            // lblAlliesValue
            // 
            this.lblAlliesValue.AutoSize = true;
            this.lblAlliesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlliesValue.Location = new System.Drawing.Point(254, 144);
            this.lblAlliesValue.Name = "lblAlliesValue";
            this.lblAlliesValue.Size = new System.Drawing.Size(85, 22);
            this.lblAlliesValue.TabIndex = 13;
            this.lblAlliesValue.Text = "<% allié>";
            // 
            // lblEnnemisValue
            // 
            this.lblEnnemisValue.AutoSize = true;
            this.lblEnnemisValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnnemisValue.Location = new System.Drawing.Point(378, 144);
            this.lblEnnemisValue.Name = "lblEnnemisValue";
            this.lblEnnemisValue.Size = new System.Drawing.Size(111, 22);
            this.lblEnnemisValue.TabIndex = 14;
            this.lblEnnemisValue.Text = "<% ennemi>";
            // 
            // UserControlPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEnnemisValue);
            this.Controls.Add(this.lblAlliesValue);
            this.Controls.Add(this.lblEnnemis);
            this.Controls.Add(this.lblAlliesCommun);
            this.Controls.Add(this.lblMissionsValue);
            this.Controls.Add(this.lblMissionsCommun);
            this.Controls.Add(this.lblEspecesValue);
            this.Controls.Add(this.lblEspecesCommun);
            this.Controls.Add(this.lblPresenceDatabaz);
            this.Controls.Add(this.lblGraviteValue);
            this.Controls.Add(this.lblGraviteCommun);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.pbTemp);
            this.Controls.Add(this.lblNomPlanete);
            this.Controls.Add(this.pbPlanete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlPlanete";
            this.Size = new System.Drawing.Size(726, 233);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.Label lblNomPlanete;
        private System.Windows.Forms.PictureBox pbTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblGraviteCommun;
        private System.Windows.Forms.Label lblGraviteValue;
        private System.Windows.Forms.Label lblPresenceDatabaz;
        private System.Windows.Forms.Label lblEspecesCommun;
        private System.Windows.Forms.Label lblEspecesValue;
        private System.Windows.Forms.Label lblMissionsCommun;
        private System.Windows.Forms.Label lblMissionsValue;
        private System.Windows.Forms.Label lblAlliesCommun;
        private System.Windows.Forms.Label lblEnnemis;
        private System.Windows.Forms.Label lblAlliesValue;
        private System.Windows.Forms.Label lblEnnemisValue;
    }
}
