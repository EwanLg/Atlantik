namespace ProjetAtlantik
{
    partial class FormDétailsRéservation
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
            this.lblNomPrénom = new System.Windows.Forms.Label();
            this.cmbNomPrénom = new System.Windows.Forms.ComboBox();
            this.gbxRéservation = new System.Windows.Forms.GroupBox();
            this.lvRéservation = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblNomPrénom
            // 
            this.lblNomPrénom.AccessibleName = "lblNomPrénom";
            this.lblNomPrénom.AutoSize = true;
            this.lblNomPrénom.Location = new System.Drawing.Point(24, 56);
            this.lblNomPrénom.Name = "lblNomPrénom";
            this.lblNomPrénom.Size = new System.Drawing.Size(77, 13);
            this.lblNomPrénom.TabIndex = 0;
            this.lblNomPrénom.Text = "Nom, Prénom :";
            // 
            // cmbNomPrénom
            // 
            this.cmbNomPrénom.AccessibleName = "cmbNomPrénom";
            this.cmbNomPrénom.FormattingEnabled = true;
            this.cmbNomPrénom.Location = new System.Drawing.Point(107, 53);
            this.cmbNomPrénom.Name = "cmbNomPrénom";
            this.cmbNomPrénom.Size = new System.Drawing.Size(121, 21);
            this.cmbNomPrénom.TabIndex = 1;
            this.cmbNomPrénom.SelectedIndexChanged += new System.EventHandler(this.cmbNomPrénom_SelectedIndexChanged);
            // 
            // gbxRéservation
            // 
            this.gbxRéservation.AccessibleName = "gbxRéservation";
            this.gbxRéservation.Location = new System.Drawing.Point(27, 132);
            this.gbxRéservation.Name = "gbxRéservation";
            this.gbxRéservation.Size = new System.Drawing.Size(225, 291);
            this.gbxRéservation.TabIndex = 3;
            this.gbxRéservation.TabStop = false;
            this.gbxRéservation.Text = "Réservation";
            // 
            // lvRéservation
            // 
            this.lvRéservation.AccessibleName = "lvRéservation";
            this.lvRéservation.HideSelection = false;
            this.lvRéservation.Location = new System.Drawing.Point(288, 44);
            this.lvRéservation.Name = "lvRéservation";
            this.lvRéservation.Size = new System.Drawing.Size(478, 251);
            this.lvRéservation.TabIndex = 4;
            this.lvRéservation.UseCompatibleStateImageBehavior = false;
            // 
            // FormDétailsRéservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvRéservation);
            this.Controls.Add(this.gbxRéservation);
            this.Controls.Add(this.cmbNomPrénom);
            this.Controls.Add(this.lblNomPrénom);
            this.Name = "FormDétailsRéservation";
            this.Text = "FormDétailsRéservation";
            this.Load += new System.EventHandler(this.FormDétailsRéservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPrénom;
        private System.Windows.Forms.ComboBox cmbNomPrénom;
        private System.Windows.Forms.GroupBox gbxRéservation;
        private System.Windows.Forms.ListView lvRéservation;
    }
}