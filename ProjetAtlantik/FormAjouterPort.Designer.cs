namespace ProjetAtlantik
{
    partial class FormAjouterPort
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
            this.lblAjouterPort = new System.Windows.Forms.Label();
            this.tbxAjouterPort = new System.Windows.Forms.TextBox();
            this.btnAjouterPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAjouterPort
            // 
            this.lblAjouterPort.AccessibleName = "lblAjouterPort";
            this.lblAjouterPort.AutoSize = true;
            this.lblAjouterPort.Location = new System.Drawing.Point(83, 100);
            this.lblAjouterPort.Name = "lblAjouterPort";
            this.lblAjouterPort.Size = new System.Drawing.Size(85, 13);
            this.lblAjouterPort.TabIndex = 5;
            this.lblAjouterPort.Text = "Ajouter un port : ";
            // 
            // tbxAjouterPort
            // 
            this.tbxAjouterPort.AccessibleName = "tbxAjouterPort";
            this.tbxAjouterPort.Location = new System.Drawing.Point(191, 97);
            this.tbxAjouterPort.Name = "tbxAjouterPort";
            this.tbxAjouterPort.Size = new System.Drawing.Size(100, 20);
            this.tbxAjouterPort.TabIndex = 4;
            // 
            // btnAjouterPort
            // 
            this.btnAjouterPort.AccessibleName = "btnAjouterPort";
            this.btnAjouterPort.Location = new System.Drawing.Point(201, 123);
            this.btnAjouterPort.Name = "btnAjouterPort";
            this.btnAjouterPort.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterPort.TabIndex = 3;
            this.btnAjouterPort.Text = "Ajouter";
            this.btnAjouterPort.UseVisualStyleBackColor = true;
            this.btnAjouterPort.Click += new System.EventHandler(this.btnAjouterPort_Click);
            // 
            // FormAjouterPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAjouterPort);
            this.Controls.Add(this.tbxAjouterPort);
            this.Controls.Add(this.btnAjouterPort);
            this.Name = "FormAjouterPort";
            this.Text = "FormAjouterPort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjouterPort;
        private System.Windows.Forms.TextBox tbxAjouterPort;
        private System.Windows.Forms.Button btnAjouterPort;
    }
}