
namespace ProbenDatenbank.Forms.Verwaltung
{
    partial class AnlageAnlegen
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
            this.comboBoxTechnologie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.labelBezeichnung = new System.Windows.Forms.Label();
            this.textBoxTargetAnzahl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnlagenSchema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTechnologie
            // 
            this.comboBoxTechnologie.FormattingEnabled = true;
            this.comboBoxTechnologie.Location = new System.Drawing.Point(158, 57);
            this.comboBoxTechnologie.Name = "comboBoxTechnologie";
            this.comboBoxTechnologie.Size = new System.Drawing.Size(286, 21);
            this.comboBoxTechnologie.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 126;
            this.label1.Text = "Technologie";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(26, 176);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 54);
            this.buttonCancel.TabIndex = 125;
            this.buttonCancel.Text = "Zurück";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(308, 176);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 54);
            this.buttonSave.TabIndex = 124;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(158, 21);
            this.textBoxBezeichnung.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(286, 20);
            this.textBoxBezeichnung.TabIndex = 123;
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.labelBezeichnung.Location = new System.Drawing.Point(23, 21);
            this.labelBezeichnung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(89, 18);
            this.labelBezeichnung.TabIndex = 122;
            this.labelBezeichnung.Text = "Bezeichnung";
            // 
            // textBoxTargetAnzahl
            // 
            this.textBoxTargetAnzahl.Location = new System.Drawing.Point(158, 98);
            this.textBoxTargetAnzahl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTargetAnzahl.Name = "textBoxTargetAnzahl";
            this.textBoxTargetAnzahl.Size = new System.Drawing.Size(286, 20);
            this.textBoxTargetAnzahl.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 128;
            this.label2.Text = "Target Anzahl";
            // 
            // textBoxAnlagenSchema
            // 
            this.textBoxAnlagenSchema.Location = new System.Drawing.Point(158, 136);
            this.textBoxAnlagenSchema.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAnlagenSchema.Name = "textBoxAnlagenSchema";
            this.textBoxAnlagenSchema.Size = new System.Drawing.Size(286, 20);
            this.textBoxAnlagenSchema.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 130;
            this.label3.Text = "Anlagen Schema";
            // 
            // AnlageAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 252);
            this.Controls.Add(this.textBoxAnlagenSchema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTargetAnzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTechnologie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.labelBezeichnung);
            this.Name = "AnlageAnlegen";
            this.Text = "AnlageAnlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTechnologie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.TextBox textBoxTargetAnzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAnlagenSchema;
        private System.Windows.Forms.Label label3;
    }
}