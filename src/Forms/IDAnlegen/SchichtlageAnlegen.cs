using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Forms.IDAnlegen
{
    public partial class SchichtlageAnlegen : Form
    {
        private IDAnlegen parentForm;
        private ProzessCollection prozessCollection;
        private Schichtlage schichtlage;
        private int collectionId;

        public SchichtlageAnlegen(IDAnlegen parentForm, ProzessCollection prozessCollection)
        {
            this.parentForm = parentForm;
            this.prozessCollection = prozessCollection;
            schichtlage = new Schichtlage();
            collectionId = 0;
            InitializeComponent();
            
            SchichtwerkstoffCollection schichtItems = new SchichtwerkstoffCollection();
            foreach (Schichtwerkstoff item in schichtItems.GetItems())
            {
                comboBoxSchichtwerkstoff.Items.Add(item);
            }

            SchichtarchitekturCollection architekturItems = new SchichtarchitekturCollection();
            foreach (Schichtarchitektur item in architekturItems.GetItems())
            {
                comboBoxSchichtarchitektur.Items.Add(item);
            }
            
            foreach (Prozess item in this.prozessCollection.GetItems())
            {
                comboBoxProzess.Items.Add(item);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPosition.Text))
            {
                MessageBox.Show(@"Bitte geben Sie eine Position an.");
            }
            else if (comboBoxSchichtarchitektur.SelectedIndex < 0)
            {
                MessageBox.Show(@"Bitte wählen Sie eine Schichtarchitektur aus.");
            }
            else if (comboBoxSchichtwerkstoff.SelectedIndex < 0)
            {
                MessageBox.Show(@"Bitte wählen Sie einen Schichtwerkstoff aus.");
            }
            else if (comboBoxProzess.SelectedIndex < 0)
            {
                MessageBox.Show(@"Bitte wählen Sie einen Prozess aus.");
            }
            else
            {
                Schichtarchitektur selectedArchitektur = (Schichtarchitektur)comboBoxSchichtarchitektur.SelectedItem;
                Schichtwerkstoff selectedWerkstoff = (Schichtwerkstoff)comboBoxSchichtwerkstoff.SelectedItem;
                Prozess selectedProzess = (Prozess)comboBoxProzess.SelectedItem;

                schichtlage.Prozess = selectedProzess;
                schichtlage.Schichtarchitektur_ID = selectedArchitektur.Id;
                schichtlage.Schichtarchitektur_Bezeichnung = selectedArchitektur.Bezeichnung;
                schichtlage.Schichtwerkstoff_ID = selectedWerkstoff.Id;
                schichtlage.Schichtwerkstoff_Bezeichnung = selectedWerkstoff.Bezeichnung;
                schichtlage.Position = textBoxPosition.Text;
                schichtlage.Beschichtungsdatum = dateTimeBeschichtungsdatum.Value.ToShortDateString();
                
                // Note: This item is not saved yet in the database, but stored in the parent form for a later saving.
                parentForm.AddSchicht( schichtlage, collectionId);
                Close();
            }
        }

        public void AddSchichtlage(Schichtlage schichtlage, int collectionId)
        {
            this.schichtlage = schichtlage;
            this.collectionId = collectionId;

            // Preselect items 
            textBoxPosition.Text = schichtlage.Position;
            comboBoxSchichtwerkstoff.SelectedIndex = GetPositioOfEntity(comboBoxSchichtwerkstoff, schichtlage.Schichtwerkstoff_Bezeichnung);
            comboBoxSchichtarchitektur.SelectedIndex = GetPositioOfEntity(comboBoxSchichtarchitektur, schichtlage.Schichtarchitektur_Bezeichnung);
            comboBoxProzess.SelectedIndex = GetPositioOfEntity(comboBoxProzess, schichtlage.Prozess_Bezeichnung);
            dateTimeBeschichtungsdatum.Text = schichtlage.Beschichtungsdatum;
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
    }
}
