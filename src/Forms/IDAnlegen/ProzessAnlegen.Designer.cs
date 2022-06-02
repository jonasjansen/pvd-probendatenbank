
namespace ProbenDatenbank.Forms.IDAnlegen
{
    partial class ProzessAnlegen
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
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxAnlage = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxModus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTargetBelegung = new System.Windows.Forms.DataGridView();
            this.ColumnTargetPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTargetWerkstoff = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddProzessDaten = new System.Windows.Forms.Button();
            this.dataGridViewProzessDaten = new System.Windows.Forms.DataGridView();
            this.ColumnNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProzessDaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogDaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReihennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTargetBelegung)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProzessDaten)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label14.Location = new System.Drawing.Point(23, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 18);
            this.label14.TabIndex = 134;
            this.label14.Text = "Anlage";
            // 
            // comboBoxAnlage
            // 
            this.comboBoxAnlage.FormattingEnabled = true;
            this.comboBoxAnlage.Location = new System.Drawing.Point(115, 25);
            this.comboBoxAnlage.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAnlage.Name = "comboBoxAnlage";
            this.comboBoxAnlage.Size = new System.Drawing.Size(151, 21);
            this.comboBoxAnlage.TabIndex = 1;
            this.comboBoxAnlage.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnlage_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label17.Location = new System.Drawing.Point(23, 62);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 18);
            this.label17.TabIndex = 140;
            this.label17.Text = "Modus";
            // 
            // comboBoxModus
            // 
            this.comboBoxModus.FormattingEnabled = true;
            this.comboBoxModus.Location = new System.Drawing.Point(115, 62);
            this.comboBoxModus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxModus.Name = "comboBoxModus";
            this.comboBoxModus.Size = new System.Drawing.Size(151, 21);
            this.comboBoxModus.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridViewTargetBelegung);
            this.groupBox1.Location = new System.Drawing.Point(26, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 232);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Belegung";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 199);
            this.button1.TabIndex = 1;
            this.button1.Text = "Platzhalter Anlagenschema";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTargetBelegung
            // 
            this.dataGridViewTargetBelegung.AllowUserToAddRows = false;
            this.dataGridViewTargetBelegung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTargetBelegung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTargetPosition,
            this.ColumnTargetWerkstoff});
            this.dataGridViewTargetBelegung.Location = new System.Drawing.Point(16, 19);
            this.dataGridViewTargetBelegung.Name = "dataGridViewTargetBelegung";
            this.dataGridViewTargetBelegung.RowHeadersVisible = false;
            this.dataGridViewTargetBelegung.Size = new System.Drawing.Size(521, 199);
            this.dataGridViewTargetBelegung.TabIndex = 3;
            this.dataGridViewTargetBelegung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTargetBelegung_CellClick);
            this.dataGridViewTargetBelegung.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewTargetBelegung_DataError);
            // 
            // ColumnTargetPosition
            // 
            this.ColumnTargetPosition.HeaderText = "Target Position";
            this.ColumnTargetPosition.Name = "ColumnTargetPosition";
            // 
            // ColumnTargetWerkstoff
            // 
            this.ColumnTargetWerkstoff.HeaderText = "Target Werkstoff";
            this.ColumnTargetWerkstoff.Name = "ColumnTargetWerkstoff";
            this.ColumnTargetWerkstoff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTargetWerkstoff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnTargetWerkstoff.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddProzessDaten);
            this.groupBox2.Controls.Add(this.dataGridViewProzessDaten);
            this.groupBox2.Location = new System.Drawing.Point(26, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 280);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prozessdaten";
            // 
            // buttonAddProzessDaten
            // 
            this.buttonAddProzessDaten.Location = new System.Drawing.Point(16, 28);
            this.buttonAddProzessDaten.Name = "buttonAddProzessDaten";
            this.buttonAddProzessDaten.Size = new System.Drawing.Size(224, 23);
            this.buttonAddProzessDaten.TabIndex = 4;
            this.buttonAddProzessDaten.Text = "Hinzufügen";
            this.buttonAddProzessDaten.UseVisualStyleBackColor = true;
            this.buttonAddProzessDaten.Click += new System.EventHandler(this.buttonAddProzessDaten_Click);
            // 
            // dataGridViewProzessDaten
            // 
            this.dataGridViewProzessDaten.AllowUserToAddRows = false;
            this.dataGridViewProzessDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProzessDaten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNr,
            this.ColumnRotation,
            this.ColumnProzessDaten,
            this.ColumnLogDaten,
            this.ColumnCharge,
            this.ColumnReihennummer});
            this.dataGridViewProzessDaten.Location = new System.Drawing.Point(16, 67);
            this.dataGridViewProzessDaten.Name = "dataGridViewProzessDaten";
            this.dataGridViewProzessDaten.RowHeadersVisible = false;
            this.dataGridViewProzessDaten.Size = new System.Drawing.Size(734, 199);
            this.dataGridViewProzessDaten.TabIndex = 5;
            this.dataGridViewProzessDaten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProzessDaten_CellContentClick);
            // 
            // ColumnNr
            // 
            this.ColumnNr.HeaderText = "Nr.";
            this.ColumnNr.Name = "ColumnNr";
            // 
            // ColumnRotation
            // 
            this.ColumnRotation.HeaderText = "Rotation";
            this.ColumnRotation.Name = "ColumnRotation";
            // 
            // ColumnProzessDaten
            // 
            this.ColumnProzessDaten.HeaderText = "Prozess Daten";
            this.ColumnProzessDaten.Name = "ColumnProzessDaten";
            // 
            // ColumnLogDaten
            // 
            this.ColumnLogDaten.HeaderText = "Log Daten";
            this.ColumnLogDaten.Name = "ColumnLogDaten";
            // 
            // ColumnCharge
            // 
            this.ColumnCharge.HeaderText = "Charge";
            this.ColumnCharge.Name = "ColumnCharge";
            // 
            // ColumnReihennummer
            // 
            this.ColumnReihennummer.HeaderText = "Reihennummer";
            this.ColumnReihennummer.Name = "ColumnReihennummer";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(26, 657);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(240, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(550, 657);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(240, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ProzessAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 701);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxModus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxAnlage);
            this.Name = "ProzessAnlegen";
            this.Text = "ProzessAnlegen";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTargetBelegung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProzessDaten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxAnlage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxModus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTargetBelegung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewProzessDaten;
        private System.Windows.Forms.Button buttonAddProzessDaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProzessDaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogDaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReihennummer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTargetPosition;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnTargetWerkstoff;
    }
}