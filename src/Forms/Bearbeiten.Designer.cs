
namespace ProbenDatenbank
{
    partial class Bearbeiten
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
            this.label34 = new System.Windows.Forms.Label();
            this.buttonIdDecrease = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonIdIncrease = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataGridViewBeschichtung = new System.Windows.Forms.DataGridView();
            this.dgvSubstratColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxProjekt = new System.Windows.Forms.ComboBox();
            this.comboBoxAnlage = new System.Windows.Forms.ComboBox();
            this.comboBoxSubstratwerkstoff = new System.Windows.Forms.ComboBox();
            this.comboBoxSchichtwerkstoff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeschichtung)).BeginInit();
            this.SuspendLayout();
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label34.Location = new System.Drawing.Point(16, 12);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(22, 18);
            this.label34.TabIndex = 90;
            this.label34.Text = "ID";
            // 
            // buttonIdDecrease
            // 
            this.buttonIdDecrease.Location = new System.Drawing.Point(181, 5);
            this.buttonIdDecrease.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIdDecrease.Name = "buttonIdDecrease";
            this.buttonIdDecrease.Size = new System.Drawing.Size(31, 33);
            this.buttonIdDecrease.TabIndex = 88;
            this.buttonIdDecrease.Text = "-";
            this.buttonIdDecrease.UseVisualStyleBackColor = true;
            this.buttonIdDecrease.Click += new System.EventHandler(this.buttonIdDecrease_Click);
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
            // buttonIdIncrease
            // 
            this.buttonIdIncrease.Location = new System.Drawing.Point(216, 5);
            this.buttonIdIncrease.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIdIncrease.Name = "buttonIdIncrease";
            this.buttonIdIncrease.Size = new System.Drawing.Size(31, 33);
            this.buttonIdIncrease.TabIndex = 92;
            this.buttonIdIncrease.Text = "+";
            this.buttonIdIncrease.UseVisualStyleBackColor = true;
            this.buttonIdIncrease.Click += new System.EventHandler(this.buttonIdIncrease_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(73, 12);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(104, 20);
            this.textBoxId.TabIndex = 94;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label29.Location = new System.Drawing.Point(760, 62);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(113, 18);
            this.label29.TabIndex = 100;
            this.label29.Text = "Schichtwerkstoff";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label14.Location = new System.Drawing.Point(195, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 18);
            this.label14.TabIndex = 99;
            this.label14.Text = "Anlage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label9.Location = new System.Drawing.Point(434, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 98;
            this.label9.Text = "Substratwerkstoff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 11.25F);
            this.label5.Location = new System.Drawing.Point(16, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 97;
            this.label5.Text = "Projekt";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1086, 11);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(136, 33);
            this.buttonReset.TabIndex = 106;
            this.buttonReset.Text = "Filter zurücksetzen";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataGridViewBeschichtung
            // 
            this.dataGridViewBeschichtung.AllowUserToAddRows = false;
            this.dataGridViewBeschichtung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBeschichtung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeschichtung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubstratColumnId});
            this.dataGridViewBeschichtung.Location = new System.Drawing.Point(19, 105);
            this.dataGridViewBeschichtung.Name = "dataGridViewBeschichtung";
            this.dataGridViewBeschichtung.ReadOnly = true;
            this.dataGridViewBeschichtung.RowHeadersVisible = false;
            this.dataGridViewBeschichtung.Size = new System.Drawing.Size(1203, 514);
            this.dataGridViewBeschichtung.TabIndex = 107;
            this.dataGridViewBeschichtung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBeschichtung_CellContentClick);
            // 
            // dgvSubstratColumnId
            // 
            this.dgvSubstratColumnId.HeaderText = "ID";
            this.dgvSubstratColumnId.Name = "dgvSubstratColumnId";
            this.dgvSubstratColumnId.ReadOnly = true;
            this.dgvSubstratColumnId.Width = 250;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1086, 55);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(136, 33);
            this.buttonSearch.TabIndex = 108;
            this.buttonSearch.Text = "Suchen";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxProjekt
            // 
            this.comboBoxProjekt.FormattingEnabled = true;
            this.comboBoxProjekt.Location = new System.Drawing.Point(73, 62);
            this.comboBoxProjekt.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProjekt.Name = "comboBoxProjekt";
            this.comboBoxProjekt.Size = new System.Drawing.Size(104, 21);
            this.comboBoxProjekt.TabIndex = 109;
            // 
            // comboBoxAnlage
            // 
            this.comboBoxAnlage.FormattingEnabled = true;
            this.comboBoxAnlage.Location = new System.Drawing.Point(251, 62);
            this.comboBoxAnlage.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAnlage.Name = "comboBoxAnlage";
            this.comboBoxAnlage.Size = new System.Drawing.Size(151, 21);
            this.comboBoxAnlage.TabIndex = 110;
            // 
            // comboBoxSubstratwerkstoff
            // 
            this.comboBoxSubstratwerkstoff.FormattingEnabled = true;
            this.comboBoxSubstratwerkstoff.Location = new System.Drawing.Point(557, 62);
            this.comboBoxSubstratwerkstoff.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSubstratwerkstoff.Name = "comboBoxSubstratwerkstoff";
            this.comboBoxSubstratwerkstoff.Size = new System.Drawing.Size(171, 21);
            this.comboBoxSubstratwerkstoff.TabIndex = 111;
            // 
            // comboBoxSchichtwerkstoff
            // 
            this.comboBoxSchichtwerkstoff.FormattingEnabled = true;
            this.comboBoxSchichtwerkstoff.Location = new System.Drawing.Point(877, 62);
            this.comboBoxSchichtwerkstoff.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSchichtwerkstoff.Name = "comboBoxSchichtwerkstoff";
            this.comboBoxSchichtwerkstoff.Size = new System.Drawing.Size(171, 21);
            this.comboBoxSchichtwerkstoff.TabIndex = 112;
            // 
            // Bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 681);
            this.Controls.Add(this.comboBoxSchichtwerkstoff);
            this.Controls.Add(this.comboBoxSubstratwerkstoff);
            this.Controls.Add(this.comboBoxAnlage);
            this.Controls.Add(this.comboBoxProjekt);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewBeschichtung);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonIdIncrease);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.buttonIdDecrease);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bearbeiten";
            this.Text = "Suchen und Bearbeiten";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeschichtung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button buttonIdDecrease;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonIdIncrease;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridViewBeschichtung;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxProjekt;
        private System.Windows.Forms.ComboBox comboBoxAnlage;
        private System.Windows.Forms.ComboBox comboBoxSubstratwerkstoff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubstratColumnId;
        private System.Windows.Forms.ComboBox comboBoxSchichtwerkstoff;
    }
}