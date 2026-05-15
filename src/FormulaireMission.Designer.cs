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
            this.missionPB1 = new SAE24.MissionPB();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // missionPB1
            // 
            this.missionPB1.Location = new System.Drawing.Point(285, 12);
            this.missionPB1.Name = "missionPB1";
            this.missionPB1.Size = new System.Drawing.Size(230, 171);
            this.missionPB1.TabIndex = 0;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(13, 187);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(44, 16);
            this.lblDepart.TabIndex = 1;
            this.lblDepart.Text = "label1";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(13, 222);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(44, 16);
            this.lblArrivee.TabIndex = 2;
            this.lblArrivee.Text = "label1";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(13, 256);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(44, 16);
            this.lblBudget.TabIndex = 3;
            this.lblBudget.Text = "label1";
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Location = new System.Drawing.Point(13, 291);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(44, 16);
            this.lblSolde.TabIndex = 4;
            this.lblSolde.Text = "label1";
            // 
            // FormulaireMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.missionPB1);
            this.Name = "FormulaireMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireMission";
            this.Load += new System.EventHandler(this.FormulaireMission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MissionPB missionPB1;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblSolde;
    }
}