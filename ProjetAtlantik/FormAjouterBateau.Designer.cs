namespace ProjetAtlantik
{
    partial class FormAjouterBateau
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
            this.gbxCapacitesAjouterBateau = new System.Windows.Forms.GroupBox();
            this.btnAjouterBateau = new System.Windows.Forms.Button();
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.lblNomAjouterBateau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbxCapacitesAjouterBateau
            // 
            this.gbxCapacitesAjouterBateau.AccessibleName = "gbxCapacitesAjouterBateau";
            this.gbxCapacitesAjouterBateau.Location = new System.Drawing.Point(384, 72);
            this.gbxCapacitesAjouterBateau.Name = "gbxCapacitesAjouterBateau";
            this.gbxCapacitesAjouterBateau.Size = new System.Drawing.Size(274, 280);
            this.gbxCapacitesAjouterBateau.TabIndex = 0;
            this.gbxCapacitesAjouterBateau.TabStop = false;
            this.gbxCapacitesAjouterBateau.Text = "Capacités Maximales";
            // 
            // btnAjouterBateau
            // 
            this.btnAjouterBateau.AccessibleName = "btnAjouterBateau";
            this.btnAjouterBateau.Location = new System.Drawing.Point(234, 329);
            this.btnAjouterBateau.Name = "btnAjouterBateau";
            this.btnAjouterBateau.Size = new System.Drawing.Size(127, 23);
            this.btnAjouterBateau.TabIndex = 1;
            this.btnAjouterBateau.Text = "Ajouter";
            this.btnAjouterBateau.UseVisualStyleBackColor = true;
            this.btnAjouterBateau.Click += new System.EventHandler(this.btnAjouterBateau_Click);
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.AccessibleName = "tbxNomBateau";
            this.tbxNomBateau.Location = new System.Drawing.Point(234, 78);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(127, 20);
            this.tbxNomBateau.TabIndex = 2;
            // 
            // lblNomAjouterBateau
            // 
            this.lblNomAjouterBateau.AccessibleName = "lblNomAjouterBateau";
            this.lblNomAjouterBateau.AutoSize = true;
            this.lblNomAjouterBateau.Location = new System.Drawing.Point(157, 81);
            this.lblNomAjouterBateau.Name = "lblNomAjouterBateau";
            this.lblNomAjouterBateau.Size = new System.Drawing.Size(71, 13);
            this.lblNomAjouterBateau.TabIndex = 3;
            this.lblNomAjouterBateau.Text = "Nom bateau :";
            // 
            // FormAjouterBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomAjouterBateau);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.btnAjouterBateau);
            this.Controls.Add(this.gbxCapacitesAjouterBateau);
            this.Name = "FormAjouterBateau";
            this.Text = "FormBateau";
            this.Load += new System.EventHandler(this.FormAjouterBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapacitesAjouterBateau;
        private System.Windows.Forms.Button btnAjouterBateau;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.Label lblNomAjouterBateau;
    }
}