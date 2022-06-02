
namespace ProbenDatenbank.Forms.Verwaltung
{
    partial class TechnologieAnlegen
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
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.labelBezeichnung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBereich = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(27, 109);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 54);
            this.buttonCancel.TabIndex = 119;
            this.buttonCancel.Text = "Zurück";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(312, 109);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 54);
            this.buttonSave.TabIndex = 118;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(162, 28);
            this.textBoxBezeichnung.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(286, 20);
            this.textBoxBezeichnung.TabIndex = 117;
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.labelBezeichnung.Location = new System.Drawing.Point(27, 28);
            this.labelBezeichnung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(89, 18);
            this.labelBezeichnung.TabIndex = 116;
            this.labelBezeichnung.Text = "Bezeichnung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 120;
            this.label1.Text = "Forschungsbereich";
            // 
            // comboBoxBereich
            // 
            this.comboBoxBereich.FormattingEnabled = true;
            this.comboBoxBereich.Location = new System.Drawing.Point(162, 64);
            this.comboBoxBereich.Name = "comboBoxBereich";
            this.comboBoxBereich.Size = new System.Drawing.Size(286, 21);
            this.comboBoxBereich.TabIndex = 121;
            // 
            // TechnologieAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 185);
            this.Controls.Add(this.comboBoxBereich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.labelBezeichnung);
            this.Name = "TechnologieAnlegen";
            this.Text = "TechnologieAnlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBereich;
    }
}