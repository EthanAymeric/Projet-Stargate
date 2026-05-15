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
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.grpFeuilleRoute = new System.Windows.Forms.GroupBox();
            this.missionPB1 = new SAE24.MissionPB();
            this.grpMembre = new System.Windows.Forms.GroupBox();
            this.pnlMembre = new System.Windows.Forms.Panel();
            this.grpCaptures = new System.Windows.Forms.GroupBox();
            this.txtFeuilleRoute = new System.Windows.Forms.RichTextBox();
            this.txtCaptures = new System.Windows.Forms.RichTextBox();
            this.grpFeuilleRoute.SuspendLayout();
            this.grpMembre.SuspendLayout();
            this.grpCaptures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(10, 152);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(35, 13);
            this.lblDepart.TabIndex = 1;
            this.lblDepart.Text = "label1";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(10, 180);
            this.lblArrivee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(35, 13);
            this.lblArrivee.TabIndex = 2;
            this.lblArrivee.Text = "label1";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(10, 208);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(35, 13);
            this.lblBudget.TabIndex = 3;
            this.lblBudget.Text = "label1";
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Location = new System.Drawing.Point(10, 236);
            this.lblSolde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(35, 13);
            this.lblSolde.TabIndex = 4;
            this.lblSolde.Text = "label1";
            // 
            // grpFeuilleRoute
            // 
            this.grpFeuilleRoute.Controls.Add(this.txtFeuilleRoute);
            this.grpFeuilleRoute.Location = new System.Drawing.Point(12, 263);
            this.grpFeuilleRoute.Name = "grpFeuilleRoute";
            this.grpFeuilleRoute.Size = new System.Drawing.Size(586, 153);
            this.grpFeuilleRoute.TabIndex = 6;
            this.grpFeuilleRoute.TabStop = false;
            this.grpFeuilleRoute.Text = "Feuille de route";
            // 
            // missionPB1
            // 
            this.missionPB1.Location = new System.Drawing.Point(214, 10);
            this.missionPB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.missionPB1.Name = "missionPB1";
            this.missionPB1.Size = new System.Drawing.Size(172, 139);
            this.missionPB1.TabIndex = 0;
            // 
            // grpMembre
            // 
            this.grpMembre.Controls.Add(this.pnlMembre);
            this.grpMembre.Location = new System.Drawing.Point(12, 423);
            this.grpMembre.Name = "grpMembre";
            this.grpMembre.Size = new System.Drawing.Size(576, 181);
            this.grpMembre.TabIndex = 7;
            this.grpMembre.TabStop = false;
            this.grpMembre.Text = "Membre de l\'équipage";
            // 
            // pnlMembre
            // 
            this.pnlMembre.AutoScroll = true;
            this.pnlMembre.Location = new System.Drawing.Point(7, 20);
            this.pnlMembre.Name = "pnlMembre";
            this.pnlMembre.Size = new System.Drawing.Size(563, 155);
            this.pnlMembre.TabIndex = 0;
            // 
            // grpCaptures
            // 
            this.grpCaptures.Controls.Add(this.txtCaptures);
            this.grpCaptures.Location = new System.Drawing.Point(12, 611);
            this.grpCaptures.Name = "grpCaptures";
            this.grpCaptures.Size = new System.Drawing.Size(586, 126);
            this.grpCaptures.TabIndex = 8;
            this.grpCaptures.TabStop = false;
            this.grpCaptures.Text = "Objectifs (captures)";
            // 
            // txtFeuilleRoute
            // 
            this.txtFeuilleRoute.Location = new System.Drawing.Point(7, 19);
            this.txtFeuilleRoute.Name = "txtFeuilleRoute";
            this.txtFeuilleRoute.ReadOnly = true;
            this.txtFeuilleRoute.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtFeuilleRoute.Size = new System.Drawing.Size(573, 128);
            this.txtFeuilleRoute.TabIndex = 6;
            this.txtFeuilleRoute.Text = "";
            // 
            // txtCaptures
            // 
            this.txtCaptures.Location = new System.Drawing.Point(7, 20);
            this.txtCaptures.Name = "txtCaptures";
            this.txtCaptures.ReadOnly = true;
            this.txtCaptures.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCaptures.Size = new System.Drawing.Size(573, 101);
            this.txtCaptures.TabIndex = 0;
            this.txtCaptures.Text = "";
            // 
            // FormulaireMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 744);
            this.Controls.Add(this.grpCaptures);
            this.Controls.Add(this.grpMembre);
            this.Controls.Add(this.grpFeuilleRoute);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.missionPB1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormulaireMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireMission";
            this.Load += new System.EventHandler(this.FormulaireMission_Load);
            this.grpFeuilleRoute.ResumeLayout(false);
            this.grpMembre.ResumeLayout(false);
            this.grpCaptures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MissionPB missionPB1;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.GroupBox grpFeuilleRoute;
        private System.Windows.Forms.GroupBox grpMembre;
        private System.Windows.Forms.Panel pnlMembre;
        private System.Windows.Forms.GroupBox grpCaptures;
        private System.Windows.Forms.RichTextBox txtFeuilleRoute;
        private System.Windows.Forms.RichTextBox txtCaptures;
    }
}