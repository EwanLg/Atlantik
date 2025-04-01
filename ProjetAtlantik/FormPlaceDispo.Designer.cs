namespace ProjetAtlantik
{
    partial class FormPlaceDispo
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
            this.lbxPlaceDispoSecteur = new System.Windows.Forms.ListBox();
            this.cmbPlaceDispoLiaison = new System.Windows.Forms.ComboBox();
            this.btnPlaceDispoAfficher = new System.Windows.Forms.Button();
            this.dtpPlaceDispo = new System.Windows.Forms.DateTimePicker();
            this.lblPlaceDispoSecteur = new System.Windows.Forms.Label();
            this.lblPlaceDispoLiaison = new System.Windows.Forms.Label();
            this.lblPlaceDispoDate = new System.Windows.Forms.Label();
            this.lblTraversée = new System.Windows.Forms.Label();
            this.lblPlaceDispo = new System.Windows.Forms.Label();
            this.lvPlaceDispo = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbxPlaceDispoSecteur
            // 
            this.lbxPlaceDispoSecteur.AccessibleName = "lbxPlaceDispoSecteur";
            this.lbxPlaceDispoSecteur.FormattingEnabled = true;
            this.lbxPlaceDispoSecteur.Location = new System.Drawing.Point(12, 28);
            this.lbxPlaceDispoSecteur.Name = "lbxPlaceDispoSecteur";
            this.lbxPlaceDispoSecteur.Size = new System.Drawing.Size(146, 290);
            this.lbxPlaceDispoSecteur.TabIndex = 0;
            // 
            // cmbPlaceDispoLiaison
            // 
            this.cmbPlaceDispoLiaison.AccessibleName = "cmbPlaceDispoLiaison";
            this.cmbPlaceDispoLiaison.FormattingEnabled = true;
            this.cmbPlaceDispoLiaison.Location = new System.Drawing.Point(12, 338);
            this.cmbPlaceDispoLiaison.Name = "cmbPlaceDispoLiaison";
            this.cmbPlaceDispoLiaison.Size = new System.Drawing.Size(159, 21);
            this.cmbPlaceDispoLiaison.TabIndex = 1;
            // 
            // btnPlaceDispoAfficher
            // 
            this.btnPlaceDispoAfficher.AccessibleName = "btnPlaceDispoAfficher";
            this.btnPlaceDispoAfficher.Location = new System.Drawing.Point(9, 404);
            this.btnPlaceDispoAfficher.Name = "btnPlaceDispoAfficher";
            this.btnPlaceDispoAfficher.Size = new System.Drawing.Size(162, 23);
            this.btnPlaceDispoAfficher.TabIndex = 2;
            this.btnPlaceDispoAfficher.Text = "Afficher les traversées";
            this.btnPlaceDispoAfficher.UseVisualStyleBackColor = true;
            this.btnPlaceDispoAfficher.Click += new System.EventHandler(this.btnPlaceDispoAfficher_Click);
            // 
            // dtpPlaceDispo
            // 
            this.dtpPlaceDispo.AccessibleName = "dtpPlaceDispo";
            this.dtpPlaceDispo.Location = new System.Drawing.Point(9, 378);
            this.dtpPlaceDispo.Name = "dtpPlaceDispo";
            this.dtpPlaceDispo.Size = new System.Drawing.Size(162, 20);
            this.dtpPlaceDispo.TabIndex = 3;
            // 
            // lblPlaceDispoSecteur
            // 
            this.lblPlaceDispoSecteur.AccessibleName = "lblPlaceDispoSecteur";
            this.lblPlaceDispoSecteur.AutoSize = true;
            this.lblPlaceDispoSecteur.Location = new System.Drawing.Point(12, 9);
            this.lblPlaceDispoSecteur.Name = "lblPlaceDispoSecteur";
            this.lblPlaceDispoSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblPlaceDispoSecteur.TabIndex = 4;
            this.lblPlaceDispoSecteur.Text = "Secteurs :";
            // 
            // lblPlaceDispoLiaison
            // 
            this.lblPlaceDispoLiaison.AccessibleName = "lblPlaceDispoLiaison";
            this.lblPlaceDispoLiaison.AutoSize = true;
            this.lblPlaceDispoLiaison.Location = new System.Drawing.Point(12, 322);
            this.lblPlaceDispoLiaison.Name = "lblPlaceDispoLiaison";
            this.lblPlaceDispoLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblPlaceDispoLiaison.TabIndex = 5;
            this.lblPlaceDispoLiaison.Text = "Liaison :";
            // 
            // lblPlaceDispoDate
            // 
            this.lblPlaceDispoDate.AccessibleName = "lblPlaceDispoDate";
            this.lblPlaceDispoDate.AutoSize = true;
            this.lblPlaceDispoDate.Location = new System.Drawing.Point(12, 362);
            this.lblPlaceDispoDate.Name = "lblPlaceDispoDate";
            this.lblPlaceDispoDate.Size = new System.Drawing.Size(152, 13);
            this.lblPlaceDispoDate.TabIndex = 6;
            this.lblPlaceDispoDate.Text = "Date (par défaut date du jour) :";
            // 
            // lblTraversée
            // 
            this.lblTraversée.AccessibleName = "lblTraversée";
            this.lblTraversée.AutoSize = true;
            this.lblTraversée.Location = new System.Drawing.Point(186, 28);
            this.lblTraversée.Name = "lblTraversée";
            this.lblTraversée.Size = new System.Drawing.Size(61, 13);
            this.lblTraversée.TabIndex = 8;
            this.lblTraversée.Text = "Traversée :";
            // 
            // lblPlaceDispo
            // 
            this.lblPlaceDispo.AccessibleName = "lblPlaceDispo";
            this.lblPlaceDispo.AutoSize = true;
            this.lblPlaceDispo.Location = new System.Drawing.Point(638, 28);
            this.lblPlaceDispo.Name = "lblPlaceDispo";
            this.lblPlaceDispo.Size = new System.Drawing.Size(133, 13);
            this.lblPlaceDispo.TabIndex = 9;
            this.lblPlaceDispo.Text = ": Place dispo par catégorie";
            this.lblPlaceDispo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lvPlaceDispo
            // 
            this.lvPlaceDispo.AccessibleName = "lvPlaceDispo";
            this.lvPlaceDispo.HideSelection = false;
            this.lvPlaceDispo.Location = new System.Drawing.Point(189, 44);
            this.lvPlaceDispo.Name = "lvPlaceDispo";
            this.lvPlaceDispo.Size = new System.Drawing.Size(582, 383);
            this.lvPlaceDispo.TabIndex = 10;
            this.lvPlaceDispo.UseCompatibleStateImageBehavior = false;
            // 
            // FormPlaceDispo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvPlaceDispo);
            this.Controls.Add(this.lblPlaceDispo);
            this.Controls.Add(this.lblTraversée);
            this.Controls.Add(this.lblPlaceDispoDate);
            this.Controls.Add(this.lblPlaceDispoLiaison);
            this.Controls.Add(this.lblPlaceDispoSecteur);
            this.Controls.Add(this.dtpPlaceDispo);
            this.Controls.Add(this.btnPlaceDispoAfficher);
            this.Controls.Add(this.cmbPlaceDispoLiaison);
            this.Controls.Add(this.lbxPlaceDispoSecteur);
            this.Name = "FormPlaceDispo";
            this.Text = "b";
            this.Load += new System.EventHandler(this.FormPlaceDispo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPlaceDispoSecteur;
        private System.Windows.Forms.ComboBox cmbPlaceDispoLiaison;
        private System.Windows.Forms.Button btnPlaceDispoAfficher;
        private System.Windows.Forms.DateTimePicker dtpPlaceDispo;
        private System.Windows.Forms.Label lblPlaceDispoSecteur;
        private System.Windows.Forms.Label lblPlaceDispoLiaison;
        private System.Windows.Forms.Label lblPlaceDispoDate;
        private System.Windows.Forms.Label lblTraversée;
        private System.Windows.Forms.Label lblPlaceDispo;
        private System.Windows.Forms.ListView lvPlaceDispo;
    }
}