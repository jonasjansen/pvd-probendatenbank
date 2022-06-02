using System.ComponentModel;

namespace ProbenDatenbank.Forms.IDAnlegen
{
    partial class IDAnlegen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxForschungsgruppe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProjekt = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewSubstrat = new System.Windows.Forms.DataGridView();
            this.dgvSubstratColumnCollectionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubstratColumnCollectionIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubstratColumnSubstratwerkstoff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubstratColumnVorbehandlungsschritt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubstratColumnColumnVorbehandlungsschritt_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubstratColumnColumnVorbehandlungsschritt_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProzess = new System.Windows.Forms.DataGridView();
            this.dataGridViewSchicht = new System.Windows.Forms.DataGridView();
            this.buttonAddSubstrat = new System.Windows.Forms.Button();
            this.buttonAddProzess = new System.Windows.Forms.Button();
            this.buttonAddSystem = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dgvSchichtColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSchichtColumnWerkstoff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSchichtColumnArchitektur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSchichtColumnBeschichtungsdateum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProzessColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProzessColumnAnlage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProzessColumnModus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProzessColumnProzess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubstrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProzess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchicht)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Schritt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Schritt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label3.Location = new System.Drawing.Point(78, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forschungsgruppe";
            // 
            // comboBoxForschungsgruppe
            // 
            this.comboBoxForschungsgruppe.FormattingEnabled = true;
            this.comboBoxForschungsgruppe.Location = new System.Drawing.Point(208, 9);
            this.comboBoxForschungsgruppe.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxForschungsgruppe.Name = "comboBoxForschungsgruppe";
            this.comboBoxForschungsgruppe.Size = new System.Drawing.Size(104, 21);
            this.comboBoxForschungsgruppe.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label5.Location = new System.Drawing.Point(78, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Projekt";
            // 
            // comboBoxProjekt
            // 
            this.comboBoxProjekt.FormattingEnabled = true;
            this.comboBoxProjekt.Location = new System.Drawing.Point(208, 34);
            this.comboBoxProjekt.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProjekt.Name = "comboBoxProjekt";
            this.comboBoxProjekt.Size = new System.Drawing.Size(104, 21);
            this.comboBoxProjekt.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 677);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Zurück";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox19
            // 
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(210, 219);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(121, 21);
            this.comboBox19.TabIndex = 27;
            // 
            // comboBox20
            // 
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(337, 219);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(121, 21);
            this.comboBox20.TabIndex = 28;
            // 
            // comboBox21
            // 
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(464, 219);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(121, 21);
            this.comboBox21.TabIndex = 29;
            // 
            // comboBox22
            // 
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(594, 219);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(121, 21);
            this.comboBox22.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label13.Location = new System.Drawing.Point(11, 279);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 32;
            this.label13.Text = "3. Schritt";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label28.Location = new System.Drawing.Point(11, 486);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 18);
            this.label28.TabIndex = 58;
            this.label28.Text = "4. Schritt";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1080, 677);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 33);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewSubstrat
            // 
            this.dataGridViewSubstrat.AllowUserToAddRows = false;
            this.dataGridViewSubstrat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubstrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubstrat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubstratColumnCollectionId,
            this.dgvSubstratColumnCollectionIndex,
            this.dgvSubstratColumnSubstratwerkstoff,
            this.dgvSubstratColumnVorbehandlungsschritt_1,
            this.dgvSubstratColumnColumnVorbehandlungsschritt_2,
            this.dgvSubstratColumnColumnVorbehandlungsschritt_3});
            this.dataGridViewSubstrat.Location = new System.Drawing.Point(81, 106);
            this.dataGridViewSubstrat.Name = "dataGridViewSubstrat";
            this.dataGridViewSubstrat.ReadOnly = true;
            this.dataGridViewSubstrat.RowHeadersVisible = false;
            this.dataGridViewSubstrat.Size = new System.Drawing.Size(1130, 138);
            this.dataGridViewSubstrat.TabIndex = 87;
            this.dataGridViewSubstrat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubstrat_CellContentClick);
            // 
            // dgvSubstratColumnCollectionId
            // 
            this.dgvSubstratColumnCollectionId.HeaderText = "Collection ID";
            this.dgvSubstratColumnCollectionId.Name = "dgvSubstratColumnCollectionId";
            this.dgvSubstratColumnCollectionId.ReadOnly = true;
            this.dgvSubstratColumnCollectionId.Visible = false;
            // 
            // dgvSubstratColumnCollectionIndex
            // 
            this.dgvSubstratColumnCollectionIndex.HeaderText = "Nr";
            this.dgvSubstratColumnCollectionIndex.Name = "dgvSubstratColumnCollectionIndex";
            this.dgvSubstratColumnCollectionIndex.ReadOnly = true;
            this.dgvSubstratColumnCollectionIndex.Width = 25;
            // 
            // dgvSubstratColumnSubstratwerkstoff
            // 
            this.dgvSubstratColumnSubstratwerkstoff.HeaderText = "Substratwerkstoff";
            this.dgvSubstratColumnSubstratwerkstoff.Name = "dgvSubstratColumnSubstratwerkstoff";
            this.dgvSubstratColumnSubstratwerkstoff.ReadOnly = true;
            this.dgvSubstratColumnSubstratwerkstoff.Width = 200;
            // 
            // dgvSubstratColumnVorbehandlungsschritt_1
            // 
            this.dgvSubstratColumnVorbehandlungsschritt_1.HeaderText = "Vorbehandlungsschritt_1";
            this.dgvSubstratColumnVorbehandlungsschritt_1.Name = "dgvSubstratColumnVorbehandlungsschritt_1";
            this.dgvSubstratColumnVorbehandlungsschritt_1.ReadOnly = true;
            this.dgvSubstratColumnVorbehandlungsschritt_1.Width = 200;
            // 
            // dgvSubstratColumnColumnVorbehandlungsschritt_2
            // 
            this.dgvSubstratColumnColumnVorbehandlungsschritt_2.HeaderText = "Vorbehandlungsschritt 2";
            this.dgvSubstratColumnColumnVorbehandlungsschritt_2.Name = "dgvSubstratColumnColumnVorbehandlungsschritt_2";
            this.dgvSubstratColumnColumnVorbehandlungsschritt_2.ReadOnly = true;
            this.dgvSubstratColumnColumnVorbehandlungsschritt_2.Width = 200;
            // 
            // dgvSubstratColumnColumnVorbehandlungsschritt_3
            // 
            this.dgvSubstratColumnColumnVorbehandlungsschritt_3.HeaderText = "Vorbehandlungsschritt 3";
            this.dgvSubstratColumnColumnVorbehandlungsschritt_3.Name = "dgvSubstratColumnColumnVorbehandlungsschritt_3";
            this.dgvSubstratColumnColumnVorbehandlungsschritt_3.ReadOnly = true;
            this.dgvSubstratColumnColumnVorbehandlungsschritt_3.Width = 200;
            // 
            // dataGridViewProzess
            // 
            this.dataGridViewProzess.AllowUserToAddRows = false;
            this.dataGridViewProzess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProzess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProzess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProzessColumnIndex,
            this.dgvProzessColumnAnlage,
            this.dgvProzessColumnModus,
            this.dgvProzessColumnProzess});
            this.dataGridViewProzess.Location = new System.Drawing.Point(83, 306);
            this.dataGridViewProzess.Name = "dataGridViewProzess";
            this.dataGridViewProzess.RowHeadersVisible = false;
            this.dataGridViewProzess.Size = new System.Drawing.Size(1130, 150);
            this.dataGridViewProzess.TabIndex = 88;
            this.dataGridViewProzess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProzess_CellContentClick);
            // 
            // dataGridViewSchicht
            // 
            this.dataGridViewSchicht.AllowUserToAddRows = false;
            this.dataGridViewSchicht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSchicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchicht.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSchichtColumnPosition,
            this.dgvSchichtColumnWerkstoff,
            this.dgvSchichtColumnArchitektur,
            this.dgvSchichtColumnBeschichtungsdateum});
            this.dataGridViewSchicht.Location = new System.Drawing.Point(83, 513);
            this.dataGridViewSchicht.Name = "dataGridViewSchicht";
            this.dataGridViewSchicht.RowHeadersVisible = false;
            this.dataGridViewSchicht.Size = new System.Drawing.Size(1130, 146);
            this.dataGridViewSchicht.TabIndex = 89;
            this.dataGridViewSchicht.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchicht_CellContentClick);
            // 
            // buttonAddSubstrat
            // 
            this.buttonAddSubstrat.Location = new System.Drawing.Point(79, 77);
            this.buttonAddSubstrat.Name = "buttonAddSubstrat";
            this.buttonAddSubstrat.Size = new System.Drawing.Size(231, 23);
            this.buttonAddSubstrat.TabIndex = 3;
            this.buttonAddSubstrat.Text = "Hinzufügen";
            this.buttonAddSubstrat.UseVisualStyleBackColor = true;
            this.buttonAddSubstrat.Click += new System.EventHandler(this.buttonAddSubstrat_Click);
            // 
            // buttonAddProzess
            // 
            this.buttonAddProzess.Location = new System.Drawing.Point(82, 277);
            this.buttonAddProzess.Name = "buttonAddProzess";
            this.buttonAddProzess.Size = new System.Drawing.Size(231, 23);
            this.buttonAddProzess.TabIndex = 4;
            this.buttonAddProzess.Text = "Hinzufügen";
            this.buttonAddProzess.UseVisualStyleBackColor = true;
            this.buttonAddProzess.Click += new System.EventHandler(this.buttonAddProzess_Click);
            // 
            // buttonAddSystem
            // 
            this.buttonAddSystem.Location = new System.Drawing.Point(82, 484);
            this.buttonAddSystem.Name = "buttonAddSystem";
            this.buttonAddSystem.Size = new System.Drawing.Size(231, 23);
            this.buttonAddSystem.TabIndex = 5;
            this.buttonAddSystem.Text = "Hinzufügen";
            this.buttonAddSystem.UseVisualStyleBackColor = true;
            this.buttonAddSystem.Click += new System.EventHandler(this.buttonAddSystem_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.labelID.Location = new System.Drawing.Point(361, 9);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 18);
            this.labelID.TabIndex = 93;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(388, 9);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(92, 20);
            this.textBoxID.TabIndex = 94;
            this.textBoxID.Text = "Noch nicht erstellt";
            // 
            // dgvSchichtColumnPosition
            // 
            this.dgvSchichtColumnPosition.HeaderText = "Position";
            this.dgvSchichtColumnPosition.Name = "dgvSchichtColumnPosition";
            this.dgvSchichtColumnPosition.Width = 50;
            // 
            // dgvSchichtColumnWerkstoff
            // 
            this.dgvSchichtColumnWerkstoff.HeaderText = "Werkstoff";
            this.dgvSchichtColumnWerkstoff.Name = "dgvSchichtColumnWerkstoff";
            this.dgvSchichtColumnWerkstoff.Width = 200;
            // 
            // dgvSchichtColumnArchitektur
            // 
            this.dgvSchichtColumnArchitektur.HeaderText = "Architektur";
            this.dgvSchichtColumnArchitektur.Name = "dgvSchichtColumnArchitektur";
            this.dgvSchichtColumnArchitektur.Width = 200;
            // 
            // dgvSchichtColumnBeschichtungsdateum
            // 
            this.dgvSchichtColumnBeschichtungsdateum.HeaderText = "BeschichtungsDatum";
            this.dgvSchichtColumnBeschichtungsdateum.Name = "dgvSchichtColumnBeschichtungsdateum";
            this.dgvSchichtColumnBeschichtungsdateum.Width = 200;
            // 
            // dgvProzessColumnIndex
            // 
            this.dgvProzessColumnIndex.HeaderText = "Nr";
            this.dgvProzessColumnIndex.Name = "dgvProzessColumnIndex";
            // 
            // dgvProzessColumnAnlage
            // 
            this.dgvProzessColumnAnlage.HeaderText = "Anlage";
            this.dgvProzessColumnAnlage.Name = "dgvProzessColumnAnlage";
            this.dgvProzessColumnAnlage.Width = 200;
            // 
            // dgvProzessColumnModus
            // 
            this.dgvProzessColumnModus.HeaderText = "Modus";
            this.dgvProzessColumnModus.Name = "dgvProzessColumnModus";
            this.dgvProzessColumnModus.Width = 200;
            // 
            // dgvProzessColumnProzess
            // 
            this.dgvProzessColumnProzess.HeaderText = "Prozess";
            this.dgvProzessColumnProzess.Name = "dgvProzessColumnProzess";
            this.dgvProzessColumnProzess.Width = 200;
            // 
            // IDAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 721);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonAddSystem);
            this.Controls.Add(this.buttonAddProzess);
            this.Controls.Add(this.buttonAddSubstrat);
            this.Controls.Add(this.dataGridViewSchicht);
            this.Controls.Add(this.dataGridViewProzess);
            this.Controls.Add(this.dataGridViewSubstrat);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxProjekt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxForschungsgruppe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IDAnlegen";
            this.Text = "IDAnlegen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubstrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProzess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxForschungsgruppe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProjekt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewSubstrat;
        private System.Windows.Forms.DataGridView dataGridViewProzess;
        private System.Windows.Forms.DataGridView dataGridViewSchicht;
        private System.Windows.Forms.Button buttonAddSubstrat;
        private System.Windows.Forms.Button buttonAddProzess;
        private System.Windows.Forms.Button buttonAddSystem;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubstratColumnCollectionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubstratColumnCollectionIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubstratColumnSubstratwerkstoff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubstratColumnVorbehandlungsschritt_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubstratColumnColumnVorbehandlungsschritt_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubstratColumnColumnVorbehandlungsschritt_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProzessColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProzessColumnAnlage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProzessColumnModus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProzessColumnProzess;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSchichtColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSchichtColumnWerkstoff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSchichtColumnArchitektur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSchichtColumnBeschichtungsdateum;
    }
}