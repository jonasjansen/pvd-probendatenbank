
namespace ProbenDatenbank.Forms
{
    partial class Ergebnisablage
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
            this.label26 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxAnalysemethode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEigenschaft = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxErgebnisDaten = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWert = new System.Windows.Forms.TextBox();
            this.textBoxEinheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label26.Location = new System.Drawing.Point(11, 162);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 18);
            this.label26.TabIndex = 61;
            this.label26.Text = "Ergebnisdaten";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label18.Location = new System.Drawing.Point(11, 20);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 18);
            this.label18.TabIndex = 59;
            this.label18.Text = "Analysemethode";
            // 
            // comboBoxAnalysemethode
            // 
            this.comboBoxAnalysemethode.FormattingEnabled = true;
            this.comboBoxAnalysemethode.Location = new System.Drawing.Point(130, 20);
            this.comboBoxAnalysemethode.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAnalysemethode.Name = "comboBoxAnalysemethode";
            this.comboBoxAnalysemethode.Size = new System.Drawing.Size(458, 21);
            this.comboBoxAnalysemethode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Eigenschaft";
            // 
            // comboBoxEigenschaft
            // 
            this.comboBoxEigenschaft.FormattingEnabled = true;
            this.comboBoxEigenschaft.Location = new System.Drawing.Point(130, 64);
            this.comboBoxEigenschaft.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEigenschaft.Name = "comboBoxEigenschaft";
            this.comboBoxEigenschaft.Size = new System.Drawing.Size(458, 21);
            this.comboBoxEigenschaft.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(695, 436);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 33);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(11, 436);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 33);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Zurück";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listBoxErgebnisDaten
            // 
            this.listBoxErgebnisDaten.AllowDrop = true;
            this.listBoxErgebnisDaten.FormattingEnabled = true;
            this.listBoxErgebnisDaten.Location = new System.Drawing.Point(130, 162);
            this.listBoxErgebnisDaten.Name = "listBoxErgebnisDaten";
            this.listBoxErgebnisDaten.Size = new System.Drawing.Size(696, 251);
            this.listBoxErgebnisDaten.TabIndex = 5;
            this.listBoxErgebnisDaten.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxErgebnisDaten_DragDrop);
            this.listBoxErgebnisDaten.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxErgebnisDaten_DragEnter);
            this.listBoxErgebnisDaten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxErgebnisDaten_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 128;
            this.label2.Text = "Wert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label3.Location = new System.Drawing.Point(363, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 129;
            this.label3.Text = "Einheit";
            // 
            // textBoxWert
            // 
            this.textBoxWert.Location = new System.Drawing.Point(130, 111);
            this.textBoxWert.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWert.Name = "textBoxWert";
            this.textBoxWert.Size = new System.Drawing.Size(168, 20);
            this.textBoxWert.TabIndex = 3;
            // 
            // textBoxEinheit
            // 
            this.textBoxEinheit.Location = new System.Drawing.Point(419, 111);
            this.textBoxEinheit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEinheit.Name = "textBoxEinheit";
            this.textBoxEinheit.Size = new System.Drawing.Size(169, 20);
            this.textBoxEinheit.TabIndex = 4;
            // 
            // Ergebnisablage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 489);
            this.Controls.Add(this.textBoxEinheit);
            this.Controls.Add(this.textBoxWert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxErgebnisDaten);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEigenschaft);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBoxAnalysemethode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ergebnisablage";
            this.Text = "Ergebnisablage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxAnalysemethode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEigenschaft;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxErgebnisDaten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWert;
        private System.Windows.Forms.TextBox textBoxEinheit;
    }
}