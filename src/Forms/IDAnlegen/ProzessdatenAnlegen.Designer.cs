
namespace ProbenDatenbank.src.Forms.IDAnlegen
{
    partial class ProzessdatenAnlegen
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReihennummer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRotation = new System.Windows.Forms.ComboBox();
            this.listBoxProzessDaten = new System.Windows.Forms.ListBox();
            this.listBoxLogDaten = new System.Windows.Forms.ListBox();
            this.listBoxChargenDaten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(25, 619);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 54);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Zurück";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(943, 619);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 54);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label27.Location = new System.Drawing.Point(22, 18);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 18);
            this.label27.TabIndex = 112;
            this.label27.Text = "Rotation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 118;
            this.label1.Text = "Prozess Daten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label2.Location = new System.Drawing.Point(22, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 120;
            this.label2.Text = "Log Daten";
            // 
            // textBoxReihennummer
            // 
            this.textBoxReihennummer.Location = new System.Drawing.Point(190, 52);
            this.textBoxReihennummer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReihennummer.Name = "textBoxReihennummer";
            this.textBoxReihennummer.Size = new System.Drawing.Size(281, 20);
            this.textBoxReihennummer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 122;
            this.label3.Text = "Reihennummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label4.Location = new System.Drawing.Point(22, 440);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 125;
            this.label4.Text = "Chargen Daten";
            // 
            // comboBoxRotation
            // 
            this.comboBoxRotation.FormattingEnabled = true;
            this.comboBoxRotation.Location = new System.Drawing.Point(190, 18);
            this.comboBoxRotation.Name = "comboBoxRotation";
            this.comboBoxRotation.Size = new System.Drawing.Size(281, 21);
            this.comboBoxRotation.TabIndex = 1;
            // 
            // listBoxProzessDaten
            // 
            this.listBoxProzessDaten.AllowDrop = true;
            this.listBoxProzessDaten.FormattingEnabled = true;
            this.listBoxProzessDaten.Location = new System.Drawing.Point(190, 96);
            this.listBoxProzessDaten.Name = "listBoxProzessDaten";
            this.listBoxProzessDaten.Size = new System.Drawing.Size(889, 147);
            this.listBoxProzessDaten.TabIndex = 126;
            this.listBoxProzessDaten.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxProzessDaten_DragDrop);
            this.listBoxProzessDaten.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxProzessDaten_DragEnter);
            this.listBoxProzessDaten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxProzessDaten_KeyDown);
            // 
            // listBoxLogDaten
            // 
            this.listBoxLogDaten.AllowDrop = true;
            this.listBoxLogDaten.FormattingEnabled = true;
            this.listBoxLogDaten.Location = new System.Drawing.Point(190, 270);
            this.listBoxLogDaten.Name = "listBoxLogDaten";
            this.listBoxLogDaten.Size = new System.Drawing.Size(889, 147);
            this.listBoxLogDaten.TabIndex = 127;
            this.listBoxLogDaten.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxLogDaten_DragDrop);
            this.listBoxLogDaten.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxLogDaten_DragEnter);
            this.listBoxLogDaten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxLogDaten_KeyDown);
            // 
            // listBoxChargenDaten
            // 
            this.listBoxChargenDaten.AllowDrop = true;
            this.listBoxChargenDaten.FormattingEnabled = true;
            this.listBoxChargenDaten.Location = new System.Drawing.Point(190, 449);
            this.listBoxChargenDaten.Name = "listBoxChargenDaten";
            this.listBoxChargenDaten.Size = new System.Drawing.Size(889, 147);
            this.listBoxChargenDaten.TabIndex = 128;
            this.listBoxChargenDaten.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxChargenDaten_DragDrop);
            this.listBoxChargenDaten.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxChargenDaten_DragEnter);
            this.listBoxChargenDaten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxChargenDaten_KeyDown);
            // 
            // ProzessdatenAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 693);
            this.Controls.Add(this.listBoxChargenDaten);
            this.Controls.Add(this.listBoxLogDaten);
            this.Controls.Add(this.listBoxProzessDaten);
            this.Controls.Add(this.comboBoxRotation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxReihennummer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label27);
            this.Name = "ProzessdatenAnlegen";
            this.Text = "ProzessdatenAnlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReihennummer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRotation;
        private System.Windows.Forms.ListBox listBoxProzessDaten;
        private System.Windows.Forms.ListBox listBoxLogDaten;
        private System.Windows.Forms.ListBox listBoxChargenDaten;
    }
}