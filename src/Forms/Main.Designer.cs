using System.ComponentModel;

namespace ProbenDatenbank
{
    partial class Main
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
            this.buttonIdAnlegen = new System.Windows.Forms.Button();
            this.buttonBearbeiten = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIdAnlegen
            // 
            this.buttonIdAnlegen.Location = new System.Drawing.Point(14, 14);
            this.buttonIdAnlegen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIdAnlegen.Name = "buttonIdAnlegen";
            this.buttonIdAnlegen.Size = new System.Drawing.Size(250, 75);
            this.buttonIdAnlegen.TabIndex = 1;
            this.buttonIdAnlegen.Text = "ID Anlegen";
            this.buttonIdAnlegen.UseVisualStyleBackColor = true;
            this.buttonIdAnlegen.Click += new System.EventHandler(this.buttonIdAnlegen_Click);
            // 
            // buttonBearbeiten
            // 
            this.buttonBearbeiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBearbeiten.Location = new System.Drawing.Point(14, 103);
            this.buttonBearbeiten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBearbeiten.Name = "buttonBearbeiten";
            this.buttonBearbeiten.Size = new System.Drawing.Size(250, 75);
            this.buttonBearbeiten.TabIndex = 2;
            this.buttonBearbeiten.Text = "Bearbeiten";
            this.buttonBearbeiten.UseVisualStyleBackColor = true;
            this.buttonBearbeiten.Click += new System.EventHandler(this.buttonBearbeiten_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(14, 272);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(250, 50);
            this.buttonAdmin.TabIndex = 6;
            this.buttonAdmin.Text = "Verwaltung/Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 339);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonBearbeiten);
            this.Controls.Add(this.buttonIdAnlegen);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Main";
            this.Text = "Probendatenbank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIdAnlegen;
        private System.Windows.Forms.Button buttonBearbeiten;
        private System.Windows.Forms.Button buttonAdmin;
    }
}