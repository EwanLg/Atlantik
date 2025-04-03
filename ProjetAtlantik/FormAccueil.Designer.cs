namespace ProjetAtlantik
{
    partial class FormAccueil
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
            this.mmAccueil = new System.Windows.Forms.MenuStrip();
            this.msAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnBateauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneLiaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterDesTarifsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneTraverséeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAutres = new System.Windows.Forms.ToolStripMenuItem();
            this.détailsDesRéservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeDisponibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmAccueil
            // 
            this.mmAccueil.AccessibleName = "mmAccueil";
            this.mmAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAjouter,
            this.msAutres,
            this.msAPropos});
            this.mmAccueil.Location = new System.Drawing.Point(0, 0);
            this.mmAccueil.Name = "mmAccueil";
            this.mmAccueil.Size = new System.Drawing.Size(800, 24);
            this.mmAccueil.TabIndex = 0;
            this.mmAccueil.Text = "menuStrip1";
            // 
            // msAjouter
            // 
            this.msAjouter.AccessibleName = "msAjouter";
            this.msAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnBateauToolStripMenuItem,
            this.ajouterUnPortToolStripMenuItem,
            this.ajouterUnSecteurToolStripMenuItem,
            this.ajouterUneLiaisonToolStripMenuItem,
            this.ajouterDesTarifsToolStripMenuItem,
            this.ajouterUneTraverséeToolStripMenuItem});
            this.msAjouter.Name = "msAjouter";
            this.msAjouter.Size = new System.Drawing.Size(58, 20);
            this.msAjouter.Text = "Ajouter";
            // 
            // ajouterUnBateauToolStripMenuItem
            // 
            this.ajouterUnBateauToolStripMenuItem.Name = "ajouterUnBateauToolStripMenuItem";
            this.ajouterUnBateauToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterUnBateauToolStripMenuItem.Text = "Ajouter un Bateau";
            this.ajouterUnBateauToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnBateauToolStripMenuItem_Click);
            // 
            // ajouterUnPortToolStripMenuItem
            // 
            this.ajouterUnPortToolStripMenuItem.Name = "ajouterUnPortToolStripMenuItem";
            this.ajouterUnPortToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterUnPortToolStripMenuItem.Text = "Ajouter un Port";
            this.ajouterUnPortToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnPortToolStripMenuItem_Click);
            // 
            // ajouterUnSecteurToolStripMenuItem
            // 
            this.ajouterUnSecteurToolStripMenuItem.Name = "ajouterUnSecteurToolStripMenuItem";
            this.ajouterUnSecteurToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterUnSecteurToolStripMenuItem.Text = "Ajouter un Secteur";
            this.ajouterUnSecteurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnSecteurToolStripMenuItem_Click);
            // 
            // ajouterUneLiaisonToolStripMenuItem
            // 
            this.ajouterUneLiaisonToolStripMenuItem.Name = "ajouterUneLiaisonToolStripMenuItem";
            this.ajouterUneLiaisonToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterUneLiaisonToolStripMenuItem.Text = "Ajouter une Liaison";
            this.ajouterUneLiaisonToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneLiaisonToolStripMenuItem_Click);
            // 
            // ajouterDesTarifsToolStripMenuItem
            // 
            this.ajouterDesTarifsToolStripMenuItem.Name = "ajouterDesTarifsToolStripMenuItem";
            this.ajouterDesTarifsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterDesTarifsToolStripMenuItem.Text = "Ajouter des Tarifs";
            this.ajouterDesTarifsToolStripMenuItem.Click += new System.EventHandler(this.ajouterDesTarifsToolStripMenuItem_Click);
            // 
            // ajouterUneTraverséeToolStripMenuItem
            // 
            this.ajouterUneTraverséeToolStripMenuItem.Name = "ajouterUneTraverséeToolStripMenuItem";
            this.ajouterUneTraverséeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterUneTraverséeToolStripMenuItem.Text = "Ajouter une Traversée";
            this.ajouterUneTraverséeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneTraverséeToolStripMenuItem_Click);
            // 
            // msAutres
            // 
            this.msAutres.AccessibleName = "msAutres";
            this.msAutres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détailsDesRéservationsToolStripMenuItem,
            this.placeDisponibleToolStripMenuItem});
            this.msAutres.Name = "msAutres";
            this.msAutres.Size = new System.Drawing.Size(53, 20);
            this.msAutres.Text = "Autres";
            // 
            // détailsDesRéservationsToolStripMenuItem
            // 
            this.détailsDesRéservationsToolStripMenuItem.Name = "détailsDesRéservationsToolStripMenuItem";
            this.détailsDesRéservationsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.détailsDesRéservationsToolStripMenuItem.Text = "Détails des réservations";
            this.détailsDesRéservationsToolStripMenuItem.Click += new System.EventHandler(this.détailsDesRéservationsToolStripMenuItem_Click);
            // 
            // placeDisponibleToolStripMenuItem
            // 
            this.placeDisponibleToolStripMenuItem.Name = "placeDisponibleToolStripMenuItem";
            this.placeDisponibleToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.placeDisponibleToolStripMenuItem.Text = "Place Disponible";
            this.placeDisponibleToolStripMenuItem.Click += new System.EventHandler(this.placeDisponibleToolStripMenuItem_Click);
            // 
            // msAPropos
            // 
            this.msAPropos.AccessibleName = "msAPropos";
            this.msAPropos.Name = "msAPropos";
            this.msAPropos.Size = new System.Drawing.Size(67, 20);
            this.msAPropos.Text = "A propos";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetAtlantik.Properties.Resources.Obtenir_place_port_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mmAccueil);
            this.MainMenuStrip = this.mmAccueil;
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.mmAccueil.ResumeLayout(false);
            this.mmAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmAccueil;
        private System.Windows.Forms.ToolStripMenuItem msAjouter;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnBateauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneLiaisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterDesTarifsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msAutres;
        private System.Windows.Forms.ToolStripMenuItem détailsDesRéservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeDisponibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneTraverséeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msAPropos;
    }
}