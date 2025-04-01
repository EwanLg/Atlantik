namespace ProjetAtlantik
{
    partial class FormTraversée
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
            this.lbxSecteurTraversée = new System.Windows.Forms.ListBox();
            this.cmbLiaisonTraversée = new System.Windows.Forms.ComboBox();
            this.cmbNomBateauTraversée = new System.Windows.Forms.ComboBox();
            this.btnAjouterTraversée = new System.Windows.Forms.Button();
            this.dtpTraverséeDépartJour = new System.Windows.Forms.DateTimePicker();
            this.dtpTraverséeDépartHeure = new System.Windows.Forms.DateTimePicker();
            this.dtpTraverséeArrivéeJour = new System.Windows.Forms.DateTimePicker();
            this.dtpTraverséeArrivéeHeure = new System.Windows.Forms.DateTimePicker();
            this.lblTraverséeSecteur = new System.Windows.Forms.Label();
            this.lblTraverséeLiaison = new System.Windows.Forms.Label();
            this.lblTraverséeBateau = new System.Windows.Forms.Label();
            this.lblTraverséeDépart = new System.Windows.Forms.Label();
            this.lblTraverséeArrivée = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxSecteurTraversée
            // 
            this.lbxSecteurTraversée.AccessibleName = "lbxSecteurTraversée";
            this.lbxSecteurTraversée.FormattingEnabled = true;
            this.lbxSecteurTraversée.Location = new System.Drawing.Point(82, 63);
            this.lbxSecteurTraversée.Name = "lbxSecteurTraversée";
            this.lbxSecteurTraversée.Size = new System.Drawing.Size(191, 238);
            this.lbxSecteurTraversée.TabIndex = 0;
            this.lbxSecteurTraversée.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurTraversée_SelectedIndexChanged);
            // 
            // cmbLiaisonTraversée
            // 
            this.cmbLiaisonTraversée.AccessibleName = "cmbLiaisonTraversée";
            this.cmbLiaisonTraversée.FormattingEnabled = true;
            this.cmbLiaisonTraversée.Location = new System.Drawing.Point(82, 346);
            this.cmbLiaisonTraversée.Name = "cmbLiaisonTraversée";
            this.cmbLiaisonTraversée.Size = new System.Drawing.Size(191, 21);
            this.cmbLiaisonTraversée.TabIndex = 1;
            // 
            // cmbNomBateauTraversée
            // 
            this.cmbNomBateauTraversée.AccessibleName = "cmbNomBateauTraversée";
            this.cmbNomBateauTraversée.FormattingEnabled = true;
            this.cmbNomBateauTraversée.Location = new System.Drawing.Point(480, 63);
            this.cmbNomBateauTraversée.Name = "cmbNomBateauTraversée";
            this.cmbNomBateauTraversée.Size = new System.Drawing.Size(196, 21);
            this.cmbNomBateauTraversée.TabIndex = 2;
            // 
            // btnAjouterTraversée
            // 
            this.btnAjouterTraversée.AccessibleName = "btnAjouterTraversée";
            this.btnAjouterTraversée.Location = new System.Drawing.Point(601, 335);
            this.btnAjouterTraversée.Name = "btnAjouterTraversée";
            this.btnAjouterTraversée.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTraversée.TabIndex = 3;
            this.btnAjouterTraversée.Text = "Ajouter";
            this.btnAjouterTraversée.UseVisualStyleBackColor = true;
            this.btnAjouterTraversée.Click += new System.EventHandler(this.btnAjouterTraversée_Click);
            // 
            // dtpTraverséeDépartJour
            // 
            this.dtpTraverséeDépartJour.AccessibleName = "dtpTraverséeDépartJour";
            this.dtpTraverséeDépartJour.Location = new System.Drawing.Point(426, 186);
            this.dtpTraverséeDépartJour.Name = "dtpTraverséeDépartJour";
            this.dtpTraverséeDépartJour.Size = new System.Drawing.Size(122, 20);
            this.dtpTraverséeDépartJour.TabIndex = 4;
            // 
            // dtpTraverséeDépartHeure
            // 
            this.dtpTraverséeDépartHeure.AccessibleName = "dtpTraverséeDépartHeure";
            this.dtpTraverséeDépartHeure.Location = new System.Drawing.Point(554, 186);
            this.dtpTraverséeDépartHeure.Name = "dtpTraverséeDépartHeure";
            this.dtpTraverséeDépartHeure.Size = new System.Drawing.Size(122, 20);
            this.dtpTraverséeDépartHeure.TabIndex = 5;
            // 
            // dtpTraverséeArrivéeJour
            // 
            this.dtpTraverséeArrivéeJour.AccessibleName = "dtpTraverséeArrivéeJour";
            this.dtpTraverséeArrivéeJour.Location = new System.Drawing.Point(426, 212);
            this.dtpTraverséeArrivéeJour.Name = "dtpTraverséeArrivéeJour";
            this.dtpTraverséeArrivéeJour.Size = new System.Drawing.Size(122, 20);
            this.dtpTraverséeArrivéeJour.TabIndex = 6;
            // 
            // dtpTraverséeArrivéeHeure
            // 
            this.dtpTraverséeArrivéeHeure.AccessibleName = "dtpTraverséeDépartHeure";
            this.dtpTraverséeArrivéeHeure.Location = new System.Drawing.Point(554, 212);
            this.dtpTraverséeArrivéeHeure.Name = "dtpTraverséeArrivéeHeure";
            this.dtpTraverséeArrivéeHeure.Size = new System.Drawing.Size(122, 20);
            this.dtpTraverséeArrivéeHeure.TabIndex = 7;
            // 
            // lblTraverséeSecteur
            // 
            this.lblTraverséeSecteur.AccessibleName = "lblTraverséeSecteur";
            this.lblTraverséeSecteur.AutoSize = true;
            this.lblTraverséeSecteur.Location = new System.Drawing.Point(82, 44);
            this.lblTraverséeSecteur.Name = "lblTraverséeSecteur";
            this.lblTraverséeSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblTraverséeSecteur.TabIndex = 8;
            this.lblTraverséeSecteur.Text = "Secteurs :";
            // 
            // lblTraverséeLiaison
            // 
            this.lblTraverséeLiaison.AccessibleName = "lblTraverséeLiaison";
            this.lblTraverséeLiaison.AutoSize = true;
            this.lblTraverséeLiaison.Location = new System.Drawing.Point(82, 327);
            this.lblTraverséeLiaison.Name = "lblTraverséeLiaison";
            this.lblTraverséeLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblTraverséeLiaison.TabIndex = 9;
            this.lblTraverséeLiaison.Text = "Liaison :";
            // 
            // lblTraverséeBateau
            // 
            this.lblTraverséeBateau.AccessibleName = "lblTraverséeBateau";
            this.lblTraverséeBateau.AutoSize = true;
            this.lblTraverséeBateau.Location = new System.Drawing.Point(402, 66);
            this.lblTraverséeBateau.Name = "lblTraverséeBateau";
            this.lblTraverséeBateau.Size = new System.Drawing.Size(72, 13);
            this.lblTraverséeBateau.TabIndex = 10;
            this.lblTraverséeBateau.Text = "Nom Bateau :";
            // 
            // lblTraverséeDépart
            // 
            this.lblTraverséeDépart.AccessibleName = "lblTraverséeDépart";
            this.lblTraverséeDépart.AutoSize = true;
            this.lblTraverséeDépart.Location = new System.Drawing.Point(309, 186);
            this.lblTraverséeDépart.Name = "lblTraverséeDépart";
            this.lblTraverséeDépart.Size = new System.Drawing.Size(111, 13);
            this.lblTraverséeDépart.TabIndex = 11;
            this.lblTraverséeDépart.Text = "Date et heure départ :";
            // 
            // lblTraverséeArrivée
            // 
            this.lblTraverséeArrivée.AccessibleName = "lblTraverséeArrivée";
            this.lblTraverséeArrivée.AutoSize = true;
            this.lblTraverséeArrivée.Location = new System.Drawing.Point(309, 212);
            this.lblTraverséeArrivée.Name = "lblTraverséeArrivée";
            this.lblTraverséeArrivée.Size = new System.Drawing.Size(113, 13);
            this.lblTraverséeArrivée.TabIndex = 12;
            this.lblTraverséeArrivée.Text = "Date et heure arrivée :";
            // 
            // FormTraversée
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTraverséeArrivée);
            this.Controls.Add(this.lblTraverséeDépart);
            this.Controls.Add(this.lblTraverséeBateau);
            this.Controls.Add(this.lblTraverséeLiaison);
            this.Controls.Add(this.lblTraverséeSecteur);
            this.Controls.Add(this.dtpTraverséeArrivéeHeure);
            this.Controls.Add(this.dtpTraverséeArrivéeJour);
            this.Controls.Add(this.dtpTraverséeDépartHeure);
            this.Controls.Add(this.dtpTraverséeDépartJour);
            this.Controls.Add(this.btnAjouterTraversée);
            this.Controls.Add(this.cmbNomBateauTraversée);
            this.Controls.Add(this.cmbLiaisonTraversée);
            this.Controls.Add(this.lbxSecteurTraversée);
            this.Name = "FormTraversée";
            this.Text = "FormTraversée";
            this.Load += new System.EventHandler(this.FormTraversée_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteurTraversée;
        private System.Windows.Forms.ComboBox cmbLiaisonTraversée;
        private System.Windows.Forms.ComboBox cmbNomBateauTraversée;
        private System.Windows.Forms.Button btnAjouterTraversée;
        private System.Windows.Forms.DateTimePicker dtpTraverséeDépartJour;
        private System.Windows.Forms.DateTimePicker dtpTraverséeDépartHeure;
        private System.Windows.Forms.DateTimePicker dtpTraverséeArrivéeJour;
        private System.Windows.Forms.DateTimePicker dtpTraverséeArrivéeHeure;
        private System.Windows.Forms.Label lblTraverséeSecteur;
        private System.Windows.Forms.Label lblTraverséeLiaison;
        private System.Windows.Forms.Label lblTraverséeBateau;
        private System.Windows.Forms.Label lblTraverséeDépart;
        private System.Windows.Forms.Label lblTraverséeArrivée;
    }
}