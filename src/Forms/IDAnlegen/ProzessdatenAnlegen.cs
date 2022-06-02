using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;
using ProbenDatenbank.Forms.IDAnlegen;

namespace ProbenDatenbank.src.Forms.IDAnlegen
{
    public partial class ProzessdatenAnlegen : Form
    {
        private ProzessAnlegen parentForm;
        private Prozessdatensatz prozessdatensatz;
        private int collectionId;

        public ProzessdatenAnlegen(ProzessAnlegen parentForm)
        {
            this.parentForm = parentForm;
            prozessdatensatz = new Prozessdatensatz();
            collectionId = 0;
            InitializeComponent();
            
            RotationCollection items = new RotationCollection();
            foreach (Rotation item in items.GetItems())
            {
                comboBoxRotation.Items.Add(item);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Check if all necessary information is given an create a Prozessdatensatz entity object.
        /// This is passed to the parent form for a later saving into the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxRotation.SelectedIndex < 0)
            {
                MessageBox.Show(@"Wählen Sie eine Rotation aus.");
            }
            else if (listBoxProzessDaten.Items.Count <= 0)
            {
                MessageBox.Show(@"Bitte geben Sie ein Prozessdaten an.");
            }
            else if (listBoxLogDaten.Items.Count <= 0)
            {
                MessageBox.Show(@"Bitte geben Sie ein Logdaten an.");
            }
            else
            {
                Rotation selectedRotation = (Rotation) comboBoxRotation.SelectedItem;
                
                prozessdatensatz.Rotation_ID = selectedRotation.Id;
                prozessdatensatz.Rotation_Bezeichnung = selectedRotation.Bezeichnung;
                prozessdatensatz.Reihennummer = textBoxReihennummer.Text;
                prozessdatensatz.ProzessLink =
                    JsonConvert.SerializeObject(listBoxProzessDaten.Items, Formatting.Indented);
                prozessdatensatz.LogdatenLink = JsonConvert.SerializeObject(listBoxLogDaten.Items, Formatting.Indented);
                prozessdatensatz.ChargenLink =
                    JsonConvert.SerializeObject(listBoxChargenDaten.Items, Formatting.Indented);

                // Note: This item is not saved yet in the database, but stored in the parent form for a later saving.
                parentForm.AddProzessdaten(prozessdatensatz, collectionId);
                Close();
            }
        }

        public void AddProzessdaten(Prozessdatensatz prozessdatensatz, int collectionId)
        {
            this.prozessdatensatz = prozessdatensatz;
            this.collectionId = collectionId;

            comboBoxRotation.SelectedIndex = GetPositioOfEntity(comboBoxRotation, prozessdatensatz.Rotation_Bezeichnung);
            textBoxReihennummer.Text = prozessdatensatz.Reihennummer;
            
            addItemsToListBox(listBoxProzessDaten,  JsonConvert.DeserializeObject<List<string>>(prozessdatensatz.ProzessLink));
            addItemsToListBox(listBoxLogDaten,  JsonConvert.DeserializeObject<List<string>>(prozessdatensatz.LogdatenLink));
            addItemsToListBox(listBoxChargenDaten,  JsonConvert.DeserializeObject<List<string>>(prozessdatensatz.ChargenLink));
        }

        /// <summary>
        /// It is not possible to convert a deserialized object directly into an ObjectCollection.
        /// Therefore, this function walks through the list and adds the items one by one.
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="items"></param>
        private void addItemsToListBox(ListBox listBox, List<string> items)
        {
            foreach (string item in items)
            {
                listBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Check if label of Object is part of a ComboBox and return it's position.
        /// Returns -1 if label could not be found.
        /// </summary>
        /// <param name="comboBox">Search ComboBox</param>
        /// <param name="label">Label of object, which should be selected</param>
        /// <returns></returns>
        private int GetPositioOfEntity(ComboBox comboBox, string label)
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

        /**
         * ListBox ChargenDaten Events
         */
        private void listBoxChargenDaten_DragDrop(object sender, DragEventArgs e)
        {
            processListBoxDragAndDrop(listBoxChargenDaten, e);
        }

        private void listBoxChargenDaten_DragEnter(object sender, DragEventArgs e)
        {
            processListBoxDragEnter(e);
        }
        
        private void listBoxChargenDaten_KeyDown(object sender, KeyEventArgs e)
        {
            processListBoxKeyDown(listBoxChargenDaten, e);
        }

        /**
         * ListBox LogDaten Events
         */
        private void listBoxLogDaten_DragDrop(object sender, DragEventArgs e)
        {
            processListBoxDragAndDrop(listBoxLogDaten, e);
        }

        private void listBoxLogDaten_DragEnter(object sender, DragEventArgs e)
        {
            processListBoxDragEnter(e);
        }

        private void listBoxLogDaten_KeyDown(object sender, KeyEventArgs e)
        {
            processListBoxKeyDown(listBoxLogDaten, e);
        }

        /**
         * ListBox ProzessDaten Events
         */
        private void listBoxProzessDaten_DragDrop(object sender, DragEventArgs e)
        {
            processListBoxDragAndDrop(listBoxProzessDaten, e);
        }
        
        private void listBoxProzessDaten_DragEnter(object sender, DragEventArgs e)
        {
            processListBoxDragEnter(e);
        }
        
        private void listBoxProzessDaten_KeyDown(object sender, KeyEventArgs e)
        {
            processListBoxKeyDown(listBoxProzessDaten, e);
        }

        // Process functions for ListBoxEvents
        private void processListBoxDragAndDrop(ListBox listBox, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                listBox.Items.Add(files[i]);
            }
        }
        
        private void processListBoxDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void processListBoxKeyDown(ListBox listBox, KeyEventArgs e)
        {
            // Delete entry if "back" or "delete" is pressed.
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                if (listBox.SelectedIndex!=-1)
                {
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                }
            }
        }
    }
}
