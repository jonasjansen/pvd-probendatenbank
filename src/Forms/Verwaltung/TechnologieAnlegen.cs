using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Forms.Verwaltung
{
    public partial class TechnologieAnlegen : Form
    {
        public TechnologieAnlegen()
        {
            InitializeComponent();
            
            BereichCollection bereichCollection = new BereichCollection();
            foreach (Bereich item in bereichCollection.GetItems())
            {
                comboBoxBereich.Items.Add(item);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxBezeichnung.Text))
            {
                MessageBox.Show(@"Bitte geben Sie eine Bezeichnung ein.");
            }
            else if(comboBoxBereich.SelectedIndex < 0)
            {
                MessageBox.Show(@"Wählen Sie einen Bereich aus.");
            }
            else
            {
                Bereich selectedBereich = (Bereich) comboBoxBereich.SelectedItem;
                Technologie item = new Technologie
                {
                    Bezeichnung = textBoxBezeichnung.Text,
                    Bereich_ID = selectedBereich.Id,
                    Bereich_Bezeichnung = selectedBereich.Bezeichnung
                    
                };
                item.Save();
                MessageBox.Show(@"Neue Technologie wurde erfolgreich angelegt.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
