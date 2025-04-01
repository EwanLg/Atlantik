namespace ProjetAtlantik
{
    partial class FormAjouterSecteur
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.tbxAjouterSecteur = new System.Windows.Forms.TextBox();
            this.lblAjouterSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.AccessibleName = "btnAjouterSecteur";
            this.btnAjouterSecteur.Location = new System.Drawing.Point(153, 128);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterSecteur.TabIndex = 0;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // tbxAjouterSecteur
            // 
            this.tbxAjouterSecteur.AccessibleName = "tbxAjouterSecteur";
            this.tbxAjouterSecteur.Location = new System.Drawing.Point(143, 102);
            this.tbxAjouterSecteur.Name = "tbxAjouterSecteur";
            this.tbxAjouterSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxAjouterSecteur.TabIndex = 1;
            // 
            // lblAjouterSecteur
            // 
            this.lblAjouterSecteur.AccessibleName = "lblAjouterSecteur";
            this.lblAjouterSecteur.AutoSize = true;
            this.lblAjouterSecteur.Location = new System.Drawing.Point(35, 105);
            this.lblAjouterSecteur.Name = "lblAjouterSecteur";
            this.lblAjouterSecteur.Size = new System.Drawing.Size(102, 13);
            this.lblAjouterSecteur.TabIndex = 2;
            this.lblAjouterSecteur.Text = "Ajouter un secteur : ";
            // 
            // FormAjouterSecteur
            // 
            this.AccessibleName = "FormAjouterSecteur";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAjouterSecteur);
            this.Controls.Add(this.tbxAjouterSecteur);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Name = "FormAjouterSecteur";
            this.Text = "FormAjouterSecteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterSecteur;
        private System.Windows.Forms.TextBox tbxAjouterSecteur;
        private System.Windows.Forms.Label lblAjouterSecteur;
    }
}

