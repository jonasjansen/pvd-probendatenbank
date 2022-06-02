using System;
using System.Collections.Generic;
using System.Management.Instrumentation;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;
using ProbenDatenbank.src.Forms.IDAnlegen;

namespace ProbenDatenbank.Forms.IDAnlegen
{
    public partial class ProzessAnlegen : Form
    {
        const String ButtonEditName = "edit";
        const String ButtonDeleteName = "delete";
        
        private IDAnlegen parentForm;
        private Dictionary<String, Targetwerkstoff> targetwerkstoffLableList;
        private ProzessdatenCollection prozessdatenCollection;
        private Prozess prozess;
        private int collectionId;

        public ProzessAnlegen(IDAnlegen parentForm)
        {
            this.parentForm = parentForm;
            targetwerkstoffLableList = new Dictionary<string, Targetwerkstoff>();
            prozessdatenCollection = new ProzessdatenCollection(false);
            prozess = new Prozess();
            collectionId = 0;

            TargetwerkstoffCollection targetwerkstoffCollection = new TargetwerkstoffCollection();
            foreach (Targetwerkstoff item in targetwerkstoffCollection.GetItems())
            {
                targetwerkstoffLableList[item.Bezeichnung] = item;
            }

            InitializeComponent();

            AnlageCollection anlageItems = new AnlageCollection();
            foreach (Anlage item in anlageItems.GetItems())
            {
                comboBoxAnlage.Items.Add(item);
            }

            ModusCollection modusItems = new ModusCollection();
            foreach (Modus item in modusItems.GetItems())
            {
                comboBoxModus.Items.Add(item);
            }

            InitializeTargetBelegungDataGridView();
            InitializeProzessdatensatzDataGridView();
            
            dataGridViewProzessDaten.Columns.Add(GetDgvButtonColumn(ButtonEditName, "Bearbeiten"));
            dataGridViewProzessDaten.Columns.Add(GetDgvButtonColumn(ButtonDeleteName, "Löschen"));
        }
        
        private void InitializeTargetBelegungDataGridView()
        {
            dataGridViewTargetBelegung.Rows.Clear();
            
            if (comboBoxAnlage.SelectedItem != null)
            {
                Anlage selectedAnlage = (Anlage) comboBoxAnlage.SelectedItem;
                int targetCount = int.Parse(selectedAnlage.Target_Anzahl);

                DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();

                for (int i = 1; i <= targetCount; i++)
                {
                    dataGridViewTargetBelegung.Rows.Add(i.ToString(), cell);
                }

                // Could not add Targetwerkstoff objects directly as item to the DataGridViewCombobox. 
                // Using a dictionary is a workaround.
                ColumnTargetWerkstoff.Items.Clear();
                ColumnTargetWerkstoff.Items.Add("");
                foreach (String label in targetwerkstoffLableList.Keys)
                {
                    ColumnTargetWerkstoff.Items.Add(label);
                }
            }
        }

        private void InitializeProzessdatensatzDataGridView()
        {
            dataGridViewProzessDaten.Rows.Clear();
            int count = 1;
            foreach (Prozessdatensatz item in prozessdatenCollection.GetItems())
            {
                dataGridViewProzessDaten.Rows.Add(count.ToString(), item.Rotation_Bezeichnung, item.ProzessLink,
                    item.LogdatenLink, item.ChargenLink, item.Reihennummer);
                count++;
            }
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

        private void buttonAddProzessDaten_Click(object sender, System.EventArgs e)
        {
            Form form = new ProzessdatenAnlegen(this);
            form.ShowDialog();
        }

        public void AddProzessdaten(Prozessdatensatz item, int collectionId)
        {
            if (collectionId > 0)
            {
                prozessdatenCollection.AddItem(item, collectionId);
            }
            else
            {
                prozessdatenCollection.AddItem(item);
            }
            InitializeProzessdatensatzDataGridView();
        }

        private void comboBoxAnlage_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            InitializeTargetBelegungDataGridView();
        }

        private void dataGridViewTargetBelegung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ignore DataCellError
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TargetbelegungCollection targetbelegungCollection = GetTargetbelegungCollection();
            if (! targetbelegungCollection.HasItems())
            {
                MessageBox.Show(@"Targetbelegung konnte nicht geladen werden. Bitte überprüfen Sie die Werte.");
            }
            else if (comboBoxAnlage.SelectedIndex < 0)
            {
                MessageBox.Show(@"Wählen Sie eine Anlage aus.");
            }
            else if (comboBoxModus.SelectedIndex < 0)
            {
                MessageBox.Show(@"Wählen Sie einen Modus aus.");
            }
            else
            {
                Anlage selectedAnlage = (Anlage) comboBoxAnlage.SelectedItem;
                Modus selectedModus = (Modus) comboBoxModus.SelectedItem;

                prozess.Anlage_ID = selectedAnlage.Id;
                prozess.Anlage_Bezeichnung = selectedAnlage.Bezeichnung;
                prozess.Modus_ID = selectedModus.Id;
                prozess.Modus_Bezeichnung = selectedModus.Bezeichnung;
                prozess.Bezeichnung = "Prozess";
                prozess.ProzessdatenCollection = prozessdatenCollection;
                prozess.TargetbelegungCollection = targetbelegungCollection;

                parentForm.AddProzess(prozess, collectionId);
                Close();
            }
        }

        /// <summary>
        /// Get Collection of entities "Targetbelegung".
        /// Fill the collection with selected options from dataGridViewTargetBelegung.
        /// </summary>
        /// <returns></returns>
        private TargetbelegungCollection GetTargetbelegungCollection()
        {
            TargetbelegungCollection collection = new TargetbelegungCollection();

            foreach (DataGridViewRow row in dataGridViewTargetBelegung.Rows)
            {
                string targetwerkstoffBezeichnung = row.Cells[1].Value.ToString();
                if (!targetwerkstoffLableList.ContainsKey(targetwerkstoffBezeichnung))
                {
                    //This should never happen since the cell contains only values from the list.
                    MessageBox.Show(
                        @"Prozess kann nicht angelegt werden. Falscher Wert für Targetwerkstoff an Position " +
                        row.Index);
                    return new TargetbelegungCollection();
                }

                collection.AddItem(
                    new Targetbelegung()
                    {
                        Position = row.Cells[0].Value.ToString(),
                        Targetwerkstoff_ID = targetwerkstoffLableList[targetwerkstoffBezeichnung].Id,
                        Targetwerkstoff_Bezeichnung = targetwerkstoffBezeichnung,
                    }
                );
            }

            return collection;
        }

        /// <summary>
        /// This is necessary to open the dropdown on the first click on the cell. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTargetBelegung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore Header and all columns except the second one.
            if ((e.RowIndex < 0) || (e.ColumnIndex != 1)){
                return;
            }

            // Expand Dropdown
            dataGridViewTargetBelegung.BeginEdit(true);
            ComboBox comboBox = (ComboBox)dataGridViewTargetBelegung.EditingControl;
            comboBox.DroppedDown = true;
        }
        
        // <summary>
        /// Add Prozess entity which allows to edit the entity by this form.
        /// </summary>
        public void AddProzess(Prozess prozess, int collectionId)
        {
            this.prozess = prozess;
            this.collectionId = collectionId;
            
            // Preselect ComboBox items 
            comboBoxAnlage.SelectedIndex = GetPositionOfEntity(comboBoxAnlage, prozess.GetAnlageBezeichnung());
            comboBoxModus.SelectedIndex = GetPositionOfEntity(comboBoxModus, prozess.GetModusBezeichnung());
            
            // Populate dataGridViewTargetBelegung
            SetTargetbelegungCollection(prozess.TargetbelegungCollection);
            
            // Populate dataGridViewProzessDaten
            prozessdatenCollection = prozess.ProzessdatenCollection;
            InitializeProzessdatensatzDataGridView();
        }

        /// <summary>
        /// Populate Dropdows with TargetBelegung values from TargetbelegungCollection.
        /// The function processes each row of the grid. If there is a TargetBelegung for the current position, it's value
        /// is saved as value for the Cell. Otherwise the cell gets an empty string as value. 
        /// </summary>
        /// <param name="collection"></param>
        private void SetTargetbelegungCollection(TargetbelegungCollection collection)
        {
            foreach (DataGridViewRow row in dataGridViewTargetBelegung.Rows)
            {
                try
                {
                    string position = row.Cells[0].Value.ToString();
                    Targetbelegung targetbelegung = collection.GetTargetbelegungByPosition(position);
                    row.Cells[1].Value = targetbelegung.Targetwerkstoff_Bezeichnung;
                }
                catch (InstanceNotFoundException)
                {
                    row.Cells[1].Value = "";
                }
            }
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

        private void dataGridViewProzessDaten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int collectionId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Prozessdatensatz currentItem = (Prozessdatensatz)prozessdatenCollection.GetItem(collectionId);

                if (senderGrid.Columns[e.ColumnIndex].Name == ButtonEditName)
                {
                    ProzessdatenAnlegen formProzessdatenAnlegen = new ProzessdatenAnlegen(this);
                    formProzessdatenAnlegen.AddProzessdaten(currentItem, collectionId);
                    formProzessdatenAnlegen.ShowDialog(this);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == ButtonDeleteName)
                {
                    // TODO: Ask, if really wants to delete.
                    prozessdatenCollection.DeleteItem(collectionId);
                }

                InitializeProzessdatensatzDataGridView();
            }
        }
    }
}
