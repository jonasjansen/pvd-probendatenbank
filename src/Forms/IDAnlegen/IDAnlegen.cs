using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Forms.IDAnlegen
{
    public partial class IDAnlegen : Form
    {
        const String ButtonEditName = "edit";
        const String ButtonDeleteName = "delete";
        
        // Collections for ComboBox 
        private ProjektCollection projektCollection;
        private BereichCollection bereichCollection;
        
        // Collections for DataGridViews
        private SubstratCollection substratCollection;
        private ProzessCollection prozessCollection;
        private SchichtlageCollection schichtlageCollection;
        private Beschichtung beschichtung;

        public IDAnlegen()
        {
            projektCollection = new ProjektCollection();
            bereichCollection = new BereichCollection();
            
            substratCollection = new SubstratCollection(false);
            prozessCollection = new ProzessCollection(false);
            schichtlageCollection = new SchichtlageCollection(false);
            beschichtung = new Beschichtung();

            InitializeComponent();
            InitizalizeData();
            InitializeDgvButtons();
        }

        private void InitizalizeData()
        {
            foreach (Projekt item in projektCollection.GetItems())
            {
                comboBoxProjekt.Items.Add(item);
            }

            foreach (Bereich item in bereichCollection.GetItems())
            {
                comboBoxForschungsgruppe.Items.Add(item);
            }

            /* Populate DGVs */
            InitializeSubstratDataGridView();
            InitializeProzessDataGridView();
            InitializeSchichtDataGridView();
        }

        private void InitializeDgvButtons()
        {
            dataGridViewSubstrat.Columns.Add(GetDgvButtonColumn(ButtonEditName, "Bearbeiten"));
            dataGridViewSubstrat.Columns.Add(GetDgvButtonColumn(ButtonDeleteName, "Löschen"));

            dataGridViewProzess.Columns.Add(GetDgvButtonColumn(ButtonEditName, "Bearbeiten"));
            dataGridViewProzess.Columns.Add(GetDgvButtonColumn(ButtonDeleteName, "Löschen"));

            dataGridViewSchicht.Columns.Add(GetDgvButtonColumn(ButtonEditName, "Bearbeiten"));
            dataGridViewSchicht.Columns.Add(GetDgvButtonColumn(ButtonDeleteName, "Löschen"));
        }

        private DataGridViewButtonColumn GetDgvButtonColumn(string name, string text)
        {
            return new DataGridViewButtonColumn
            {
                Name = name,
                Text = text,
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
        }

        private void InitializeSubstratDataGridView()
        {
            dataGridViewSubstrat.Rows.Clear();
            int count = 1;
            foreach (KeyValuePair<int, BaseEntity> keyValuePair in substratCollection.GetItemsDictionary())
            {
                Substrat item = (Substrat)keyValuePair.Value;
                dataGridViewSubstrat.Rows.Add(
                    keyValuePair.Key,
                    count,
                    item.GetSubstratwerkstoffBezeichnung(),
                    item.GetVorbehandlungBezeichnung(1),
                    item.GetVorbehandlungBezeichnung(2),
                    item.GetVorbehandlungBezeichnung(3)
                );
                count++;
            }
        }

        private void InitializeProzessDataGridView()
        {
            dataGridViewProzess.Rows.Clear();
            int count = 1;
            foreach (KeyValuePair<int, BaseEntity> keyValuePair in prozessCollection.GetItemsDictionary())
            {
                Prozess item = (Prozess)keyValuePair.Value;
                dataGridViewProzess.Rows.Add(
                    keyValuePair.Key,
                    count.ToString(),
                    item.Anlage_Bezeichnung,
                    item.Modus_Bezeichnung,
                    item.Bezeichnung
                );
                count++;
            }
        }

        private void InitializeSchichtDataGridView()
        {
            dataGridViewSchicht.Rows.Clear();
            foreach (KeyValuePair<int, BaseEntity> keyValuePair in schichtlageCollection.GetItemsDictionary())
            {
                Schichtlage item = (Schichtlage)keyValuePair.Value;
                dataGridViewSchicht.Rows.Add(
                    keyValuePair.Key,
                    item.Position,
                    item.Schichtwerkstoff_Bezeichnung,
                    item.Schichtarchitektur_Bezeichnung,
                    item.Beschichtungsdatum
                );
            }

            dataGridViewSchicht.Sort(dataGridViewSchicht.Columns[0], ListSortDirection.Ascending);
        }
        
        /// <summary>
        /// Check if label of Object is part of a ComboBox and return it's position.
        /// Returns -1 if label could not be found.
        /// </summary>
        /// <param name="comboBox">Search ComboBox</param>
        /// <param name="label">Label of object, which should be selected</param>
        /// <returns></returns>
        private int GetPositionOfEntity(ComboBox comboBox, string label)
        {
            // -1 => No entity selected in ComboBox.
            int position =-1;
            foreach (BaseEntity item in comboBox.Items)
            {
                position++;
                if (item.ToString() == label)
                {
                    return position;
                }
            }
            return position;
        }
        
        public void AddBeschichtung(Beschichtung beschichtung)
        {
            this.beschichtung = beschichtung;
            
            // Set BeschichtungID to Textbox
            textBoxID.Text = this.beschichtung.Id.ToString();
            
            // Fill dgv's
            substratCollection.LoadByBeschichtung(beschichtung.Id);
            InitializeSubstratDataGridView();
            
            schichtlageCollection.LoadByBeschichtung(beschichtung.Id);
            InitializeSchichtDataGridView();

            foreach (Schichtlage schichtlage in schichtlageCollection.GetItems())
            {
                // Use 0 as collectionId so that the collectionId is generated by the collection.
                AddProzess(schichtlage.Prozess, 0);
            }
            InitializeProzessDataGridView();
            
            // Preselect ComboBox items 
            comboBoxProjekt.SelectedIndex = GetPositionOfEntity(comboBoxProjekt, beschichtung.Projekt_Bezeichnung);
        }

        private void buttonAddSubstrat_Click(object sender, EventArgs e)
        {
            Form formSubstratAnlegen = new SubstratAnlegen(this);
            formSubstratAnlegen.ShowDialog(this);
        }

        private void buttonAddSystem_Click(object sender, EventArgs e)
        {
            if (prozessCollection.HasItems())
            {
                Form formSchichtlageAnlegen = new SchichtlageAnlegen(this, prozessCollection);
                formSchichtlageAnlegen.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(@"Bitte mindestens einen Prozess anlegen.");
            }
        }

        private void buttonAddProzess_Click(object sender, EventArgs e)
        {
            Form form = new ProzessAnlegen(this);
            form.ShowDialog();
        }

        public void AddSubstrat(Substrat item, int collectionId)
        {
            if (collectionId > 0)
            {
                substratCollection.AddItem(item, collectionId);
            }
            else
            {
                substratCollection.AddItem(item);
            }

            InitializeSubstratDataGridView();
        }

        public void AddProzess(Prozess item, int collectionId)
        {
            if (collectionId > 0)
            {
                prozessCollection.AddItem(item, collectionId);
            }
            else
            {
                prozessCollection.AddItem(item);
            }
            InitializeProzessDataGridView();
        }

        public void AddSchicht(Schichtlage item,int collectionId)
        {
            if (collectionId > 0)
            {
                schichtlageCollection.AddItem(item, collectionId);
            }
            else
            {
                schichtlageCollection.AddItem(item);
            }
            InitializeSchichtDataGridView();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveBeschichtung();
                SaveSubstrat();
                SaveProzess();
                SaveSchichtlage();
                Close();
                MessageBox.Show(@"ID " + beschichtung.Id + " wurde erstellt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"ID konnte nicht erstellt werden: " + ex.Message);
            }
        }

        /// <summary>
        /// Save entity Beschichtung. Show entity's ID in From.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SaveBeschichtung()
        {
            if (String.IsNullOrEmpty(comboBoxProjekt.Text))
            {
                throw new Exception("Kein Projekt ausgewählt. Bitte wählen Sie ein Projekt aus (1. Schritt).");
            }

            Projekt selectedProjekt = (Projekt)comboBoxProjekt.SelectedItem;
            beschichtung.Projekt_ID = selectedProjekt.Id;
            beschichtung.Projekt_Bezeichnung = selectedProjekt.BezeichnungAkronym;
            beschichtung.Save();
            textBoxID.Text = beschichtung.Id.ToString();
        }

        /// <summary>
        /// Save all Subtrat entities from substratCollection.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SaveSubstrat()
        {
            if (!substratCollection.HasItems())
            {
                throw new Exception(
                    "Keine Substrate angelegt. Bitte legen Sie mindestens ein Substrat an (2. Schritt).");
            }

            substratCollection.SaveItems(beschichtung.Id);
        }

        /// <summary>
        /// Save all Prozess entities from substratCollection.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SaveProzess()
        {
            if (!prozessCollection.HasItems())
            {
                throw new Exception(
                    "Keine Prozesse angelegt. Bitte legen Sie mindestens einen Prozess an (3. Schritt).");
            }

            prozessCollection.SaveItems(beschichtung.Id);
        }

        /// <summary>
        /// Save all Schichtlage entities from substratCollection.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SaveSchichtlage()
        {
            if (!schichtlageCollection.HasItems())
            {
                throw new Exception(
                    "Keine Schichtlage angelegt. Bitte legen Sie mindestens eine Schichtlage an (4. Schritt).");
            }

            schichtlageCollection.SaveItems(beschichtung.Id);
        }

        private void dataGridViewProzess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int collectionId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Prozess currentItem = (Prozess)prozessCollection.GetItem(collectionId);

                if (senderGrid.Columns[e.ColumnIndex].Name == ButtonEditName)
                {
                    ProzessAnlegen formProzessAnlegen = new ProzessAnlegen(this);
                    formProzessAnlegen.AddProzess(currentItem, collectionId);
                    formProzessAnlegen.ShowDialog(this);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == ButtonDeleteName)
                {
                    // TODO: Ask, if really wants to delete.
                    // TODO: Delete all items from dgvSchicht, which contain this process. Raise warning before!
                    prozessCollection.DeleteItem(collectionId);
                }

                InitializeProzessDataGridView();
            }
        }

        private void dataGridViewSubstrat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int collectionId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Substrat currentItem = (Substrat)substratCollection.GetItem(collectionId);

                if (senderGrid.Columns[e.ColumnIndex].Name == ButtonEditName)
                {
                    SubstratAnlegen formSubstratAnlegen = new SubstratAnlegen(this);
                    formSubstratAnlegen.AddSubstrat(currentItem, collectionId);
                    formSubstratAnlegen.ShowDialog(this);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == ButtonDeleteName)
                {
                    // TODO: Ask, if really wants to delete.
                    substratCollection.DeleteItem(collectionId);
                }

                InitializeSubstratDataGridView();
            }
        }

        private void dataGridViewSchicht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int collectionId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Schichtlage currentItem = (Schichtlage)schichtlageCollection.GetItem(collectionId);

                if (senderGrid.Columns[e.ColumnIndex].Name == ButtonEditName && prozessCollection.HasItems())
                {
                    SchichtlageAnlegen formSchichtlageAnlegen = new SchichtlageAnlegen(this, prozessCollection);
                    formSchichtlageAnlegen.AddSchichtlage(currentItem, collectionId);
                    formSchichtlageAnlegen.ShowDialog(this);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == ButtonDeleteName)
                {
                    // TODO: Ask, if really wants to delete.
                    schichtlageCollection.DeleteItem(collectionId);
                }

                InitializeSchichtDataGridView();
            }
        }
    }
}