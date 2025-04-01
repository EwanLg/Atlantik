namespace ProjetAtlantik
{
    partial class FormLiaison
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
            this.cmbLiaisonDepart = new System.Windows.Forms.ComboBox();
            this.lbxLiaisonSecteur = new System.Windows.Forms.ListBox();
            this.cmbLiaisonArrivee = new System.Windows.Forms.ComboBox();
            this.tbxLiaison = new System.Windows.Forms.TextBox();
            this.btnLiaisonAjouter = new System.Windows.Forms.Button();
            this.lblLiaisonSecteur = new System.Windows.Forms.Label();
            this.lblLiaisonDepart = new System.Windows.Forms.Label();
            this.lblLiaisonArrivee = new System.Windows.Forms.Label();
            this.lblLiaisonDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLiaisonDepart
            // 
            this.cmbLiaisonDepart.AccessibleName = "cmbLiaisonDepart";
            this.cmbLiaisonDepart.FormattingEnabled = true;
            this.cmbLiaisonDepart.Location = new System.Drawing.Point(329, 95);
            this.cmbLiaisonDepart.Name = "cmbLiaisonDepart";
            this.cmbLiaisonDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaisonDepart.TabIndex = 0;
            // 
            // lbxLiaisonSecteur
            // 
            this.lbxLiaisonSecteur.AccessibleName = "lbxLiaisonSecteur";
            this.lbxLiaisonSecteur.FormattingEnabled = true;
            this.lbxLiaisonSecteur.Location = new System.Drawing.Point(65, 95);
            this.lbxLiaisonSecteur.Name = "lbxLiaisonSecteur";
            this.lbxLiaisonSecteur.Size = new System.Drawing.Size(120, 160);
            this.lbxLiaisonSecteur.TabIndex = 1;
            // 
            // cmbLiaisonArrivee
            // 
            this.cmbLiaisonArrivee.AccessibleName = "cmbLiaisonArrivee";
            this.cmbLiaisonArrivee.FormattingEnabled = true;
            this.cmbLiaisonArrivee.Location = new System.Drawing.Point(590, 95);
            this.cmbLiaisonArrivee.Name = "cmbLiaisonArrivee";
            this.cmbLiaisonArrivee.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaisonArrivee.TabIndex = 2;
            // 
            // tbxLiaison
            // 
            this.tbxLiaison.AccessibleName = "tbxLiaison";
            this.tbxLiaison.Location = new System.Drawing.Point(611, 257);
            this.tbxLiaison.Name = "tbxLiaison";
            this.tbxLiaison.Size = new System.Drawing.Size(100, 20);
            this.tbxLiaison.TabIndex = 3;
            // 
            // btnLiaisonAjouter
            // 
            this.btnLiaisonAjouter.AccessibleName = "btnLiaisonAjouter";
            this.btnLiaisonAjouter.Location = new System.Drawing.Point(636, 324);
            this.btnLiaisonAjouter.Name = "btnLiaisonAjouter";
            this.btnLiaisonAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnLiaisonAjouter.TabIndex = 4;
            this.btnLiaisonAjouter.Text = "Ajouter";
            this.btnLiaisonAjouter.UseVisualStyleBackColor = true;
            this.btnLiaisonAjouter.Click += new System.EventHandler(this.btnLiaisonAjouter_Click);
            // 
            // lblLiaisonSecteur
            // 
            this.lblLiaisonSecteur.AccessibleName = "lblLiaisonSecteur";
            this.lblLiaisonSecteur.AutoSize = true;
            this.lblLiaisonSecteur.Location = new System.Drawing.Point(62, 69);
            this.lblLiaisonSecteur.Name = "lblLiaisonSecteur";
            this.lblLiaisonSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblLiaisonSecteur.TabIndex = 5;
            this.lblLiaisonSecteur.Text = "Secteurs :";
            // 
            // lblLiaisonDepart
            // 
            this.lblLiaisonDepart.AccessibleName = "lblLiaisonDepart";
            this.lblLiaisonDepart.AutoSize = true;
            this.lblLiaisonDepart.Location = new System.Drawing.Point(278, 98);
            this.lblLiaisonDepart.Name = "lblLiaisonDepart";
            this.lblLiaisonDepart.Size = new System.Drawing.Size(45, 13);
            this.lblLiaisonDepart.TabIndex = 6;
            this.lblLiaisonDepart.Text = "Départ :";
            // 
            // lblLiaisonArrivee
            // 
            this.lblLiaisonArrivee.AccessibleName = "lblLiaisonArrivee";
            this.lblLiaisonArrivee.AutoSize = true;
            this.lblLiaisonArrivee.Location = new System.Drawing.Point(538, 98);
            this.lblLiaisonArrivee.Name = "lblLiaisonArrivee";
            this.lblLiaisonArrivee.Size = new System.Drawing.Size(46, 13);
            this.lblLiaisonArrivee.TabIndex = 7;
            this.lblLiaisonArrivee.Text = "Arrivée :";
            // 
            // lblLiaisonDistance
            // 
            this.lblLiaisonDistance.AccessibleName = "lblLiaisonDistance";
            this.lblLiaisonDistance.AutoSize = true;
            this.lblLiaisonDistance.Location = new System.Drawing.Point(547, 260);
            this.lblLiaisonDistance.Name = "lblLiaisonDistance";
            this.lblLiaisonDistance.Size = new System.Drawing.Size(58, 13);
            this.lblLiaisonDistance.TabIndex = 8;
            this.lblLiaisonDistance.Text = "Distance : ";
            // 
            // FormLiaison
            // 
            this.AccessibleName = "FormLiaison";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLiaisonDistance);
            this.Controls.Add(this.lblLiaisonArrivee);
            this.Controls.Add(this.lblLiaisonDepart);
            this.Controls.Add(this.lblLiaisonSecteur);
            this.Controls.Add(this.btnLiaisonAjouter);
            this.Controls.Add(this.tbxLiaison);
            this.Controls.Add(this.cmbLiaisonArrivee);
            this.Controls.Add(this.lbxLiaisonSecteur);
            this.Controls.Add(this.cmbLiaisonDepart);
            this.Name = "FormLiaison";
            this.Text = "FormLiaison";
            this.Load += new System.EventHandler(this.FormLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLiaisonDepart;
        private System.Windows.Forms.ListBox lbxLiaisonSecteur;
        private System.Windows.Forms.ComboBox cmbLiaisonArrivee;
        private System.Windows.Forms.TextBox tbxLiaison;
        private System.Windows.Forms.Button btnLiaisonAjouter;
        private System.Windows.Forms.Label lblLiaisonSecteur;
        private System.Windows.Forms.Label lblLiaisonDepart;
        private System.Windows.Forms.Label lblLiaisonArrivee;
        private System.Windows.Forms.Label lblLiaisonDistance;
    }
}