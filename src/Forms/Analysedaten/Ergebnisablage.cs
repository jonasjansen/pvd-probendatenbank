using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;
using Newtonsoft.Json;

namespace ProbenDatenbank.Forms
{
    public partial class Ergebnisablage : Form
    {
        private Analysedaten parentForm;
        private Analyseergebnis analyseergebnis;
        private Beschichtung beschichtung;

        public Ergebnisablage(Analysedaten parentForm)
        {
            this.parentForm = parentForm;
            analyseergebnis = new Analyseergebnis();
            beschichtung = new Beschichtung();

            InitializeComponent();
            InitizalizeData();
        }

        private void InitizalizeData()
        {
            AnalysemethodeCollection analysemethodeCollection = new AnalysemethodeCollection();
            foreach (Analysemethode item in analysemethodeCollection.GetItems())
            {
                comboBoxAnalysemethode.Items.Add(item);
            }

            EigenschaftCollection eigenschaftCollection = new EigenschaftCollection();
            foreach (Eigenschaft item in eigenschaftCollection.GetItems())
            {
                comboBoxEigenschaft.Items.Add(item);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxAnalysemethode.SelectedIndex < 0)
            {
                MessageBox.Show(@"Wählen Sie eine Analysemethode aus.");
            }

            if (comboBoxEigenschaft.SelectedIndex < 0)
            {
                MessageBox.Show(@"Wählen Sie eine Eigenschaft aus.");
            }
            else if (!String.IsNullOrEmpty(textBoxWert.Text) && String.IsNullOrEmpty(textBoxEinheit.Text))
            {
                MessageBox.Show(@"Bitte geben Sie eine Einheit an.");
            }
            else
            {
                Analysemethode selectedAnalysemethode = (Analysemethode)comboBoxAnalysemethode.SelectedItem;
                Eigenschaft selectedEigenschaft = (Eigenschaft)comboBoxEigenschaft.SelectedItem;

                analyseergebnis.Beschichtung_ID = beschichtung.Id;
                analyseergebnis.Analysemethode_ID = selectedAnalysemethode.Id;
                analyseergebnis.Analysemethode_Bezeichnung = selectedAnalysemethode.Bezeichnung;
                analyseergebnis.Eigenschaft_ID = selectedEigenschaft.Id;
                analyseergebnis.Eigenschaft_Bezeichnung = selectedEigenschaft.Bezeichnung;
                analyseergebnis.Wert = textBoxWert.Text;
                analyseergebnis.Einheit = textBoxEinheit.Text;
                analyseergebnis.AnalysedatenLink =
                    JsonConvert.SerializeObject(listBoxErgebnisDaten.Items, Formatting.Indented);

                analyseergebnis.Save();
                
                //TODO Return Object to parent form. Might not be necessary, if parent form reloads from database.
                //Which might be the better approach, since the filter might be outdated.
                //parentForm.AddProzessdaten(item, collectionId);
                parentForm.UpdateForm();
                Close();
            }
        }

        private void listBoxErgebnisDaten_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                listBoxErgebnisDaten.Items.Add(files[i]);
            }
        }

        private void listBoxErgebnisDaten_DragEnter(object sender, DragEventArgs e)
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

        private void listBoxErgebnisDaten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                if (listBoxErgebnisDaten.SelectedIndex != -1)
                {
                    listBoxErgebnisDaten.Items.RemoveAt(listBoxErgebnisDaten.SelectedIndex);
                }
            }
        }

        public void AddBeschichtung(Beschichtung beschichtung)
        {
            this.beschichtung = beschichtung;
        }

        public void AddAnalyseergebnis(Analyseergebnis analyseergebnis)
        {
            this.analyseergebnis = analyseergebnis;
            
            // Preselect ComboBox items 
            comboBoxAnalysemethode.SelectedIndex = GetPositionOfEntity(comboBoxAnalysemethode, analyseergebnis.Analysemethode_Bezeichnung);
            comboBoxEigenschaft.SelectedIndex = GetPositionOfEntity(comboBoxEigenschaft, analyseergebnis.Eigenschaft_Bezeichnung);
            
            // Populate Textboxes
            textBoxWert.Text = analyseergebnis.Wert;
            textBoxEinheit.Text = analyseergebnis.Einheit;
            
            // Populate Listbox
            // TODO: deserialization does not work when loading form database.
            addItemsToListBox(listBoxErgebnisDaten,  JsonConvert.DeserializeObject<List<string>>(analyseergebnis.AnalysedatenLink));
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
    }
}