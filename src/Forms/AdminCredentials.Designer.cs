using System.ComponentModel;

namespace ProbenDatenbank.Forms
{
    partial class AdminCredentials
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Location = new System.Drawing.Point(9, 48);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(53, 13);
            this.labelAdminPassword.TabIndex = 2;
            this.labelAdminPassword.Text = "Password";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 88);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 28);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "OK";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(173, 88);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(121, 28);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Abbrechen";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(9, 18);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(285, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Bitte geben Sie das Passwort für die Admin-Verwaltung ein:";
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Location = new System.Drawing.Point(68, 45);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.PasswordChar = '*';
            this.textBoxAdminPassword.Size = new System.Drawing.Size(226, 20);
            this.textBoxAdminPassword.TabIndex = 11;
            // 
            // AdminCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 138);
            this.Controls.Add(this.textBoxAdminPassword);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelAdminPassword);
            this.Name = "AdminCredentials";
            this.Text = "Admin Zugangsdaten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
    }
}