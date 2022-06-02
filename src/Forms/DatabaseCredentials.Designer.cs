using System.ComponentModel;

namespace ProbenDatenbank.Forms
{
    partial class DatabaseCredentials
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
            this.labelDbServer = new System.Windows.Forms.Label();
            this.labelDbUser = new System.Windows.Forms.Label();
            this.labelDbPassword = new System.Windows.Forms.Label();
            this.labelDbDatabase = new System.Windows.Forms.Label();
            this.textBoxDbPassword = new System.Windows.Forms.TextBox();
            this.textBoxDbDatabase = new System.Windows.Forms.TextBox();
            this.textBoxDbUser = new System.Windows.Forms.TextBox();
            this.textBoxDbServer = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDbServer
            // 
            this.labelDbServer.AutoSize = true;
            this.labelDbServer.Location = new System.Drawing.Point(10, 8);
            this.labelDbServer.Name = "labelDbServer";
            this.labelDbServer.Size = new System.Drawing.Size(38, 13);
            this.labelDbServer.TabIndex = 0;
            this.labelDbServer.Text = "Server";
            // 
            // labelDbUser
            // 
            this.labelDbUser.AutoSize = true;
            this.labelDbUser.Location = new System.Drawing.Point(10, 42);
            this.labelDbUser.Name = "labelDbUser";
            this.labelDbUser.Size = new System.Drawing.Size(29, 13);
            this.labelDbUser.TabIndex = 1;
            this.labelDbUser.Text = "User";
            // 
            // labelDbPassword
            // 
            this.labelDbPassword.AutoSize = true;
            this.labelDbPassword.Location = new System.Drawing.Point(10, 79);
            this.labelDbPassword.Name = "labelDbPassword";
            this.labelDbPassword.Size = new System.Drawing.Size(53, 13);
            this.labelDbPassword.TabIndex = 2;
            this.labelDbPassword.Text = "Password";
            // 
            // labelDbDatabase
            // 
            this.labelDbDatabase.AutoSize = true;
            this.labelDbDatabase.Location = new System.Drawing.Point(10, 116);
            this.labelDbDatabase.Name = "labelDbDatabase";
            this.labelDbDatabase.Size = new System.Drawing.Size(53, 13);
            this.labelDbDatabase.TabIndex = 3;
            this.labelDbDatabase.Text = "Database";
            // 
            // textBoxDbPassword
            // 
            this.textBoxDbPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProbenDatenbank.Properties.Settings.Default, "DBConnectionPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDbPassword.Location = new System.Drawing.Point(64, 76);
            this.textBoxDbPassword.Name = "textBoxDbPassword";
            this.textBoxDbPassword.PasswordChar = '*';
            this.textBoxDbPassword.Size = new System.Drawing.Size(244, 20);
            this.textBoxDbPassword.TabIndex = 4;
            this.textBoxDbPassword.Text = global::ProbenDatenbank.Properties.Settings.Default.DBConnectionPassword;
            // 
            // textBoxDbDatabase
            // 
            this.textBoxDbDatabase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProbenDatenbank.Properties.Settings.Default, "DBConnectionDatabase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDbDatabase.Location = new System.Drawing.Point(64, 114);
            this.textBoxDbDatabase.Name = "textBoxDbDatabase";
            this.textBoxDbDatabase.Size = new System.Drawing.Size(244, 20);
            this.textBoxDbDatabase.TabIndex = 5;
            this.textBoxDbDatabase.Text = global::ProbenDatenbank.Properties.Settings.Default.DBConnectionDatabase;
            // 
            // textBoxDbUser
            // 
            this.textBoxDbUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProbenDatenbank.Properties.Settings.Default, "DBConnectionUID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDbUser.Location = new System.Drawing.Point(64, 39);
            this.textBoxDbUser.Name = "textBoxDbUser";
            this.textBoxDbUser.Size = new System.Drawing.Size(244, 20);
            this.textBoxDbUser.TabIndex = 6;
            this.textBoxDbUser.Text = global::ProbenDatenbank.Properties.Settings.Default.DBConnectionUID;
            // 
            // textBoxDbServer
            // 
            this.textBoxDbServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProbenDatenbank.Properties.Settings.Default, "DBConnectionServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDbServer.Location = new System.Drawing.Point(64, 5);
            this.textBoxDbServer.Name = "textBoxDbServer";
            this.textBoxDbServer.Size = new System.Drawing.Size(244, 20);
            this.textBoxDbServer.TabIndex = 7;
            this.textBoxDbServer.Text = global::ProbenDatenbank.Properties.Settings.Default.DBConnectionServer;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(10, 156);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 28);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(187, 156);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(121, 28);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Beenden";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // DatabaseCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 194);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDbServer);
            this.Controls.Add(this.textBoxDbUser);
            this.Controls.Add(this.textBoxDbDatabase);
            this.Controls.Add(this.textBoxDbPassword);
            this.Controls.Add(this.labelDbDatabase);
            this.Controls.Add(this.labelDbPassword);
            this.Controls.Add(this.labelDbUser);
            this.Controls.Add(this.labelDbServer);
            this.Name = "DatabaseCredentials";
            this.Text = "Datenbank Zugangsdaten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDbServer;
        private System.Windows.Forms.Label labelDbUser;
        private System.Windows.Forms.Label labelDbPassword;
        private System.Windows.Forms.Label labelDbDatabase;
        private System.Windows.Forms.TextBox textBoxDbPassword;
        private System.Windows.Forms.TextBox textBoxDbDatabase;
        private System.Windows.Forms.TextBox textBoxDbUser;
        private System.Windows.Forms.TextBox textBoxDbServer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonStop;
    }
}