namespace ProjetAtlantik
{
    partial class FormModifierBateau
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
            this.lblNomModifierBateau = new System.Windows.Forms.Label();
            this.btnModiferBateau = new System.Windows.Forms.Button();
            this.gbxCapacitesModifierBateau = new System.Windows.Forms.GroupBox();
            this.cmbModifierBateau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNomModifierBateau
            // 
            this.lblNomModifierBateau.AccessibleName = "lblNomModifierBateau";
            this.lblNomModifierBateau.AutoSize = true;
            this.lblNomModifierBateau.Location = new System.Drawing.Point(156, 83);
            this.lblNomModifierBateau.Name = "lblNomModifierBateau";
            this.lblNomModifierBateau.Size = new System.Drawing.Size(71, 13);
            this.lblNomModifierBateau.TabIndex = 7;
            this.lblNomModifierBateau.Text = "Nom bateau :";
            // 
            // btnModiferBateau
            // 
            this.btnModiferBateau.AccessibleName = "btnModiferBateau";
            this.btnModiferBateau.Location = new System.Drawing.Point(233, 331);
            this.btnModiferBateau.Name = "btnModiferBateau";
            this.btnModiferBateau.Size = new System.Drawing.Size(127, 23);
            this.btnModiferBateau.TabIndex = 5;
            this.btnModiferBateau.Text = "Modifier";
            this.btnModiferBateau.UseVisualStyleBackColor = true;
            this.btnModiferBateau.Click += new System.EventHandler(this.btnModiferBateau_Click);
            // 
            // gbxCapacitesModifierBateau
            // 
            this.gbxCapacitesModifierBateau.AccessibleName = "gbxCapacitesModifierBateau";
            this.gbxCapacitesModifierBateau.Location = new System.Drawing.Point(383, 74);
            this.gbxCapacitesModifierBateau.Name = "gbxCapacitesModifierBateau";
            this.gbxCapacitesModifierBateau.Size = new System.Drawing.Size(278, 280);
            this.gbxCapacitesModifierBateau.TabIndex = 4;
            this.gbxCapacitesModifierBateau.TabStop = false;
            this.gbxCapacitesModifierBateau.Text = "Capacités Maximales";
            // 
            // cmbModifierBateau
            // 
            this.cmbModifierBateau.AccessibleName = "cmbModifierBateau";
            this.cmbModifierBateau.FormattingEnabled = true;
            this.cmbModifierBateau.Location = new System.Drawing.Point(233, 80);
            this.cmbModifierBateau.Name = "cmbModifierBateau";
            this.cmbModifierBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbModifierBateau.TabIndex = 8;
            this.cmbModifierBateau.SelectedIndexChanged += new System.EventHandler(this.cmbModifierBateau_SelectedIndexChanged);
            // 
            // FormModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbModifierBateau);
            this.Controls.Add(this.lblNomModifierBateau);
            this.Controls.Add(this.btnModiferBateau);
            this.Controls.Add(this.gbxCapacitesModifierBateau);
            this.Name = "FormModifierBateau";
            this.Text = "FormModifierBateau";
            this.Load += new System.EventHandler(this.FormModifierBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomModifierBateau;
        private System.Windows.Forms.Button btnModiferBateau;
        private System.Windows.Forms.GroupBox gbxCapacitesModifierBateau;
        private System.Windows.Forms.ComboBox cmbModifierBateau;
    }
}