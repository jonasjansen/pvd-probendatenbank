
namespace ProbenDatenbank
{
    partial class Analysedaten
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
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataGridViewAnalysedaten = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxAnalysemethode = new System.Windows.Forms.ComboBox();
            this.comboBoxEigenschaft = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dgvSubstratColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnalysedatenColumnEigenschaft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnalysedatenColumnAnalysemethode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnalysedatenColumnWert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnalysedatenColumnEinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnalysedatenColumnAnalysedaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysedaten)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(19, 637);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 33);
            this.buttonCancel.TabIndex = 87;
            this.buttonCancel.Text = "Zurück";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label14.Location = new System.Drawing.Point(418, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 99;
            this.label14.Text = "Eigenschaft";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 97;
            this.label5.Text = "Analysemethode";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(965, 11);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(136, 33);
            this.buttonReset.TabIndex = 106;
            this.buttonReset.Text = "Filter zurücksetzen";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataGridViewAnalysedaten
            // 
            this.dataGridViewAnalysedaten.AllowUserToAddRows = false;
            this.dataGridViewAnalysedaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAnalysedaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalysedaten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubstratColumnId,
            this.dgvAnalysedatenColumnEigenschaft,
            this.dgvAnalysedatenColumnAnalysemethode,
            this.dgvAnalysedatenColumnWert,
            this.dgvAnalysedatenColumnEinheit,
            this.dgvAnalysedatenColumnAnalysedaten});
            this.dataGridViewAnalysedaten.Location = new System.Drawing.Point(19, 105);
            this.dataGridViewAnalysedaten.Name = "dataGridViewAnalysedaten";
            this.dataGridViewAnalysedaten.ReadOnly = true;
            this.dataGridViewAnalysedaten.RowHeadersVisible = false;
            this.dataGridViewAnalysedaten.Size = new System.Drawing.Size(1254, 514);
            this.dataGridViewAnalysedaten.TabIndex = 107;
            this.dataGridViewAnalysedaten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnalysedaten_CellContentClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1137, 11);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(136, 33);
            this.buttonSearch.TabIndex = 108;
            this.buttonSearch.Text = "Suchen";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxAnalysemethode
            // 
            this.comboBoxAnalysemethode.FormattingEnabled = true;
            this.comboBoxAnalysemethode.Location = new System.Drawing.Point(131, 18);
            this.comboBoxAnalysemethode.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAnalysemethode.Name = "comboBoxAnalysemethode";
            this.comboBoxAnalysemethode.Size = new System.Drawing.Size(248, 21);
            this.comboBoxAnalysemethode.TabIndex = 109;
            // 
            // comboBoxEigenschaft
            // 
            this.comboBoxEigenschaft.FormattingEnabled = true;
            this.comboBoxEigenschaft.Location = new System.Drawing.Point(502, 18);
            this.comboBoxEigenschaft.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEigenschaft.Name = "comboBoxEigenschaft";
            this.comboBoxEigenschaft.Size = new System.Drawing.Size(248, 21);
            this.comboBoxEigenschaft.TabIndex = 110;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 58);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(253, 33);
            this.buttonAdd.TabIndex = 111;
            this.buttonAdd.Text = "Hinzufügen";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dgvSubstratColumnId
            // 
            this.dgvSubstratColumnId.HeaderText = "ID";
            this.dgvSubstratColumnId.Name = "dgvSubstratColumnId";
            this.dgvSubstratColumnId.ReadOnly = true;
            // 
            // dgvAnalysedatenColumnEigenschaft
            // 
            this.dgvAnalysedatenColumnEigenschaft.HeaderText = "Eigenschaft";
            this.dgvAnalysedatenColumnEigenschaft.Name = "dgvAnalysedatenColumnEigenschaft";
            this.dgvAnalysedatenColumnEigenschaft.ReadOnly = true;
            this.dgvAnalysedatenColumnEigenschaft.Width = 200;
            // 
            // dgvAnalysedatenColumnAnalysemethode
            // 
            this.dgvAnalysedatenColumnAnalysemethode.HeaderText = "Analysemethode";
            this.dgvAnalysedatenColumnAnalysemethode.Name = "dgvAnalysedatenColumnAnalysemethode";
            this.dgvAnalysedatenColumnAnalysemethode.ReadOnly = true;
            this.dgvAnalysedatenColumnAnalysemethode.Width = 200;
            // 
            // dgvAnalysedatenColumnWert
            // 
            this.dgvAnalysedatenColumnWert.HeaderText = "Wert";
            this.dgvAnalysedatenColumnWert.Name = "dgvAnalysedatenColumnWert";
            this.dgvAnalysedatenColumnWert.ReadOnly = true;
            this.dgvAnalysedatenColumnWert.Width = 150;
            // 
            // dgvAnalysedatenColumnEinheit
            // 
            this.dgvAnalysedatenColumnEinheit.HeaderText = "Einheit";
            this.dgvAnalysedatenColumnEinheit.Name = "dgvAnalysedatenColumnEinheit";
            this.dgvAnalysedatenColumnEinheit.ReadOnly = true;
            this.dgvAnalysedatenColumnEinheit.Width = 150;
            // 
            // dgvAnalysedatenColumnAnalysedaten
            // 
            this.dgvAnalysedatenColumnAnalysedaten.HeaderText = "Analysedaten";
            this.dgvAnalysedatenColumnAnalysedaten.Name = "dgvAnalysedatenColumnAnalysedaten";
            this.dgvAnalysedatenColumnAnalysedaten.ReadOnly = true;
            this.dgvAnalysedatenColumnAnalysedaten.Width = 150;
            // 
            // Analysedaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 681);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxEigenschaft);
            this.Controls.Add(this.comboBoxAnalysemethode);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewAnalysedaten);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Analysedaten";
            this.Text = "Analysedaten";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysedaten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridViewAnalysedaten;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxAnalysemethode;
        private System.Windows.Forms.ComboBox comboBoxEigenschaft;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubstratColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnalysedatenColumnEigenschaft;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnalysedatenColumnAnalysemethode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnalysedatenColumnWert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnalysedatenColumnEinheit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnalysedatenColumnAnalysedaten;
    }
}