namespace ProjetAtlantik
{
    partial class FormTarifs
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
            this.lbxTarifsSecteur = new System.Windows.Forms.ListBox();
            this.cmbTarifsLiaison = new System.Windows.Forms.ComboBox();
            this.cmbTarifsPeriode = new System.Windows.Forms.ComboBox();
            this.btnTarifsAjouter = new System.Windows.Forms.Button();
            this.lblTarifsPeriode = new System.Windows.Forms.Label();
            this.lblTarifsLiaison = new System.Windows.Forms.Label();
            this.lblTarifsSecteur = new System.Windows.Forms.Label();
            this.gbxTarifsType = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbxTarifsSecteur
            // 
            this.lbxTarifsSecteur.AccessibleName = "lbxTarifsSecteur";
            this.lbxTarifsSecteur.FormattingEnabled = true;
            this.lbxTarifsSecteur.Location = new System.Drawing.Point(43, 64);
            this.lbxTarifsSecteur.Name = "lbxTarifsSecteur";
            this.lbxTarifsSecteur.Size = new System.Drawing.Size(175, 212);
            this.lbxTarifsSecteur.TabIndex = 0;
            this.lbxTarifsSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxTarifsSecteur_SelectedIndexChanged);
            // 
            // cmbTarifsLiaison
            // 
            this.cmbTarifsLiaison.AccessibleName = "cmbTarifsLiaison";
            this.cmbTarifsLiaison.FormattingEnabled = true;
            this.cmbTarifsLiaison.Location = new System.Drawing.Point(43, 306);
            this.cmbTarifsLiaison.Name = "cmbTarifsLiaison";
            this.cmbTarifsLiaison.Size = new System.Drawing.Size(175, 21);
            this.cmbTarifsLiaison.TabIndex = 1;
            this.cmbTarifsLiaison.SelectedIndexChanged += new System.EventHandler(this.cmbTarifsLiaison_SelectedIndexChanged);
            // 
            // cmbTarifsPeriode
            // 
            this.cmbTarifsPeriode.AccessibleName = "cmbTarifsPeriode";
            this.cmbTarifsPeriode.FormattingEnabled = true;
            this.cmbTarifsPeriode.Location = new System.Drawing.Point(269, 362);
            this.cmbTarifsPeriode.Name = "cmbTarifsPeriode";
            this.cmbTarifsPeriode.Size = new System.Drawing.Size(173, 21);
            this.cmbTarifsPeriode.TabIndex = 2;
            // 
            // btnTarifsAjouter
            // 
            this.btnTarifsAjouter.AccessibleName = "btnTarifsAjouter";
            this.btnTarifsAjouter.Location = new System.Drawing.Point(624, 360);
            this.btnTarifsAjouter.Name = "btnTarifsAjouter";
            this.btnTarifsAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnTarifsAjouter.TabIndex = 3;
            this.btnTarifsAjouter.Text = "Ajouter";
            this.btnTarifsAjouter.UseVisualStyleBackColor = true;
            this.btnTarifsAjouter.Click += new System.EventHandler(this.btnTarifsAjouter_Click);
            // 
            // lblTarifsPeriode
            // 
            this.lblTarifsPeriode.AccessibleName = "lblTarifsPeriode";
            this.lblTarifsPeriode.AutoSize = true;
            this.lblTarifsPeriode.Location = new System.Drawing.Point(212, 365);
            this.lblTarifsPeriode.Name = "lblTarifsPeriode";
            this.lblTarifsPeriode.Size = new System.Drawing.Size(49, 13);
            this.lblTarifsPeriode.TabIndex = 4;
            this.lblTarifsPeriode.Text = "Période :";
            // 
            // lblTarifsLiaison
            // 
            this.lblTarifsLiaison.AccessibleName = "lblTarifsLiaison";
            this.lblTarifsLiaison.AutoSize = true;
            this.lblTarifsLiaison.Location = new System.Drawing.Point(40, 290);
            this.lblTarifsLiaison.Name = "lblTarifsLiaison";
            this.lblTarifsLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblTarifsLiaison.TabIndex = 5;
            this.lblTarifsLiaison.Text = "Liaison :";
            // 
            // lblTarifsSecteur
            // 
            this.lblTarifsSecteur.AccessibleName = "lblTarifsSecteur";
            this.lblTarifsSecteur.AutoSize = true;
            this.lblTarifsSecteur.Location = new System.Drawing.Point(40, 48);
            this.lblTarifsSecteur.Name = "lblTarifsSecteur";
            this.lblTarifsSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblTarifsSecteur.TabIndex = 6;
            this.lblTarifsSecteur.Text = "Secteurs :";
            // 
            // gbxTarifsType
            // 
            this.gbxTarifsType.AccessibleName = "gbxTarifsType";
            this.gbxTarifsType.Location = new System.Drawing.Point(451, 46);
            this.gbxTarifsType.Name = "gbxTarifsType";
            this.gbxTarifsType.Size = new System.Drawing.Size(248, 279);
            this.gbxTarifsType.TabIndex = 7;
            this.gbxTarifsType.TabStop = false;
            this.gbxTarifsType.Text = "Tarifs par Catégorie Type";
            // 
            // FormTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxTarifsType);
            this.Controls.Add(this.lblTarifsSecteur);
            this.Controls.Add(this.lblTarifsLiaison);
            this.Controls.Add(this.lblTarifsPeriode);
            this.Controls.Add(this.btnTarifsAjouter);
            this.Controls.Add(this.cmbTarifsPeriode);
            this.Controls.Add(this.cmbTarifsLiaison);
            this.Controls.Add(this.lbxTarifsSecteur);
            this.Name = "FormTarifs";
            this.Text = "FormTarifs";
            this.Load += new System.EventHandler(this.FormTarifs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTarifsSecteur;
        private System.Windows.Forms.ComboBox cmbTarifsLiaison;
        private System.Windows.Forms.ComboBox cmbTarifsPeriode;
        private System.Windows.Forms.Button btnTarifsAjouter;
        private System.Windows.Forms.Label lblTarifsPeriode;
        private System.Windows.Forms.Label lblTarifsLiaison;
        private System.Windows.Forms.Label lblTarifsSecteur;
        private System.Windows.Forms.GroupBox gbxTarifsType;
    }
}